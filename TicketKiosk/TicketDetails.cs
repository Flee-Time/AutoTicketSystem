using OBS.Extensions;
using OBS.Interface;
using OBS.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using OBS.Models;
using DocumentFormat.OpenXml.EMMA;
using QRCoder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace OBS
{
    public partial class TicketDetails : Form
    {
        #region Public Defines

        public string TicketID;

        #endregion

        #region Private Defines

        private static Color _darkMode_Color = Color.FromArgb(1, 42, 42, 42);
        private ITicket _ITicket = new TicketRepository();
        private IBusRoutes _IBusRoutes = new BusRoutesRepository();
        private IBus _IBus = new BusRepository();
        private IUsers _IUsers = new UserRepository();
        private LogCode logger = LogCode.Instance;

        #endregion

        #region Singleton implementation

        private static TicketDetails instance;
        private TicketDetails()
        {
            InitializeComponent();
            CustomWindow.setBorder(_darkMode_Color, Color.White, _darkMode_Color, Handle);
        }

        public static TicketDetails Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TicketDetails();
                }
                return instance;
            }
        }

        #endregion

        private void TicketDetails_Shown(object sender, EventArgs e)
        {
            CustomWindow.setBorder(_darkMode_Color, Color.White, _darkMode_Color, Handle);

            Ticket ticket = _ITicket.GetTicketDetails(TicketID);
            BusRoutes busRoute = _IBusRoutes.GetBusRoutesDetails(ticket.TicketRouteID);
            Bus bus = _IBus.GetBusDetails(busRoute.UsedBusID);
            Users user = _IUsers.GetUserDetails(ticket.TicketUserID);

            GovIDLabel.Text = "TC Kimlik No :    " + user.GovID;
            NameLabel.Text = "Ad :    " + user.Name;
            SurnameLabel.Text = "Soyad :    " + user.Surname;

            DepartureLabel.Text = "Kalkış Yeri :    " + busRoute.DepartureLocation;
            DestinationLabel.Text = "Varış Yeri :    " + busRoute.DestinationLocation;
            DateLabel.Text = "Tarih :    " + busRoute.Date.ToShortDateString();
            DepartureTimeLabel.Text = "Kalkış Saati :    " + busRoute.Date.ToShortTimeString();
            EtaLabel.Text = "Tahmini Yol Süresi :    " + busRoute.ETA;
            PlateLabel.Text = "Plaka :    " + bus.LicensePlate;
            PriceLabel.Text = "Fiyat :    " + Convert.ToString(busRoute.Price) + "₺";
            SeatLabel.Text = "Koltuk No :    " + Convert.ToString(ticket.Seat);
            PNRLabel.Text = "PNR :    " + ticket.Pnr;
        }

        private void PrintTicketButton_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument;

            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;

            // Uncomment the following line if you want to show the PrintDialog
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            // If the user clicks OK in the PrintDialog, print the document
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                // Subscribe to PrintController's PrintPage event
                printDocument.PrintController = new StandardPrintController();
                printDocument.DefaultPageSettings.Margins.Left = 0;
                printDocument.DefaultPageSettings.Margins.Right = 0;
                printDocument.DefaultPageSettings.Margins.Top = 0;
                printDocument.DefaultPageSettings.Margins.Bottom = 0;
                printDocument.DefaultPageSettings.PaperSize = new PaperSize("", 420, 550);
                printDocument.Print();
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Ticket ticket = _ITicket.GetTicketDetails(TicketID);
            BusRoutes busRoute = _IBusRoutes.GetBusRoutesDetails(ticket.TicketRouteID);
            Bus bus = _IBus.GetBusDetails(busRoute.UsedBusID);
            Users user = _IUsers.GetUserDetails(ticket.TicketUserID);

            Graphics g = e.Graphics;
            Font font = new Font("Lucida Console", 15, FontStyle.Bold);
            Font font1 = new Font("Lucida Console", 15, FontStyle.Italic);
            Font font2 = new Font("Lucida Console", 26, FontStyle.Bold);

            // Set up the ticket layout
            int margin = 20;
            int lineHeight = 25;
            int yPos = margin;

            // Draw ticket information
            g.DrawRectangle(Pens.Black, 5, 5, 410, 540);
            g.DrawString("Otobüs Bileti", font2, Brushes.Black, 50, yPos);
            g.DrawString("------------------------------", font1, Brushes.Black, 10, 60);

            yPos += 70;
            g.DrawString("Kalkış Tarih/Saati:", font, Brushes.Black, margin, yPos);
            yPos += lineHeight;
            g.DrawString(busRoute.Date.ToString("yyyy-MM-dd HH:mm"), font1, Brushes.Black, margin + 10, yPos);
            yPos += lineHeight;
            g.DrawString("Kalkış yeri:", font, Brushes.Black, margin, yPos);
            yPos += lineHeight;
            g.DrawString(busRoute.DepartureLocation, font1, Brushes.Black, margin + 10, yPos);
            yPos += lineHeight;
            g.DrawString("Varış yeri:", font, Brushes.Black, margin, yPos);
            yPos += lineHeight;
            g.DrawString(busRoute.DestinationLocation, font1, Brushes.Black, margin + 10, yPos);
            yPos += lineHeight;
            g.DrawString("Yolcu TC:", font, Brushes.Black, margin, yPos);
            yPos += lineHeight;
            g.DrawString(user.GovID, font1, Brushes.Black, margin + 10, yPos);
            yPos += lineHeight;
            g.DrawString("Yolcu:", font, Brushes.Black, margin, yPos);
            yPos += lineHeight;
            g.DrawString(user.Name + " " + user.Surname, font1, Brushes.Black, margin + 10, yPos);
            yPos += lineHeight;
            g.DrawString("Plaka:", font, Brushes.Black, margin, yPos);
            yPos += lineHeight;
            g.DrawString(bus.LicensePlate, font1, Brushes.Black, margin + 10, yPos);
            yPos += lineHeight;
            g.DrawString("Koltuk No:", font, Brushes.Black, margin, yPos);
            yPos += lineHeight;
            g.DrawString(Convert.ToString(ticket.Seat), font1, Brushes.Black, margin + 10, yPos);
            yPos += lineHeight;
            g.DrawString("Fiyat:", font, Brushes.Black, margin, yPos);
            yPos += lineHeight;
            g.DrawString(Convert.ToString(busRoute.Price) + "₺", font1, Brushes.Black, margin + 10, yPos);
            yPos += lineHeight;
            g.DrawString("PNR:", font, Brushes.Black, margin, yPos);
            yPos += lineHeight;
            g.DrawString(ticket.Pnr, font1, Brushes.Black, margin + 10, yPos);

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(ticket.Pnr, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(5);
            g.DrawImage(qrCodeImage, 390 - qrCodeImage.Width, 530 - qrCodeImage.Height);
            e.HasMorePages = false;
        }

        private void CancelOrderButton_Click(object sender, EventArgs e)
        {
            Ticket TicketObject = _ITicket.GetTicketDetails(TicketID);
            Users UserObject = _IUsers.GetUserDetails(TicketObject.TicketUserID);
            BusRoutes RouteObject = _IBusRoutes.GetBusRoutesDetails(TicketObject.TicketRouteID);
            DialogResult dialogResult = MessageBox.Show(RouteObject.DestinationLocation + " giden biletinizi iptal etmek istiyor musunuz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    _IBusRoutes.RemoveSeat(TicketObject.Seat, TicketObject.TicketRouteID);
                    _ITicket.DeleteTicket(TicketID);
                    logger.printLog(2, UserObject.Username, "The ticket with the id : " + TicketObject.TicketID + " has been deleted. ");
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kayıtı silerken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.printLog(0, UserObject.Username, "Failed when deleting ticket with the id : " + TicketObject.TicketID + " / Error : " + ex.Message);
                }
            }
        }
    }
}
