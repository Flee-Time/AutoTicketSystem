using Microsoft.EntityFrameworkCore;
using OBS.Database;
using OBS.Extensions;
using OBS.Interface;
using OBS.Models;
using OBS.Repository;
using OBS.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBS
{
    public partial class TicketAdd : Form
    {
        #region Private Defines

        private static Color _darkMode_Color = Color.FromArgb(1, 42, 42, 42);
        private IBus _IBus = new BusRepository();
        private IUsers _IUsers = new UserRepository();
        private IBusRoutes _IBusRoutes = new BusRoutesRepository();
        private ITicket _ITicket = new TicketRepository();
        private Ticket newTicketObject = new Ticket();
        private LogCode logger = LogCode.Instance;

        #endregion

        #region Singleton implementation

        private static TicketAdd instance;
        private TicketAdd()
        {
            InitializeComponent();
            CustomWindow.setBorder(_darkMode_Color, Color.White, _darkMode_Color, Handle);
        }

        public static TicketAdd Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TicketAdd();
                }
                return instance;
            }
        }

        #endregion

        public int selectedSeat = 99999;
        public bool editMode = false;
        public string editGUID = "";

        private void resetAndClose()
        {
            editGUID = "";
            editMode = false;
            GovIDLabel.Text = "TC Kimlik No : ";
            NameLabel.Text = "Ad : ";
            SurnameLabel.Text = "Soyad : ";
            PhoneLabel.Text = "Telefon : ";
            EmailLabel.Text = "E-Posta : ";
            GenderLabel.Text = "Cinsiyet : ";
            DepartureLabel.Text = "Kalkış Yeri : ";
            DestinationLabel.Text = "Varış Yeri : ";
            RouteDate.Text = "Tarih : ";
            EtaLabel.Text = "Tahmini Yol Süresi : ";
            PriceLabel.Text = "Fiyat : ";
            PlateLabel.Text = "Plaka : ";
            UserSelectCB.Text = "";
            RouteSelectCB.Text = "";
            SeatGB.Controls.Clear();
            this.Hide();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!editMode)
            {
                newTicketObject.Pnr = GenerateRandomString();

                newTicketObject.TicketUserID = _IUsers.GetUserByGovID(UserSelectCB.Text).Uuid;
                newTicketObject.TicketRouteID = RouteSelectCB.Text.Split(", ")[2];
                newTicketObject.Seat = selectedSeat;

                if (_IBusRoutes.ReserveSeat(newTicketObject.Seat, newTicketObject.TicketRouteID))
                {
                    try
                    {
                        _ITicket.AddTicket(newTicketObject);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bilet kayıtını oluşturulurken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        logger.printLog(0, Main.Instance.loggedInUser.Username, "Failed when creating ticket entry / Error : " + ex.Message);
                    }
                    MessageBox.Show("Başarıyla yeni kayıt oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    logger.printLog(2, Main.Instance.loggedInUser.Username, "Created ticket with the id : " + newTicketObject.TicketID);
                    resetAndClose();
                }
                else
                {
                    MessageBox.Show("Seçtiğiniz koltuk zaten alınmıştır veya girdiğiniz koltuk numarası hatalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Ticket editTicketObject = new Ticket();
                Ticket lastTicketObject = _ITicket.GetTicketDetails(editGUID);
                editTicketObject.TicketID = editGUID;
                editTicketObject.Pnr = lastTicketObject.Pnr;

                editTicketObject.TicketUserID = _IUsers.GetUserByGovID(UserSelectCB.Text).Uuid;
                editTicketObject.TicketRouteID = RouteSelectCB.Text.Split(", ")[2];
                editTicketObject.Seat = Convert.ToInt16(selectedSeat);

                if (_IBusRoutes.ReserveSeat(editTicketObject.Seat, editTicketObject.TicketRouteID))
                {
                    try
                    {
                        _IBusRoutes.RemoveSeat(lastTicketObject.Seat, editTicketObject.TicketRouteID);
                        _ITicket.UpdateTicket(editTicketObject);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bilet kayıtını güncellerken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        logger.printLog(0, Main.Instance.loggedInUser.Username, "Failed when editing ticket entry / Error : " + ex.Message);
                    }
                    MessageBox.Show("Başarıyla kayıt düzenlendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    logger.printLog(2, Main.Instance.loggedInUser.Username, "Edited ticket with the id : " + editTicketObject.TicketID);
                    resetAndClose();
                }
                else
                {
                    MessageBox.Show("Seçtiğiniz koltuk zaten alınmıştır veya girdiğiniz koltuk numarası hatalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            resetAndClose();
        }

        private void UpdateRouteInfo()
        {
            if (RouteSelectCB.Text != string.Empty)
            {
                BusRoutes route = _IBusRoutes.GetBusRoutesDetails(RouteSelectCB.Text.Split(", ")[2]);

                DepartureLabel.Text = "Kalkış Yeri : " + route.DepartureLocation;
                DestinationLabel.Text = "Varış Yeri : " + route.DestinationLocation;
                RouteDate.Text = "Tarih : " + route.Date.ToShortDateString() + " " + route.Date.ToShortTimeString();
                EtaLabel.Text = "Tahmini Yol Süresi : " + route.ETA + " Saat";
                PriceLabel.Text = "Fiyat : " + Convert.ToString(route.Price) + "₺";
                PlateLabel.Text = "Plaka : " + _IBus.GetBusDetails(route.UsedBusID).LicensePlate;
            }
        }

        private void UpdateUserInfo()
        {
            if (UserSelectCB.Text != string.Empty)
            {
                Users user = _IUsers.GetUserByGovID(UserSelectCB.Text);

                GovIDLabel.Text = "TC Kimlik No : " + user.GovID;
                NameLabel.Text = "Ad : " + user.Name;
                SurnameLabel.Text = "Soyad : " + user.Surname;
                PhoneLabel.Text = "Telefon : " + user.Phone;
                EmailLabel.Text = "E-Posta : " + user.Email;
                if (user.Gender == "Male")
                {
                    GenderLabel.Text = "Cinsiyet : Erkek";
                }
                else
                {
                    GenderLabel.Text = "Cinsiyet : Kadın";
                }
            }
        }

        private void UserSelectCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUserInfo();
            SeatSelect();
        }
        private void RouteSelectCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateRouteInfo();
            SeatSelect();
        }

        private void SeatSelect()
        {
            if (RouteSelectCB.Text != string.Empty && UserSelectCB.Text != string.Empty)
            {
                SeatGB.Visible = true;

                SeatGB.Controls.Clear();

                Bus busObject = _IBus.GetBusDetails(_IBusRoutes.GetBusRoutesDetails(RouteSelectCB.Text.Split(", ")[2]).UsedBusID);
                BusRoutes routesObject = _IBusRoutes.GetBusRoutesDetails(RouteSelectCB.Text.Split(", ")[2]);

                SeatSelection seatSel = new SeatSelection(busObject.SeatingOrder, routesObject.ReservedSeats, Convert.ToUInt16(busObject.MaxPassengers), true);
                SeatGB.Controls.Add(seatSel);
            }
            else
            {
                SeatGB.Visible = false;
            }
        }

        private void TicketAdd_Shown(object sender, EventArgs e)
        {
            CustomWindow.setBorder(_darkMode_Color, Color.White, _darkMode_Color, Handle);

            RouteSelectCB.Items.Clear();
            UserSelectCB.Items.Clear();

            RouteSelectCB.Items.Add("");
            UserSelectCB.Items.Add("");

            foreach (BusRoutes route in _IBusRoutes.GetBusRoutesDetails())
            {
                RouteSelectCB.Items.Add(route.DepartureLocation + ", " + route.DestinationLocation + ", " + route.RouteID);
            }

            foreach (Users user in _IUsers.GetUserDetails())
            {
                UserSelectCB.Items.Add(user.GovID);
            }

            if (editMode)
            {
                Ticket lastTicketObject = _ITicket.GetTicketDetails(editGUID);
                BusRoutes route = _IBusRoutes.GetBusRoutesDetails(lastTicketObject.TicketRouteID);

                IDLabel.Text = "ID : " + editGUID;
                UserSelectCB.Text = _IUsers.GetUserDetails(lastTicketObject.TicketUserID).GovID;
                RouteSelectCB.Text = route.DepartureLocation + ", " + route.DestinationLocation + ", " + route.RouteID;
            }
            else
            {
                newTicketObject.TicketID = Convert.ToString(Guid.NewGuid());
                IDLabel.Text = "ID : " + newTicketObject.TicketID;
            }

            UpdateUserInfo();
            UpdateRouteInfo();
        }

        private static string GenerateRandomString()
        {
            const string allowedChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random random = new Random();

            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < 6; i++)
            {
                char randomChar = allowedChars[random.Next(allowedChars.Length)];
                stringBuilder.Append(randomChar);
            }

            return stringBuilder.ToString();
        }
    }
}
