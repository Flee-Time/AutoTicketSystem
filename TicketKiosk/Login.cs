using Microsoft.Data.Sqlite;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Win32;
using OBS.Database;
using OBS.Extensions;
using OBS.Interface;
using OBS.Repository;

namespace OBS
{
    public partial class Login : Form
    {

        #region Private Defines

        private static Color _darkMode_Color = Color.FromArgb(1, 42, 42, 42);
        private IUsers _IUsers = new UserRepository();
        private LogCode logger = LogCode.Instance;

        #endregion

        #region Singleton implementation

        private static Login instance;
        private Login()
        {
            InitializeComponent();
            CustomWindow.setBorder(_darkMode_Color, Color.White, _darkMode_Color, Handle);
        }

        public static Login Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Login();
                }
                return instance;
            }
        }

        #endregion

        private bool loginUser(string password, string username)
        {
            if (password != "" && username != "")
            {
                string encoded_pass = SHA256Encode.ComputeSha256Hash(password);
                var user = _IUsers.GetUser(username, encoded_pass);
                if (user != null)
                {
                    //Handle successfull login here
                    logger.printLog(2, user.Username, "User logged in / GUID : " + user.Uuid + " / Username : " + user.Username + " / Authority Level : " + user.AuthorityLevel);
                    MessageBox.Show("Başarıyla giriş yapıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    if (user.AuthorityLevel == "Admin")
                    {
                        Main mainPage = Main.Instance;
                        mainPage.loggedInUser = user;
                        mainPage.RefreshWindow();
                        mainPage.Show();
                        this.Hide();
                        return true;
                    }
                    else
                    {
                        UserMain userMainPage = UserMain.Instance;
                        userMainPage.loggedInUser = user;
                        userMainPage.RefreshWindow();
                        userMainPage.Show();
                        this.Hide();
                        return true;
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya Parola yanlış.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Parola veya Kullanıcı adı boş bırakılamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            var state = loginUser(PasswordBox.Text, UsernameBox.Text);

            if (state)
            {
                PasswordBox.Text = string.Empty;
                UsernameBox.Text = string.Empty;
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegisterLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register registerPage = Register.Instance;
            registerPage.Show();
            this.Hide();
        }

        private void PasswordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var state = loginUser(PasswordBox.Text, UsernameBox.Text);

                if (state)
                {
                    PasswordBox.Text = string.Empty;
                    UsernameBox.Text = string.Empty;
                }
            }
        }

        private void UsernameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var state = loginUser(PasswordBox.Text, UsernameBox.Text);

                if (state)
                {
                    PasswordBox.Text = string.Empty;
                    UsernameBox.Text = string.Empty;
                }
            }
        }
    }
}