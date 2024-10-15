namespace OBS
{
    partial class TicketAdd
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
            UserGroupBox = new GroupBox();
            GenderLabel = new Label();
            EmailLabel = new Label();
            PhoneLabel = new Label();
            SurnameLabel = new Label();
            NameLabel = new Label();
            GovIDLabel = new Label();
            RouteGroupBox = new GroupBox();
            PlateLabel = new Label();
            PriceLabel = new Label();
            EtaLabel = new Label();
            RouteDate = new Label();
            DestinationLabel = new Label();
            DepartureLabel = new Label();
            UserSelectCB = new ComboBox();
            label2 = new Label();
            RouteSelectCB = new ComboBox();
            label3 = new Label();
            SeatGB = new GroupBox();
            helpProvider1 = new HelpProvider();
            UserGroupBox.SuspendLayout();
            RouteGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.ForeColor = Color.White;
            IDLabel.Location = new Point(21, 36);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(237, 15);
            IDLabel.TabIndex = 18;
            IDLabel.Text = "ID : 5d9f4232-49b4-45de-af5c-3af2721864d6";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(136, 20);
            label1.TabIndex = 17;
            label1.Text = "Bilet Ekle/Düzenle";
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
            CancelButton.Location = new Point(12, 436);
            CancelButton.Margin = new Padding(3, 2, 3, 2);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(82, 22);
            CancelButton.TabIndex = 5;
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
            SaveButton.Location = new Point(450, 436);
            SaveButton.Margin = new Padding(3, 2, 3, 2);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(82, 22);
            SaveButton.TabIndex = 4;
            SaveButton.Text = "Kaydet";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // UserGroupBox
            // 
            UserGroupBox.Controls.Add(GenderLabel);
            UserGroupBox.Controls.Add(EmailLabel);
            UserGroupBox.Controls.Add(PhoneLabel);
            UserGroupBox.Controls.Add(SurnameLabel);
            UserGroupBox.Controls.Add(NameLabel);
            UserGroupBox.Controls.Add(GovIDLabel);
            UserGroupBox.ForeColor = Color.White;
            UserGroupBox.Location = new Point(20, 162);
            UserGroupBox.Name = "UserGroupBox";
            UserGroupBox.Size = new Size(254, 129);
            UserGroupBox.TabIndex = 19;
            UserGroupBox.TabStop = false;
            UserGroupBox.Text = "Seçilen Kullanıcı";
            // 
            // GenderLabel
            // 
            GenderLabel.AutoSize = true;
            GenderLabel.Location = new Point(6, 98);
            GenderLabel.Name = "GenderLabel";
            GenderLabel.Size = new Size(55, 15);
            GenderLabel.TabIndex = 5;
            GenderLabel.Text = "Cinsiyet :";
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(6, 83);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(53, 15);
            EmailLabel.TabIndex = 4;
            EmailLabel.Text = "E-Posta :";
            // 
            // PhoneLabel
            // 
            PhoneLabel.AutoSize = true;
            PhoneLabel.Location = new Point(6, 68);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new Size(51, 15);
            PhoneLabel.TabIndex = 3;
            PhoneLabel.Text = "Telefon :";
            // 
            // SurnameLabel
            // 
            SurnameLabel.AutoSize = true;
            SurnameLabel.Location = new Point(6, 54);
            SurnameLabel.Name = "SurnameLabel";
            SurnameLabel.Size = new Size(45, 15);
            SurnameLabel.TabIndex = 2;
            SurnameLabel.Text = "Soyad :";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(6, 39);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(28, 15);
            NameLabel.TabIndex = 1;
            NameLabel.Text = "Ad :";
            // 
            // GovIDLabel
            // 
            GovIDLabel.AutoSize = true;
            GovIDLabel.Location = new Point(6, 24);
            GovIDLabel.Name = "GovIDLabel";
            GovIDLabel.Size = new Size(84, 15);
            GovIDLabel.TabIndex = 0;
            GovIDLabel.Text = "TC Kimlik No : ";
            // 
            // RouteGroupBox
            // 
            RouteGroupBox.Controls.Add(PlateLabel);
            RouteGroupBox.Controls.Add(PriceLabel);
            RouteGroupBox.Controls.Add(EtaLabel);
            RouteGroupBox.Controls.Add(RouteDate);
            RouteGroupBox.Controls.Add(DestinationLabel);
            RouteGroupBox.Controls.Add(DepartureLabel);
            RouteGroupBox.ForeColor = Color.White;
            RouteGroupBox.Location = new Point(20, 297);
            RouteGroupBox.Name = "RouteGroupBox";
            RouteGroupBox.Size = new Size(254, 129);
            RouteGroupBox.TabIndex = 20;
            RouteGroupBox.TabStop = false;
            RouteGroupBox.Text = "Seçilen Rota";
            // 
            // PlateLabel
            // 
            PlateLabel.AutoSize = true;
            PlateLabel.Location = new Point(6, 98);
            PlateLabel.Name = "PlateLabel";
            PlateLabel.Size = new Size(41, 15);
            PlateLabel.TabIndex = 5;
            PlateLabel.Text = "Plaka :";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Location = new Point(6, 83);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(38, 15);
            PriceLabel.TabIndex = 4;
            PriceLabel.Text = "Fiyat :";
            // 
            // EtaLabel
            // 
            EtaLabel.AutoSize = true;
            EtaLabel.Location = new Point(6, 68);
            EtaLabel.Name = "EtaLabel";
            EtaLabel.Size = new Size(108, 15);
            EtaLabel.TabIndex = 3;
            EtaLabel.Text = "Tahmini Yol Süresi :";
            // 
            // RouteDate
            // 
            RouteDate.AutoSize = true;
            RouteDate.Location = new Point(6, 54);
            RouteDate.Name = "RouteDate";
            RouteDate.Size = new Size(38, 15);
            RouteDate.TabIndex = 2;
            RouteDate.Text = "Tarih :";
            // 
            // DestinationLabel
            // 
            DestinationLabel.AutoSize = true;
            DestinationLabel.Location = new Point(6, 39);
            DestinationLabel.Name = "DestinationLabel";
            DestinationLabel.Size = new Size(59, 15);
            DestinationLabel.TabIndex = 1;
            DestinationLabel.Text = "Varış Yeri :";
            // 
            // DepartureLabel
            // 
            DepartureLabel.AutoSize = true;
            DepartureLabel.Location = new Point(6, 24);
            DepartureLabel.Name = "DepartureLabel";
            DepartureLabel.Size = new Size(65, 15);
            DepartureLabel.TabIndex = 0;
            DepartureLabel.Text = "Kalkış Yeri :";
            // 
            // UserSelectCB
            // 
            UserSelectCB.FormattingEnabled = true;
            UserSelectCB.Location = new Point(21, 80);
            UserSelectCB.Name = "UserSelectCB";
            UserSelectCB.Size = new Size(128, 23);
            UserSelectCB.TabIndex = 1;
            UserSelectCB.SelectedIndexChanged += UserSelectCB_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(21, 62);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 23;
            label2.Text = "Kullanıcı :";
            // 
            // RouteSelectCB
            // 
            RouteSelectCB.FormattingEnabled = true;
            RouteSelectCB.Location = new Point(21, 133);
            RouteSelectCB.Name = "RouteSelectCB";
            RouteSelectCB.Size = new Size(128, 23);
            RouteSelectCB.TabIndex = 2;
            RouteSelectCB.SelectedIndexChanged += RouteSelectCB_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(21, 115);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 25;
            label3.Text = "Rota :";
            // 
            // SeatGB
            // 
            SeatGB.ForeColor = Color.White;
            SeatGB.Location = new Point(301, 30);
            SeatGB.Name = "SeatGB";
            SeatGB.Size = new Size(231, 396);
            SeatGB.TabIndex = 27;
            SeatGB.TabStop = false;
            SeatGB.Text = "Koltuk Seçimi";
            SeatGB.Visible = false;
            // 
            // TicketAdd
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(42, 42, 42);
            ClientSize = new Size(544, 469);
            Controls.Add(SeatGB);
            Controls.Add(RouteSelectCB);
            Controls.Add(label3);
            Controls.Add(UserSelectCB);
            Controls.Add(label2);
            Controls.Add(RouteGroupBox);
            Controls.Add(UserGroupBox);
            Controls.Add(IDLabel);
            Controls.Add(label1);
            Controls.Add(CancelButton);
            Controls.Add(SaveButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "TicketAdd";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Bilet Ekle/Düzenle";
            Shown += TicketAdd_Shown;
            UserGroupBox.ResumeLayout(false);
            UserGroupBox.PerformLayout();
            RouteGroupBox.ResumeLayout(false);
            RouteGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IDLabel;
        private Label label1;
        private Button CancelButton;
        private Button SaveButton;
        private GroupBox UserGroupBox;
        private GroupBox RouteGroupBox;
        private ComboBox UserSelectCB;
        private Label label2;
        private ComboBox RouteSelectCB;
        private Label label3;
        private GroupBox SeatGB;
        private Label PhoneLabel;
        private Label SurnameLabel;
        private Label NameLabel;
        private Label GovIDLabel;
        private Label GenderLabel;
        private Label EmailLabel;
        private Label RouteDate;
        private Label DestinationLabel;
        private Label DepartureLabel;
        private Label PriceLabel;
        private Label EtaLabel;
        private Label PlateLabel;
        private HelpProvider helpProvider1;
    }
}