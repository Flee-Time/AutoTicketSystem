using DocumentFormat.OpenXml.Bibliography;
using OBS.DTO;
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
    public partial class UserMain : Form
    {
        #region Public Defines

        public Users loggedInUser;

        #endregion

        #region Private Defines

        private static Color _darkMode_Color = Color.FromArgb(1, 42, 42, 42);
        private IBusRoutes _IBusRoutes = new BusRoutesRepository();
        private IBus _IBus = new BusRepository();
        private ICities _ICities = new CitiesRepository();
        private LogCode logger = LogCode.Instance;

        #endregion

        #region Singleton implementation

        private static UserMain instance;
        private UserMain()
        {
            InitializeComponent();
            CustomWindow.setBorder(_darkMode_Color, Color.White, _darkMode_Color, Handle);
        }

        public static UserMain Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserMain();
                }
                return instance;
            }
        }

        #endregion

        public void RefreshWindow()
        {
            List<BusRoutes> busRoutes = _IBusRoutes.GetBusRoutesDetails();
            List<BusRoutes> filteredRoutes = new List<BusRoutes>(busRoutes);

            foreach (BusRoutes busRoute in busRoutes)
            {
                if (DepartureCB.Text != string.Empty && busRoute.DepartureLocation != DepartureCB.Text)
                {
                    filteredRoutes.Remove(busRoute);
                }
                if (DestinationCB.Text != string.Empty && busRoute.DestinationLocation != DestinationCB.Text)
                {
                    filteredRoutes.Remove(busRoute);
                }
            }

            var RList = RouteList.drawList(filteredRoutes, _IBus, 100, 130);

            RouteList.RemoveDynamicallyAddedControls("routeListItem", this);

            if (!(RList.Count == 0))
            {
                foreach (var routeListItem in RList)
                {
                    this.Controls.Add(routeListItem);
                }
            }
        }

        private void UserMain_Load(object sender, EventArgs e)
        {
            DepartureCB.Items.Add("");
            DestinationCB.Items.Add("");

            foreach (Cities city in _ICities.GetCitiesDetails())
            {
                DepartureCB.Items.Add(city.CityName);
                DestinationCB.Items.Add(city.CityName);
            }

            RefreshWindow();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            loggedInUser = null;
            Login loginPage = Login.Instance;
            loginPage.Show();
            this.Hide();
        }

        private void UserMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void DepartureCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshWindow();
        }

        private void DestinationCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshWindow();
        }

        private void ResetFilterButton_Click(object sender, EventArgs e)
        {
            DepartureCB.Text = string.Empty;
            DestinationCB.Text = string.Empty;
        }

        private void ShowUserTicketsButton_Click(object sender, EventArgs e)
        {
            UserTickets userTickets = UserTickets.Instance;
            userTickets.UserID = loggedInUser.Uuid;
            userTickets.ShowDialog();
        }
    }
}
