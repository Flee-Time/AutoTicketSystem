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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBS
{
    public partial class TicketBuy : Form
    {
        #region Public Defines

        public int selectedSeat = 99999;
        public string userID;
        public string routeID;

        #endregion

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

        private static TicketBuy instance;
        private TicketBuy()
        {
            InitializeComponent();
            CustomWindow.setBorder(_darkMode_Color, Color.White, _darkMode_Color, Handle);
        }

        public static TicketBuy Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TicketBuy();
                }
                return instance;
            }
        }

        #endregion

        private void resetAndClose()
        {
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
            SeatGB.Controls.Clear();
            this.Hide();
        }

        private void UpdateRouteInfo()
        {
            BusRoutes route = _IBusRoutes.GetBusRoutesDetails(routeID);

            DepartureLabel.Text = "Kalkış Yeri : " + route.DepartureLocation;
            DestinationLabel.Text = "Varış Yeri : " + route.DestinationLocation;
            RouteDate.Text = "Tarih : " + route.Date.ToShortDateString() + " " + route.Date.ToShortTimeString();
            EtaLabel.Text = "Tahmini Yol Süresi : " + route.ETA + " Saat";
            PriceLabel.Text = "Fiyat : " + Convert.ToString(route.Price) + "₺";
            PlateLabel.Text = "Plaka : " + _IBus.GetBusDetails(route.UsedBusID).LicensePlate;
        }

        private void UpdateUserInfo()
        {
            Users user = _IUsers.GetUserDetails(userID);

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

        private void SeatSelect()
        {
            SeatGB.Controls.Clear();

            BusRoutes routesObject = _IBusRoutes.GetBusRoutesDetails(routeID);
            Bus busObject = _IBus.GetBusDetails(routesObject.UsedBusID);

            SeatSelection seatSel = new SeatSelection(busObject.SeatingOrder, routesObject.ReservedSeats, Convert.ToUInt16(busObject.MaxPassengers), false);
            SeatGB.Controls.Add(seatSel);
        }

        private void TicketBuy_Shown(object sender, EventArgs e)
        {
            CustomWindow.setBorder(_darkMode_Color, Color.White, _darkMode_Color, Handle);

            UpdateUserInfo();
            UpdateRouteInfo();
            SeatSelect();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            resetAndClose();
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            newTicketObject.TicketID = Convert.ToString(Guid.NewGuid());
            newTicketObject.Pnr = GenerateRandomString();
            newTicketObject.TicketUserID = userID;
            newTicketObject.TicketRouteID = routeID;
            newTicketObject.Seat = selectedSeat;

            if (_IBusRoutes.ReserveSeat(newTicketObject.Seat, newTicketObject.TicketRouteID))
            {
                try
                {
                    _ITicket.AddTicket(newTicketObject);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Biletiniz alınırken bilinmeyen bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.printLog(0, _IUsers.GetUserDetails(userID).Username, "Failed when buying ticket / Error : " + ex.Message);
                }
                MessageBox.Show("Biletiniz alınmıştır. Biletlerim ekranından görebilirsiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                logger.printLog(2, _IUsers.GetUserDetails(userID).Username, "Bought ticket with the id : " + newTicketObject.TicketID);
                resetAndClose();
            }
            else
            {
                MessageBox.Show("Seçtiğiniz koltuk zaten alınmıştır veya girdiğiniz koltuk numarası hatalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void TicketBuy_FormClosing(object sender, FormClosingEventArgs e)
        {
            resetAndClose();
        }
    }
}
