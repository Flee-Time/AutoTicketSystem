namespace OBS
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LoginBtn = new Button();
            ExitBtn = new Button();
            UsernameBox = new TextBox();
            PasswordBox = new TextBox();
            RegisterLabel = new LinkLabel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.FromArgb(62, 62, 62);
            LoginBtn.FlatAppearance.BorderSize = 0;
            LoginBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 120, 120);
            LoginBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 90, 90);
            LoginBtn.FlatStyle = FlatStyle.Flat;
            LoginBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LoginBtn.ForeColor = Color.Transparent;
            LoginBtn.Location = new Point(178, 212);
            LoginBtn.Margin = new Padding(4, 4, 4, 4);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(94, 29);
            LoginBtn.TabIndex = 4;
            LoginBtn.Text = "Giriş Yap";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.BackColor = Color.FromArgb(62, 62, 62);
            ExitBtn.FlatAppearance.BorderSize = 0;
            ExitBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 120, 120);
            ExitBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 90, 90);
            ExitBtn.FlatStyle = FlatStyle.Flat;
            ExitBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ExitBtn.ForeColor = Color.Transparent;
            ExitBtn.Location = new Point(45, 212);
            ExitBtn.Margin = new Padding(4, 4, 4, 4);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(94, 29);
            ExitBtn.TabIndex = 5;
            ExitBtn.Text = "İptal";
            ExitBtn.UseVisualStyleBackColor = false;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // UsernameBox
            // 
            UsernameBox.Location = new Point(121, 82);
            UsernameBox.Margin = new Padding(4, 4, 4, 4);
            UsernameBox.MaxLength = 40;
            UsernameBox.Name = "UsernameBox";
            UsernameBox.Size = new Size(153, 27);
            UsernameBox.TabIndex = 1;
            UsernameBox.KeyDown += UsernameBox_KeyDown;
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(121, 130);
            PasswordBox.Margin = new Padding(4, 4, 4, 4);
            PasswordBox.MaxLength = 40;
            PasswordBox.Name = "PasswordBox";
            PasswordBox.PasswordChar = '*';
            PasswordBox.Size = new Size(153, 27);
            PasswordBox.TabIndex = 2;
            PasswordBox.UseSystemPasswordChar = true;
            PasswordBox.KeyDown += PasswordBox_KeyDown;
            // 
            // RegisterLabel
            // 
            RegisterLabel.AutoSize = true;
            RegisterLabel.LinkColor = Color.FromArgb(0, 192, 192);
            RegisterLabel.Location = new Point(45, 170);
            RegisterLabel.Margin = new Padding(4, 0, 4, 0);
            RegisterLabel.Name = "RegisterLabel";
            RegisterLabel.Size = new Size(61, 20);
            RegisterLabel.TabIndex = 3;
            RegisterLabel.TabStop = true;
            RegisterLabel.Text = "Kayıt Ol";
            RegisterLabel.LinkClicked += RegisterLabel_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(38, 26);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(240, 25);
            label1.TabIndex = 5;
            label1.Text = "Otobüs Bilet Otomasyonu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(15, 86);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 6;
            label2.Text = "Kullanıcı Adı :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(69, 134);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 7;
            label3.Text = "Şifre :";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(42, 42, 42);
            ClientSize = new Size(318, 276);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(RegisterLabel);
            Controls.Add(PasswordBox);
            Controls.Add(UsernameBox);
            Controls.Add(ExitBtn);
            Controls.Add(LoginBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 2, 4, 2);
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OBS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LoginBtn;
        private Button ExitBtn;
        private TextBox UsernameBox;
        private TextBox PasswordBox;
        private LinkLabel RegisterLabel;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}