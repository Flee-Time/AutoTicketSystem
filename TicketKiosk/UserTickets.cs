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
using OBS.Models;

namespace OBS
{
    public partial class UserTickets : Form
    {
        #region Public Defines

        public string UserID;

        #endregion

        #region Private Defines

        private static Color _darkMode_Color = Color.FromArgb(1, 42, 42, 42);
        private ITicket _ITicket = new TicketRepository();
        private IBusRoutes _IBusRoutes = new BusRoutesRepository();

        #endregion

        #region Singleton implementation

        private static UserTickets instance;
        private UserTickets()
        {
            InitializeComponent();
            CustomWindow.setBorder(_darkMode_Color, Color.White, _darkMode_Color, Handle);
        }

        public static UserTickets Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserTickets();
                }
                return instance;
            }
        }

        #endregion

        private void Refresh()
        {
            List<Ticket> tickets = _ITicket.GetTicketsFromUserID(UserID);
            List<Ticket> ModifiedTickets = new List<Ticket>(tickets);

            if (!(tickets.Count == 0))
            {
                foreach (var ticket in tickets)
                {
                    if (_IBusRoutes.GetBusRoutesDetails(ticket.TicketRouteID).Date < DateTime.Now)
                    {
                        ModifiedTickets.Remove(ticket);
                    }
                }
            }

            var TList = TicketList.drawList(ModifiedTickets, _IBusRoutes, 25, 50);

            RouteList.RemoveDynamicallyAddedControls("ticketListItem", this);

            if (!(TList.Count == 0))
            {
                foreach (var ticketListItem in TList)
                {
                    this.Controls.Add(ticketListItem);
                }
            }
        }

        private void UserTickets_Shown(object sender, EventArgs e)
        {
            CustomWindow.setBorder(_darkMode_Color, Color.White, _darkMode_Color, Handle);
            
            refreshTimer.Enabled = true;

            Refresh();
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
