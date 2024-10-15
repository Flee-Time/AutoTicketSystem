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
    public partial class UserAdd : Form
    {
        #region Private Defines

        private static Color _darkMode_Color = Color.FromArgb(1, 42, 42, 42);
        private IUsers _IUsers = new UserRepository();
        private Users newUsersObject = new Users();
        private string _selectedGender = "Male";
        private LogCode logger = LogCode.Instance;

        #endregion

        #region Singleton implementation

        private static UserAdd instance;
        private UserAdd()
        {
            InitializeComponent();
            CustomWindow.setBorder(_darkMode_Color, Color.White, _darkMode_Color, Handle);
        }

        public static UserAdd Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserAdd();
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
            PasswordTxtBox.Text = string.Empty;
            UsernameTxtBox.Text = string.Empty;
            EmailTxtBox.Text = string.Empty;
            NameTxtBox.Text = string.Empty;
            SurnameTxtBox.Text = string.Empty;
            PhoneTxtBox.Text = string.Empty;
            GovIDTxtBox.Text = string.Empty;
            AuthorityLevelCB.Text = "User";
            MaleRadio.Checked = true;
            FemaleRadio.Checked = false;
            _selectedGender = "Male";
            this.Hide();
        }

        private void UserAdd_Shown(object sender, EventArgs e)
        {
            CustomWindow.setBorder(_darkMode_Color, Color.White, _darkMode_Color, Handle);

            if (editMode)
            {
                Users lastUsersObject = _IUsers.GetUserDetails(editGUID);

                IDLabel.Text = "ID : " + editGUID;
                PasswordTxtBox.Text = string.Empty;
                UsernameTxtBox.Text = lastUsersObject.Username;
                EmailTxtBox.Text = lastUsersObject.Email;
                NameTxtBox.Text = lastUsersObject.Name;
                SurnameTxtBox.Text = lastUsersObject.Surname;
                PhoneTxtBox.Text = lastUsersObject.Phone;
                GovIDTxtBox.Text = lastUsersObject.GovID;
                AuthorityLevelCB.Text = lastUsersObject.AuthorityLevel;

                if (lastUsersObject.Gender == "Male")
                {
                    MaleRadio.Checked = true;
                    FemaleRadio.Checked = false;
                }
                else
                {
                    MaleRadio.Checked = false;
                    FemaleRadio.Checked = true;
                }
            }
            else
            {
                newUsersObject.Uuid = Convert.ToString(Guid.NewGuid());
                IDLabel.Text = "ID : " + newUsersObject.Uuid;
            }
        }

        private void MaleRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (MaleRadio.Checked == true) { _selectedGender = "Male"; }
        }

        private void FemaleRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (FemaleRadio.Checked == true) { _selectedGender = "Female"; }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (UsernameTxtBox.Text != string.Empty && NameTxtBox.Text != string.Empty && SurnameTxtBox.Text != EmailTxtBox.Text && PhoneTxtBox.Text != string.Empty && GovIDTxtBox.Text != string.Empty && PasswordTxtBox.Text != string.Empty)
            {
                if (!editMode)
                {
                    newUsersObject.Username = UsernameTxtBox.Text;
                    newUsersObject.Name = NameTxtBox.Text;
                    newUsersObject.Surname = SurnameTxtBox.Text;
                    newUsersObject.Email = EmailTxtBox.Text;
                    newUsersObject.Phone = PhoneTxtBox.Text;
                    newUsersObject.GovID = GovIDTxtBox.Text;
                    newUsersObject.Password = SHA256Encode.ComputeSha256Hash(PasswordTxtBox.Text);
                    newUsersObject.Gender = _selectedGender;
                    newUsersObject.AuthorityLevel = AuthorityLevelCB.Text;

                    try
                    {
                        _IUsers.AddUser(newUsersObject);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Kullanıcı kayıtını oluşturulurken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        logger.printLog(0, Main.Instance.loggedInUser.Username, "Failed when creating user entry / Error : " + ex.Message);
                    }
                    MessageBox.Show("Başarıyla yeni kayıt oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    logger.printLog(2, Main.Instance.loggedInUser.Username, "Created user with the id : " + newUsersObject.Uuid);
                    resetAndClose();
                }
                else
                {
                    Users editUsersObject = new Users();
                    editUsersObject.Uuid = editGUID;

                    editUsersObject.Username = UsernameTxtBox.Text;
                    editUsersObject.Name = NameTxtBox.Text;
                    editUsersObject.Surname = SurnameTxtBox.Text;
                    editUsersObject.Email = EmailTxtBox.Text;
                    editUsersObject.Phone = PhoneTxtBox.Text;
                    editUsersObject.GovID = GovIDTxtBox.Text;
                    editUsersObject.Password = SHA256Encode.ComputeSha256Hash(PasswordTxtBox.Text);
                    editUsersObject.Gender = _selectedGender;
                    editUsersObject.AuthorityLevel = AuthorityLevelCB.Text;

                    try
                    {
                        _IUsers.UpdateUser(editUsersObject);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Kullanıcı kayıtını güncellerken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        logger.printLog(0, Main.Instance.loggedInUser.Username, "Failed when editing user entry / Error : " + ex.Message);
                    }
                    MessageBox.Show("Başarıyla kayıt düzenlendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    logger.printLog(2, Main.Instance.loggedInUser.Username, "Edited user with the id : " + editUsersObject.Uuid);
                    resetAndClose();
                }
            }
            else
            {
                MessageBox.Show("Lütfen bütün kutuları doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            resetAndClose();
        }
    }
}
