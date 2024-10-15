using Microsoft.Extensions.Logging;
using OBS.Database;
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
    public partial class BusAdd : Form
    {
        #region Private Defines

        private static Color _darkMode_Color = Color.FromArgb(1, 42, 42, 42);
        private IBus _IBus = new BusRepository();
        private Bus newBusObject = new Bus();
        private LogCode logger = LogCode.Instance;

        #endregion

        #region Singleton implementation

        private static BusAdd instance;
        private BusAdd()
        {
            InitializeComponent();
            CustomWindow.setBorder(_darkMode_Color, Color.White, _darkMode_Color, Handle);
        }

        public static BusAdd Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BusAdd();
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
            PlateTextBox.Text = "";
            SeatingOrderCB.Text = "2+2";
            MaxPassengerNUD.Value = 5;
            this.Hide();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (PlateTextBox.Text != "" && SeatingOrderCB.Text != "")
            {
                if (!editMode)
                {
                    newBusObject.LicensePlate = PlateTextBox.Text;
                    newBusObject.SeatingOrder = SeatingOrderCB.Text;
                    newBusObject.MaxPassengers = Convert.ToString(MaxPassengerNUD.Value);

                    try
                    {
                        _IBus.AddBus(newBusObject);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Otobüs kayıtını oluşturulurken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        logger.printLog(0, Main.Instance.loggedInUser.Username, "Failed when creating bus entry / Error : " + ex.Message);
                    }
                    MessageBox.Show("Başarıyla yeni kayıt oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    logger.printLog(2, Main.Instance.loggedInUser.Username, "Created bus with the id : " + newBusObject.BusID);
                    resetAndClose();
                }
                else
                {
                    Bus editBusObject = new Bus();
                    editBusObject.BusID = editGUID;

                    editBusObject.LicensePlate = PlateTextBox.Text;
                    editBusObject.SeatingOrder = SeatingOrderCB.Text;
                    editBusObject.MaxPassengers = Convert.ToString(MaxPassengerNUD.Value);

                    try
                    {
                        _IBus.UpdateBus(editBusObject);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Otobüs kayıtını güncellerken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        logger.printLog(0, Main.Instance.loggedInUser.Username, "Failed when editing bus entry / Error : " + ex.Message);
                    }
                    MessageBox.Show("Başarıyla kayıt düzenlendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    logger.printLog(2, Main.Instance.loggedInUser.Username, "Edited bus with the id : " + editBusObject.BusID);
                    resetAndClose();
                }
            }
            else
            {
                MessageBox.Show("Lütfen Plaka'yı boş bırakmayınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BusAdd_Shown(object sender, EventArgs e)
        {
            CustomWindow.setBorder(_darkMode_Color, Color.White, _darkMode_Color, Handle);

            if (editMode)
            {
                Bus lastBusObject = _IBus.GetBusDetails(editGUID);

                IDLabel.Text = "ID : " + editGUID;
                PlateTextBox.Text = lastBusObject.LicensePlate;
                SeatingOrderCB.Text = lastBusObject.SeatingOrder;
                MaxPassengerNUD.Value = Convert.ToInt32(lastBusObject.MaxPassengers);
            }
            else
            {
                newBusObject.BusID = Convert.ToString(Guid.NewGuid());
                IDLabel.Text = "ID : " + newBusObject.BusID;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            resetAndClose();
        }
    }
}
