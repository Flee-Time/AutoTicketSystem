namespace OBS
{
    partial class UserAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            IDLabel = new Label();
            label1 = new Label();
            CancelButton = new Button();
            SaveButton = new Button();
            PhoneTxtBox = new MaskedTextBox();
            GenderGBox = new GroupBox();
            FemaleRadio = new RadioButton();
            MaleRadio = new RadioButton();
            label7 = new Label();
            PasswordTxtBox = new TextBox();
            label5 = new Label();
            label6 = new Label();
            GovIDTxtBox = new TextBox();
            UsernameTxtBox = new TextBox();
            label2 = new Label();
            label4 = new Label();
            SurnameTxtBox = new TextBox();
            label3 = new Label();
            label8 = new Label();
            NameTxtBox = new TextBox();
            EmailTxtBox = new TextBox();
            label9 = new Label();
            AuthorityLevelCB = new ComboBox();
            GenderGBox.SuspendLayout();
            SuspendLayout();
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.ForeColor = Color.White;
            IDLabel.Location = new Point(138, 36);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(237, 15);
            IDLabel.TabIndex = 20;
            IDLabel.Text = "ID : 5d9f4232-49b4-45de-af5c-3af2721864d6";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(177, 7);
            label1.Name = "label1";
            label1.Size = new Size(163, 20);
            label1.TabIndex = 13;
            label1.Text = "Kullanıcı Ekle/Düzenle";
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.FromArgb(62, 62, 62);
            CancelButton.FlatAppearance.BorderSize = 0;
            CancelButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 120, 120);
            CancelButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 90, 90);
            CancelButton.FlatStyle = FlatStyle.Flat;
            CancelButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CancelButton.ForeColor = Color.Transparent;
            CancelButton.Location = new Point(10, 235);
            CancelButton.Margin = new Padding(3, 2, 3, 2);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(82, 22);
            CancelButton.TabIndex = 11;
            CancelButton.Text = "İptal";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.FromArgb(62, 62, 62);
            SaveButton.FlatAppearance.BorderSize = 0;
            SaveButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 120, 120);
            SaveButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 90, 90);
            SaveButton.FlatStyle = FlatStyle.Flat;
            SaveButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SaveButton.ForeColor = Color.Transparent;
            SaveButton.Location = new Point(445, 235);
            SaveButton.Margin = new Padding(3, 2, 3, 2);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(82, 22);
            SaveButton.TabIndex = 10;
            SaveButton.Text = "Kaydet";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // PhoneTxtBox
            // 
            PhoneTxtBox.Location = new Point(359, 131);
            PhoneTxtBox.Margin = new Padding(4, 3, 4, 3);
            PhoneTxtBox.Mask = "(999) 000-0000";
            PhoneTxtBox.Name = "PhoneTxtBox";
            PhoneTxtBox.Size = new Size(134, 23);
            PhoneTxtBox.TabIndex = 8;
            // 
            // GenderGBox
            // 
            GenderGBox.Controls.Add(FemaleRadio);
            GenderGBox.Controls.Add(MaleRadio);
            GenderGBox.ForeColor = Color.White;
            GenderGBox.Location = new Point(274, 159);
            GenderGBox.Margin = new Padding(4, 3, 4, 3);
            GenderGBox.Name = "GenderGBox";
            GenderGBox.Padding = new Padding(4, 3, 4, 3);
            GenderGBox.Size = new Size(219, 57);
            GenderGBox.TabIndex = 9;
            GenderGBox.TabStop = false;
            GenderGBox.Text = "Cinsiyet";
            // 
            // FemaleRadio
            // 
            FemaleRadio.AutoSize = true;
            FemaleRadio.Location = new Point(142, 22);
            FemaleRadio.Margin = new Padding(4, 3, 4, 3);
            FemaleRadio.Name = "FemaleRadio";
            FemaleRadio.Size = new Size(55, 19);
            FemaleRadio.TabIndex = 2;
            FemaleRadio.TabStop = true;
            FemaleRadio.Text = "Kadın";
            FemaleRadio.UseVisualStyleBackColor = true;
            FemaleRadio.CheckedChanged += FemaleRadio_CheckedChanged;
            // 
            // MaleRadio
            // 
            MaleRadio.AutoSize = true;
            MaleRadio.Checked = true;
            MaleRadio.Location = new Point(20, 22);
            MaleRadio.Margin = new Padding(4, 3, 4, 3);
            MaleRadio.Name = "MaleRadio";
            MaleRadio.Size = new Size(53, 19);
            MaleRadio.TabIndex = 1;
            MaleRadio.TabStop = true;
            MaleRadio.Text = "Erkek";
            MaleRadio.UseVisualStyleBackColor = true;
            MaleRadio.CheckedChanged += MaleRadio_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(65, 102);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 38;
            label7.Text = "Şifre :";
            // 
            // PasswordTxtBox
            // 
            PasswordTxtBox.Location = new Point(111, 98);
            PasswordTxtBox.Margin = new Padding(4, 3, 4, 3);
            PasswordTxtBox.MaxLength = 40;
            PasswordTxtBox.Name = "PasswordTxtBox";
            PasswordTxtBox.PasswordChar = '*';
            PasswordTxtBox.Size = new Size(134, 23);
            PasswordTxtBox.TabIndex = 2;
            PasswordTxtBox.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(263, 69);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 37;
            label5.Text = "TC Kimlik No :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(22, 69);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(79, 15);
            label6.TabIndex = 36;
            label6.Text = "Kullanıcı Adı :";
            // 
            // GovIDTxtBox
            // 
            GovIDTxtBox.Location = new Point(359, 66);
            GovIDTxtBox.Margin = new Padding(4, 3, 4, 3);
            GovIDTxtBox.MaxLength = 11;
            GovIDTxtBox.Name = "GovIDTxtBox";
            GovIDTxtBox.Size = new Size(134, 23);
            GovIDTxtBox.TabIndex = 6;
            // 
            // UsernameTxtBox
            // 
            UsernameTxtBox.Location = new Point(111, 66);
            UsernameTxtBox.Margin = new Padding(4, 3, 4, 3);
            UsernameTxtBox.MaxLength = 40;
            UsernameTxtBox.Name = "UsernameTxtBox";
            UsernameTxtBox.Size = new Size(134, 23);
            UsernameTxtBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(275, 133);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 35;
            label2.Text = "Telefon No :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(55, 165);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 34;
            label4.Text = "Soyad :";
            // 
            // SurnameTxtBox
            // 
            SurnameTxtBox.Location = new Point(111, 163);
            SurnameTxtBox.Margin = new Padding(4, 3, 4, 3);
            SurnameTxtBox.MaxLength = 40;
            SurnameTxtBox.Name = "SurnameTxtBox";
            SurnameTxtBox.Size = new Size(134, 23);
            SurnameTxtBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(74, 133);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 33;
            label3.Text = "Ad :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(294, 102);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(53, 15);
            label8.TabIndex = 32;
            label8.Text = "E-Posta :";
            // 
            // NameTxtBox
            // 
            NameTxtBox.Location = new Point(111, 131);
            NameTxtBox.Margin = new Padding(4, 3, 4, 3);
            NameTxtBox.MaxLength = 40;
            NameTxtBox.Name = "NameTxtBox";
            NameTxtBox.Size = new Size(134, 23);
            NameTxtBox.TabIndex = 3;
            // 
            // EmailTxtBox
            // 
            EmailTxtBox.Location = new Point(359, 98);
            EmailTxtBox.Margin = new Padding(4, 3, 4, 3);
            EmailTxtBox.MaxLength = 60;
            EmailTxtBox.Name = "EmailTxtBox";
            EmailTxtBox.Size = new Size(134, 23);
            EmailTxtBox.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(18, 196);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(82, 15);
            label9.TabIndex = 39;
            label9.Text = "Yetki Seviyesi :";
            // 
            // AuthorityLevelCB
            // 
            AuthorityLevelCB.FormattingEnabled = true;
            AuthorityLevelCB.Items.AddRange(new object[] { "User", "Admin" });
            AuthorityLevelCB.Location = new Point(111, 193);
            AuthorityLevelCB.Name = "AuthorityLevelCB";
            AuthorityLevelCB.Size = new Size(134, 23);
            AuthorityLevelCB.TabIndex = 5;
            AuthorityLevelCB.Text = "User";
            // 
            // UserAdd
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(42, 42, 42);
            ClientSize = new Size(538, 266);
            Controls.Add(AuthorityLevelCB);
            Controls.Add(label9);
            Controls.Add(PhoneTxtBox);
            Controls.Add(GenderGBox);
            Controls.Add(label7);
            Controls.Add(PasswordTxtBox);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(GovIDTxtBox);
            Controls.Add(UsernameTxtBox);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(SurnameTxtBox);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(NameTxtBox);
            Controls.Add(EmailTxtBox);
            Controls.Add(IDLabel);
            Controls.Add(label1);
            Controls.Add(CancelButton);
            Controls.Add(SaveButton);
            Name = "UserAdd";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Kullanıcı Ekle/Düzenle";
            Shown += UserAdd_Shown;
            GenderGBox.ResumeLayout(false);
            GenderGBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IDLabel;
        private Label label1;
        private Button CancelButton;
        private Button SaveButton;
        private MaskedTextBox PhoneTxtBox;
        private GroupBox GenderGBox;
        private RadioButton FemaleRadio;
        private RadioButton MaleRadio;
        private Label label7;
        private TextBox PasswordTxtBox;
        private Label label5;
        private Label label6;
        private TextBox GovIDTxtBox;
        private TextBox UsernameTxtBox;
        private Label label2;
        private Label label4;
        private TextBox SurnameTxtBox;
        private Label label3;
        private Label label8;
        private TextBox NameTxtBox;
        private TextBox EmailTxtBox;
        private Label label9;
        private ComboBox AuthorityLevelCB;
    }
}