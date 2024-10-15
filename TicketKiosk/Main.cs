using ClosedXML.Excel;
using OBS.Database;
using OBS.DTO;
using OBS.Extensions;
using OBS.Interface;
using OBS.Models;
using OBS.Repository;
using OBS.UC;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace OBS
{
    public partial class Main : Form
    {
        #region Public Defines

        public Users loggedInUser;

        #endregion

        #region Private Defines

        private static Color _darkMode_Color = Color.FromArgb(1, 42, 42, 42);
        private IBusRoutes _IBusRoutes = new BusRoutesRepository();
        private IBus _IBus = new BusRepository();
        private ILogs _ILogs = new LogsRepository();
        private IUsers _IUsers = new UserRepository();
        private ITicket _ITicket = new TicketRepository();
        private LogCode logger = LogCode.Instance;

        private string _selectedBusID;
        private string _selectedUserID;
        private string _selectedRouteID;
        private string _selectedTicketID;

        #endregion

        #region Singleton implementation

        private static Main instance;
        private Main()
        {
            InitializeComponent();
            CustomWindow.setBorder(_darkMode_Color, Color.White, _darkMode_Color, Handle);
        }

        public static Main Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Main();
                }
                return instance;
            }
        }

        #endregion

        public void RefreshWindow()
        {
            UpdateTimer.Enabled = true;
            LongUpdateTimer.Enabled = true;

            LogGridView.DataSource = _ILogs.GetLogs();
            UserGridView.DataSource = _IUsers.GetUserDetails();
            BusGridView.DataSource = _IBus.GetBusDetails();
            RouteGridView.DataSource = _IBusRoutes.GetBusRoutesDetails();
            TicketGridView.DataSource = _ITicket.GetTicketDetails();

            var RList = RouteList.drawList(_IBusRoutes.GetBusRoutesDetails(), _IBus, 75, 50);

            RouteList.RemoveDynamicallyAddedControls("routeListItem", UserView);

            if (!(RList.Count == 0))
            {
                foreach (var routeListItem in RList)
                {
                    UserView.Controls.Add(routeListItem);
                }
            }
        }

        public void Main_Load(object sender, EventArgs e)
        {
            RefreshWindow();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            loggedInUser = null;
            Login loginPage = Login.Instance;
            loginPage.Show();
            this.Hide();
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            UserGridView.DataSource = _IUsers.GetUserDetails();
            BusGridView.DataSource = _IBus.GetBusDetails();
            RouteGridView.DataSource = _IBusRoutes.GetBusRoutesDetails();
            TicketGridView.DataSource = _ITicket.GetTicketDetails();
        }

        #region BusOptions

        private void BusAddButton_Click(object sender, EventArgs e)
        {
            BusAdd busPage = BusAdd.Instance;
            busPage.editMode = false;
            busPage.editGUID = "";

            busPage.ShowDialog();
        }

        private void BusEditButton_Click(object sender, EventArgs e)
        {
            BusAdd busPage = BusAdd.Instance;
            busPage.editMode = true;
            busPage.editGUID = _selectedBusID;

            busPage.ShowDialog();
        }

        private void BusGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (BusGridView.SelectedCells.Count > 0 && BusGridView.SelectedCells.Count < 2)
            {
                int selectedrowindex = BusGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = BusGridView.Rows[selectedrowindex];
                _selectedBusID = Convert.ToString(selectedRow.Cells["BusID"].Value);
            }
        }

        private void BusDeleteButton_Click(object sender, EventArgs e)
        {
            Bus BusObject = _IBus.GetBusDetails(_selectedBusID);
            DialogResult dialogResult = MessageBox.Show(BusObject.LicensePlate + " plakalı kayıtı silmek istiyor musunuz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    _IBus.DeleteBus(_selectedBusID);
                    logger.printLog(2, loggedInUser.Username, "The bus with the id : " + BusObject.BusID + " has been deleted. ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kayıtı silerken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.printLog(0, loggedInUser.Username, "Failed when deleting bus with the id : " + BusObject.BusID + " / Error : " + ex.Message);
                }
            }
        }

        #endregion

        #region UserOptions

        private void UserAddButton_Click(object sender, EventArgs e)
        {
            UserAdd userPage = UserAdd.Instance;
            userPage.editMode = false;
            userPage.editGUID = "";

            userPage.ShowDialog();
        }

        private void UserUpdateButton_Click(object sender, EventArgs e)
        {
            UserAdd userPage = UserAdd.Instance;
            userPage.editMode = true;
            userPage.editGUID = _selectedUserID;

            userPage.ShowDialog();
        }

        private void UserDeleteButton_Click(object sender, EventArgs e)
        {
            Users UserObject = _IUsers.GetUserDetails(_selectedUserID);
            DialogResult dialogResult = MessageBox.Show(UserObject.Username + " adlı kullanıcı kayıtını silmek istiyor musunuz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    _IUsers.DeleteUser(_selectedUserID);
                    logger.printLog(2, loggedInUser.Username, "The user with the id : " + UserObject.Uuid + " has been deleted. ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kayıtı silerken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.printLog(0, loggedInUser.Username, "Failed when deleting user with the id : " + UserObject.Uuid + " / Error : " + ex.Message);
                }
            }
        }

        private void UserGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (UserGridView.SelectedCells.Count > 0 && UserGridView.SelectedCells.Count < 2)
            {
                int selectedrowindex = UserGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = UserGridView.Rows[selectedrowindex];
                _selectedUserID = Convert.ToString(selectedRow.Cells["Uuid"].Value);
            }
        }

        #endregion

        #region RouteOptions

        private void RouteAddButton_Click(object sender, EventArgs e)
        {
            RouteAdd routePage = RouteAdd.Instance;
            routePage.editMode = false;
            routePage.editGUID = "";

            routePage.ShowDialog();
        }

        private void RouteEditButton_Click(object sender, EventArgs e)
        {
            RouteAdd routePage = RouteAdd.Instance;
            routePage.editMode = true;
            routePage.editGUID = _selectedRouteID;

            routePage.ShowDialog();
        }

        private void RouteDeleteButton_Click(object sender, EventArgs e)
        {
            BusRoutes RouteObject = _IBusRoutes.GetBusRoutesDetails(_selectedRouteID);
            DialogResult dialogResult = MessageBox.Show(RouteObject.DepartureLocation + " ile " + RouteObject.DestinationLocation + " arasında giden rota kayıtını silmek istiyor musunuz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    _IBusRoutes.DeleteBusRoutes(_selectedRouteID);
                    logger.printLog(2, loggedInUser.Username, "The route with the id : " + RouteObject.RouteID + " has been deleted. ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kayıtı silerken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.printLog(0, loggedInUser.Username, "Failed when deleting route with the id : " + RouteObject.RouteID + " / Error : " + ex.Message);
                }
            }
        }

        private void RouteGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (RouteGridView.SelectedCells.Count > 0 && RouteGridView.SelectedCells.Count < 2)
            {
                int selectedrowindex = RouteGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = RouteGridView.Rows[selectedrowindex];
                _selectedRouteID = Convert.ToString(selectedRow.Cells["RouteID"].Value);
            }
        }

        #endregion

        #region TicketOptions

        private void TicketAddButton_Click(object sender, EventArgs e)
        {
            TicketAdd ticketPage = TicketAdd.Instance;
            ticketPage.editMode = false;
            ticketPage.editGUID = "";

            ticketPage.ShowDialog();
        }

        private void TicketEditButton_Click(object sender, EventArgs e)
        {
            TicketAdd ticketPage = TicketAdd.Instance;
            ticketPage.editMode = true;
            ticketPage.editGUID = _selectedTicketID;

            ticketPage.ShowDialog();
        }

        private void TicketDeleteButton_Click(object sender, EventArgs e)
        {
            Ticket TicketObject = _ITicket.GetTicketDetails(_selectedTicketID);
            Users UserObject = _IUsers.GetUserDetails(TicketObject.TicketUserID);
            BusRoutes RouteObject = _IBusRoutes.GetBusRoutesDetails(TicketObject.TicketRouteID);
            DialogResult dialogResult = MessageBox.Show(UserObject.Name + " " + UserObject.Surname + " adlı kişinin " + RouteObject.DestinationLocation + " giden bilet kayıtını silmek istiyor musunuz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    _IBusRoutes.RemoveSeat(TicketObject.Seat, TicketObject.TicketRouteID);
                    _ITicket.DeleteTicket(_selectedTicketID);
                    logger.printLog(2, loggedInUser.Username, "The ticket with the id : " + TicketObject.TicketID + " has been deleted. ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kayıtı silerken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.printLog(0, loggedInUser.Username, "Failed when deleting ticket with the id : " + TicketObject.TicketID + " / Error : " + ex.Message);
                }
            }
        }

        private void TicketGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (TicketGridView.SelectedCells.Count > 0 && TicketGridView.SelectedCells.Count < 2)
            {
                int selectedrowindex = TicketGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = TicketGridView.Rows[selectedrowindex];
                _selectedTicketID = Convert.ToString(selectedRow.Cells["TicketID"].Value);
            }
        }

        #endregion

        #region ExportLogs

        private void ExportLogsButton_Click(object sender, EventArgs e)
        {
            var workbook = new XLWorkbook();
            workbook.AddWorksheet("Logs");
            var ws = workbook.Worksheet("Logs");

            int row = 1;
            ws.Cell("A" + row.ToString()).Value = "LogID";
            ws.Cell("B" + row.ToString()).Value = "Date";
            ws.Cell("C" + row.ToString()).Value = "User";
            ws.Cell("D" + row.ToString()).Value = "PCName";
            ws.Cell("E" + row.ToString()).Value = "IP";
            ws.Cell("F" + row.ToString()).Value = "Status";
            ws.Cell("G" + row.ToString()).Value = "Message";
            ws.Cells().Style.Fill.SetBackgroundColor(XLColor.Almond);
            row++;
            foreach (var item in _ILogs.GetLogs())
            {
                ws.Cell("A" + row.ToString()).Value = item.LogID;
                ws.Cell("B" + row.ToString()).Value = item.Date.ToShortDateString() + " " + item.Date.ToShortTimeString();
                ws.Cell("C" + row.ToString()).Value = item.User;
                ws.Cell("D" + row.ToString()).Value = item.PCName;
                ws.Cell("E" + row.ToString()).Value = item.Ip;
                ws.Cell("F" + row.ToString()).Value = item.Status;
                ws.Cell("G" + row.ToString()).Value = item.Message;
                row++;
            }
            ws.Columns().AdjustToContents();

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Dosyası|*.xlsx";
            saveFileDialog.Title = "Dışa Aktar";
            saveFileDialog.FileName = "LogsExcel.xlsx";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                workbook.SaveAs(saveFileDialog.FileName);
                logger.printLog(2, loggedInUser.Username, "Exported Logs to excel file.");
            }
        }

        #endregion

        #region ExportTickets

        private void ExportTicketsButton_Click(object sender, EventArgs e)
        {
            var workbook = new XLWorkbook();
            workbook.AddWorksheet("Tickets");
            var ws = workbook.Worksheet("Tickets");

            int row = 1;
            ws.Cell("A" + row.ToString()).Value = "TicketID";
            ws.Cell("B" + row.ToString()).Value = "TicketUserID";
            ws.Cell("C" + row.ToString()).Value = "TicketRouteID";
            ws.Cell("D" + row.ToString()).Value = "Pnr";
            ws.Cell("E" + row.ToString()).Value = "Seat";
            ws.Cells().Style.Fill.SetBackgroundColor(XLColor.Almond);
            row++;
            foreach (var item in _ITicket.GetTicketDetails())
            {
                ws.Cell("A" + row.ToString()).Value = item.TicketID;
                ws.Cell("B" + row.ToString()).Value = item.TicketUserID;
                ws.Cell("C" + row.ToString()).Value = item.TicketRouteID;
                ws.Cell("D" + row.ToString()).Value = item.Pnr;
                ws.Cell("E" + row.ToString()).Value = Convert.ToString(item.Seat);
                row++;
            }
            ws.Columns().AdjustToContents();

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Dosyası|*.xlsx";
            saveFileDialog.Title = "Dışa Aktar";
            saveFileDialog.FileName = "TicketsExcel.xlsx";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                workbook.SaveAs(saveFileDialog.FileName);
                logger.printLog(2, loggedInUser.Username, "Exported Tickets to excel file.");
            }
        }

        #endregion

        #region ExportRoutes

        private void ExportRoutesButton_Click(object sender, EventArgs e)
        {
            var workbook = new XLWorkbook();
            workbook.AddWorksheet("Routes");
            var ws = workbook.Worksheet("Routes");

            int row = 1;
            ws.Cell("A" + row.ToString()).Value = "RouteID";
            ws.Cell("B" + row.ToString()).Value = "UsedBusID";
            ws.Cell("C" + row.ToString()).Value = "Date";
            ws.Cell("D" + row.ToString()).Value = "ETA";
            ws.Cell("E" + row.ToString()).Value = "DepartureLocation";
            ws.Cell("F" + row.ToString()).Value = "DestinationLocation";
            ws.Cell("G" + row.ToString()).Value = "Price";
            ws.Cell("H" + row.ToString()).Value = "ReservedSeats";
            ws.Cells().Style.Fill.SetBackgroundColor(XLColor.Almond);
            row++;
            foreach (var item in _IBusRoutes.GetBusRoutesDetails())
            {
                ws.Cell("A" + row.ToString()).Value = item.RouteID;
                ws.Cell("B" + row.ToString()).Value = item.UsedBusID;
                ws.Cell("C" + row.ToString()).Value = item.Date.ToShortDateString() + " " + item.Date.ToShortTimeString();
                ws.Cell("D" + row.ToString()).Value = item.ETA;
                ws.Cell("E" + row.ToString()).Value = item.DepartureLocation;
                ws.Cell("F" + row.ToString()).Value = item.DestinationLocation;
                ws.Cell("G" + row.ToString()).Value = Convert.ToString(item.Price);
                ws.Cell("H" + row.ToString()).Value = item.ReservedSeats;
                row++;
            }
            ws.Columns().AdjustToContents();

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Dosyası|*.xlsx";
            saveFileDialog.Title = "Dışa Aktar";
            saveFileDialog.FileName = "RoutesExcel.xlsx";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                workbook.SaveAs(saveFileDialog.FileName);
                logger.printLog(2, loggedInUser.Username, "Exported Routes to excel file.");
            }
        }

        #endregion

        #region ExportBusses

        private void ExportBussesButton_Click(object sender, EventArgs e)
        {
            var workbook = new XLWorkbook();
            workbook.AddWorksheet("Busses");
            var ws = workbook.Worksheet("Busses");

            int row = 1;
            ws.Cell("A" + row.ToString()).Value = "BusID";
            ws.Cell("B" + row.ToString()).Value = "LicensePlate";
            ws.Cell("C" + row.ToString()).Value = "SeatingOrder";
            ws.Cell("D" + row.ToString()).Value = "MaxPassengers";
            ws.Cells().Style.Fill.SetBackgroundColor(XLColor.Almond);
            row++;
            foreach (var item in _IBus.GetBusDetails())
            {
                ws.Cell("A" + row.ToString()).Value = item.BusID;
                ws.Cell("B" + row.ToString()).Value = item.LicensePlate;
                ws.Cell("C" + row.ToString()).Value = item.SeatingOrder;
                ws.Cell("D" + row.ToString()).Value = item.MaxPassengers;
                row++;
            }
            ws.Columns().AdjustToContents();

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Dosyası|*.xlsx";
            saveFileDialog.Title = "Dışa Aktar";
            saveFileDialog.FileName = "BussesExcel.xlsx";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                workbook.SaveAs(saveFileDialog.FileName);
                logger.printLog(2, loggedInUser.Username, "Exported Busses to excel file.");
            }
        }

        #endregion

        #region ExportUsers

        private void ExportUsersButton_Click(object sender, EventArgs e)
        {
            var workbook = new XLWorkbook();
            workbook.AddWorksheet("Users");
            var ws = workbook.Worksheet("Users");

            int row = 1;
            ws.Cell("A" + row.ToString()).Value = "UUID";
            ws.Cell("B" + row.ToString()).Value = "GovID";
            ws.Cell("C" + row.ToString()).Value = "Username";
            ws.Cell("D" + row.ToString()).Value = "Phone";
            ws.Cell("E" + row.ToString()).Value = "Email";
            ws.Cell("F" + row.ToString()).Value = "AuthorityLevel";
            ws.Cell("G" + row.ToString()).Value = "Name";
            ws.Cell("H" + row.ToString()).Value = "Surname";
            ws.Cell("I" + row.ToString()).Value = "Gender";
            ws.Cells().Style.Fill.SetBackgroundColor(XLColor.Almond);
            row++;
            foreach (var item in _IUsers.GetUserDetails())
            {
                ws.Cell("A" + row.ToString()).Value = item.Uuid;
                ws.Cell("B" + row.ToString()).Value = item.GovID;
                ws.Cell("C" + row.ToString()).Value = item.Username;
                ws.Cell("D" + row.ToString()).Value = item.Phone;
                ws.Cell("E" + row.ToString()).Value = item.Email;
                ws.Cell("F" + row.ToString()).Value = item.AuthorityLevel;
                ws.Cell("G" + row.ToString()).Value = item.Name;
                ws.Cell("H" + row.ToString()).Value = item.Surname;
                ws.Cell("I" + row.ToString()).Value = item.Gender;
                row++;
            }
            ws.Columns().AdjustToContents();

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Dosyası|*.xlsx";
            saveFileDialog.Title = "Dışa Aktar";
            saveFileDialog.FileName = "UsersExcel.xlsx";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                workbook.SaveAs(saveFileDialog.FileName);
                logger.printLog(2, loggedInUser.Username, "Exported Users to excel file.");
            }
        }

        #endregion

        private void LongUpdateTimer_Tick(object sender, EventArgs e)
        {
            LogGridView.DataSource = _ILogs.GetLogs();
        }
    }
}
