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
    public partial class TicketListItem : UserControl
    {
        private readonly TicketListItemDTO tDetail;

        public TicketListItem(TicketListItemDTO ticketDetails)
        {
            InitializeComponent();
            tDetail = ticketDetails;
        }

        private void TicketListItem_Load(object sender, EventArgs e)
        {
            RouteLabel.Text = tDetail.Departure + " -> " + tDetail.Arrival;
            DateLabel.Text = tDetail.Date.ToShortDateString();
            PNRLabel.Text = tDetail.Pnr;
            SeatLabel.Text = tDetail.Seat;
            DepartureTimeLabel.Text = tDetail.Date.ToShortTimeString();
        }

        private void DetailsButton_Click(object sender, EventArgs e)
        {
            TicketDetails ticketDetails = TicketDetails.Instance;
            ticketDetails.TicketID = tDetail.TicketID;
            ticketDetails.ShowDialog();
        }
    }
}
