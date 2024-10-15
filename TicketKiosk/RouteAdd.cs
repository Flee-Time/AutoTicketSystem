using OBS.Extensions;
using OBS.Interface;
using OBS.Models;
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

namespace OBS
{
    public partial class RouteAdd : Form
    {
        #region Private Defines

        private static Color _darkMode_Color = Color.FromArgb(1, 42, 42, 42);
        private IBusRoutes _IBusRoutes = new BusRoutesRepository();
        private IBus _IBus = new BusRepository();
        private ICities _ICities = new CitiesRepository();
        private BusRoutes newRouteObject = new BusRoutes();
        private LogCode logger = LogCode.Instance;

        #endregion

        #region Singleton implementation

        private static RouteAdd instance;
        private RouteAdd()
        {
            InitializeComponent();
            CustomWindow.setBorder(_darkMode_Color, Color.White, _darkMode_Color, Handle);
        }

        public static RouteAdd Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RouteAdd();
                }
                return instance;
            }
        }

        #endregion

        public bool editMode = false;
        public string editGUID = "";

        private void resetAndClose()
        {
            editGUID = "";
            editMode = false;
            DepartueLocationCB.Text = "Adana";
            DestinationLocationCB.Text = "Adana";
            BusSelectCB.Text = "";
            DateTimePicker.Value = DateTime.Now;
            EtaNUP.Value = 1;
            PriceNUP.Value = 400.00M;
            this.Hide();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (BusSelectCB.Text != "" && DepartueLocationCB.Text != "" && DestinationLocationCB.Text != "")
            {
                if (!editMode)
                {
                    newRouteObject.UsedBusID = _IBus.GetIDFromPlate(BusSelectCB.Text);
                    newRouteObject.DepartureLocation = DepartueLocationCB.Text;
                    newRouteObject.DestinationLocation = DestinationLocationCB.Text;
                    newRouteObject.Date = DateTimePicker.Value;
                    newRouteObject.Price = Convert.ToDouble(PriceNUP.Value);
                    newRouteObject.ETA = Convert.ToString(Math.Round(EtaNUP.Value));
                    newRouteObject.ReservedSeats = "";

                    try
                    {
                        _IBusRoutes.AddBusRoutes(newRouteObject);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Rota kayıtını oluşturulurken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        logger.printLog(0, Main.Instance.loggedInUser.Username, "Failed when creating route entry / Error : " + ex.Message); ;
                    }
                    MessageBox.Show("Başarıyla yeni kayıt oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    logger.printLog(2, Main.Instance.loggedInUser.Username, "Created route with the id : " + newRouteObject.RouteID);
                    resetAndClose();
                }
                else
                {
                    BusRoutes editRouteObject = new BusRoutes();
                    BusRoutes lastRouteObject = _IBusRoutes.GetBusRoutesDetails(editGUID);
                    editRouteObject.RouteID = editGUID;
                    editRouteObject.ReservedSeats = lastRouteObject.ReservedSeats;

                    editRouteObject.UsedBusID = _IBus.GetIDFromPlate(BusSelectCB.Text);
                    editRouteObject.DepartureLocation = DepartueLocationCB.Text;
                    editRouteObject.DestinationLocation = DestinationLocationCB.Text;
                    editRouteObject.Date = DateTimePicker.Value;
                    editRouteObject.Price = Convert.ToDouble(PriceNUP.Value);
                    editRouteObject.ETA = Convert.ToString(EtaNUP.Value);

                    try
                    {
                        _IBusRoutes.UpdateBusRoutes(editRouteObject);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Otobüs kayıtını güncellerken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        logger.printLog(0, Main.Instance.loggedInUser.Username, "Failed when editing route entry / Error : " + ex.Message);
                    }
                    MessageBox.Show("Başarıyla kayıt düzenlendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    logger.printLog(2, Main.Instance.loggedInUser.Username, "Edited route with the id : " + editRouteObject.RouteID);
                    resetAndClose();
                }
            }
            else
            {
                MessageBox.Show("Lütfen bütün kutuları doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RouteAdd_Shown(object sender, EventArgs e)
        {
            CustomWindow.setBorder(_darkMode_Color, Color.White, _darkMode_Color, Handle);

            BusSelectCB.Items.Clear();
            DepartueLocationCB.Items.Clear();
            DestinationLocationCB.Items.Clear();

            foreach (Bus bus in _IBus.GetBusDetails())
            {
                BusSelectCB.Items.Add(bus.LicensePlate);
            }

            foreach (Cities city in _ICities.GetCitiesDetails())
            {
                DepartueLocationCB.Items.Add(city.CityName);
                DestinationLocationCB.Items.Add(city.CityName);
            }

            if (editMode)
            {
                BusRoutes lastRouteObject = _IBusRoutes.GetBusRoutesDetails(editGUID);

                IDLabel.Text = "ID : " + editGUID;
                BusSelectCB.Text = _IBus.GetBusDetails(lastRouteObject.UsedBusID).LicensePlate;
                DepartueLocationCB.Text = lastRouteObject.DepartureLocation;
                DestinationLocationCB.Text = lastRouteObject.DestinationLocation;
                DateTimePicker.Value = lastRouteObject.Date;
                PriceNUP.Value = Convert.ToDecimal(lastRouteObject.Price);
                EtaNUP.Value = Convert.ToInt16(lastRouteObject.ETA);
            }
            else
            {
                newRouteObject.RouteID = Convert.ToString(Guid.NewGuid());
                IDLabel.Text = "ID : " + newRouteObject.RouteID;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            resetAndClose();
        }
    }
}
