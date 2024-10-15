using OBS.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBS.UC
{
    public partial class RouteListItem : UserControl
    {
        private readonly RouteListItemDTO rDetail;

        public RouteListItem(RouteListItemDTO routeDetails)
        {
            InitializeComponent();
            rDetail = routeDetails;
        }

        private void RouteListItem_Load(object sender, EventArgs e)
        {
            var arrivalTime = rDetail.Date.AddHours(Convert.ToInt32(rDetail.ETA));
            RouteLabel.Text = rDetail.Departure + " -> " + rDetail.Arrival;
            EmptySeatsLabel.Text = rDetail.EmptySeats;
            DateLabel.Text = rDetail.Date.ToShortDateString();
            PriceLabel.Text = rDetail.Price + "₺";
            ETALabel.Text = rDetail.Date.ToShortTimeString() + " - " + arrivalTime.ToShortTimeString();
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            UserMain userMain = UserMain.Instance;
            Main main = Main.Instance;

            TicketBuy ticketBuy = TicketBuy.Instance;
            ticketBuy.routeID = rDetail.RouteID;
            if (userMain.loggedInUser == null) { ticketBuy.userID = main.loggedInUser.Uuid; } else { ticketBuy.userID = userMain.loggedInUser.Uuid; }
            ticketBuy.ShowDialog();
        }
    }
}
