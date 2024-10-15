using OBS.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OBS.Interface;
using OBS.Repository;
using OBS.Models;
using OBS.Database;

namespace OBS
{
    public partial class Register : Form
    {
        #region Private Defines

        private string gender = "Male";
        private static Color _darkMode_Color = Color.FromArgb(1, 42, 42, 42);
        private IUsers _IUsers = new UserRepository();
        private LogCode logger = LogCode.Instance;

        #endregion

        #region Singleton Implementation

        private static Register instance;

        private Register()
        {
            InitializeComponent();
            CustomWindow.setBorder(_darkMode_Color, Color.White, _darkMode_Color, Handle);
        }

        public static Register Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Register();
                }
                return instance;
            }
        }

        #endregion

        private bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }

        private bool IsNumeric(string value)
        {
            return value.All(char.IsNumber);
        }

        private void closePage()
        {
            Login loginPage = Login.Instance;

            UsernameTxtBox.Text = "";
            PasswordTxtBox.Text = "";
            NameTxtBox.Text = "";
            SurnameTxtBox.Text = "";
            GovIDTxtBox.Text = "";
            EmailTxtBox.Text = "";
            PhoneTxtBox.Text = "";
            MaleRadio.Checked = true;
            FemaleRadio.Checked = false;
            AgreementChkBox.Checked = false;

            loginPage.Show();
            this.Hide();
        }

        private void RegisterUser(Users user)
        {
            user.Uuid = Convert.ToString(Guid.NewGuid());
            user.AuthorityLevel = "User";
            if (_IUsers.CheckEmail(user.Email) || _IUsers.CheckUsername(user.Username) || _IUsers.CheckGovID(user.GovID) || _IUsers.CheckPhone(user.Phone))
            {
                MessageBox.Show("Kayıt olmaya çalıştığınız bilgilerle birisi zaten kayıtlıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    _IUsers.AddUser(user);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Bilinmeyen hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.printLog(0, "","Unknown error occured while registering user. Error :" + e.Message);
                    throw;
                }

                MessageBox.Show("Başarıyla kayıt oldunuz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                logger.printLog(2, user.Username, "Registered user / GUID : " + user.Uuid + " / GovID : " + user.GovID + " / Username : " + user.Username);
                // Handle Successful register here
                closePage();
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            closePage();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            closePage();
        }
        private void MaleRadio_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void FemaleRadio_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            var box = new[] { UsernameTxtBox.Text, PasswordTxtBox.Text, NameTxtBox.Text, SurnameTxtBox.Text, GovIDTxtBox.Text, EmailTxtBox.Text, PhoneTxtBox.Text };
            var i = 0;
            var err_message = "";
            foreach (var item in box)
            {
                if (item == "")
                {
                    switch (i)
                    {
                        case 0:
                            err_message += "Kullanıcı adı, ";
                            break;
                        case 1:
                            err_message += "Şifre, ";
                            break;
                        case 2:
                            err_message += "Ad, ";
                            break;
                        case 3:
                            err_message += "Soyad, ";
                            break;
                        case 4:
                            err_message += "TC Kimlik No, ";
                            break;
                        case 5:
                            err_message += "E-Posta, ";
                            break;
                        case 6:
                            err_message += "Telefon Numarası, ";
                            break;
                    }
                }
                i++;
            }

            if (err_message != "")
            {
                MessageBox.Show(err_message.Substring(0, err_message.Length - 2) + " boş bırakılamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (IsValidEmail(EmailTxtBox.Text))
                {
                    if (PhoneTxtBox.Text.Length == 14)
                    {
                        if (GovIDTxtBox.Text.Length == 11 && IsNumeric(GovIDTxtBox.Text))
                        {
                            if (AgreementChkBox.Checked)
                            {
                                Users user = new Users
                                {
                                    Uuid = "",
                                    GovID = GovIDTxtBox.Text,
                                    Username = UsernameTxtBox.Text,
                                    Password = SHA256Encode.ComputeSha256Hash(PasswordTxtBox.Text),
                                    Phone = PhoneTxtBox.Text,
                                    Email = EmailTxtBox.Text,
                                    AuthorityLevel = "",
                                    Name = NameTxtBox.Text,
                                    Surname = SurnameTxtBox.Text,
                                    Gender = gender
                                };

                                RegisterUser(user);
                            }
                            else
                            {
                                MessageBox.Show("Anlaşmayı kabul etmelisiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("TC Kimlik numaranız yanlış girilmiştir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Telefon numaranız yanlış girilmiştir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("E-postanız yanlış girilmistir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
