namespace OBS
{
    partial class TicketBuy
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
            SeatGB = new GroupBox();
            RouteGroupBox = new GroupBox();
            PlateLabel = new Label();
            PriceLabel = new Label();
            EtaLabel = new Label();
            RouteDate = new Label();
            DestinationLabel = new Label();
            DepartureLabel = new Label();
            UserGroupBox = new GroupBox();
            GenderLabel = new Label();
            EmailLabel = new Label();
            PhoneLabel = new Label();
            SurnameLabel = new Label();
            NameLabel = new Label();
            GovIDLabel = new Label();
            CancelButton = new Button();
            BuyButton = new Button();
            TopLabel = new Label();
            RouteGroupBox.SuspendLayout();
            UserGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // SeatGB
            // 
            SeatGB.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            SeatGB.ForeColor = Color.White;
            SeatGB.Location = new Point(281, 39);
            SeatGB.Name = "SeatGB";
            SeatGB.Size = new Size(181, 357);
            SeatGB.TabIndex = 32;
            SeatGB.TabStop = false;
            SeatGB.Text = "Koltuk Seçimi";
            // 
            // RouteGroupBox
            // 
            RouteGroupBox.Controls.Add(PlateLabel);
            RouteGroupBox.Controls.Add(PriceLabel);
            RouteGroupBox.Controls.Add(EtaLabel);
            RouteGroupBox.Controls.Add(RouteDate);
            RouteGroupBox.Controls.Add(DestinationLabel);
            RouteGroupBox.Controls.Add(DepartureLabel);
            RouteGroupBox.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            RouteGroupBox.ForeColor = Color.White;
            RouteGroupBox.Location = new Point(12, 205);
            RouteGroupBox.Name = "RouteGroupBox";
            RouteGroupBox.Size = new Size(254, 165);
            RouteGroupBox.TabIndex = 31;
            RouteGroupBox.TabStop = false;
            RouteGroupBox.Text = "Alınacak Rota";
            // 
            // PlateLabel
            // 
            PlateLabel.AutoSize = true;
            PlateLabel.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            PlateLabel.Location = new Point(6, 130);
            PlateLabel.Name = "PlateLabel";
            PlateLabel.Size = new Size(57, 20);
            PlateLabel.TabIndex = 5;
            PlateLabel.Text = "Plaka :";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            PriceLabel.Location = new Point(6, 109);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(50, 20);
            PriceLabel.TabIndex = 4;
            PriceLabel.Text = "Fiyat :";
            // 
            // EtaLabel
            // 
            EtaLabel.AutoSize = true;
            EtaLabel.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            EtaLabel.Location = new Point(6, 88);
            EtaLabel.Name = "EtaLabel";
            EtaLabel.Size = new Size(137, 20);
            EtaLabel.TabIndex = 3;
            EtaLabel.Text = "Tahmini Yol Süresi :";
            // 
            // RouteDate
            // 
            RouteDate.AutoSize = true;
            RouteDate.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            RouteDate.Location = new Point(6, 66);
            RouteDate.Name = "RouteDate";
            RouteDate.Size = new Size(49, 20);
            RouteDate.TabIndex = 2;
            RouteDate.Text = "Tarih :";
            // 
            // DestinationLabel
            // 
            DestinationLabel.AutoSize = true;
            DestinationLabel.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            DestinationLabel.Location = new Point(6, 45);
            DestinationLabel.Name = "DestinationLabel";
            DestinationLabel.Size = new Size(81, 20);
            DestinationLabel.TabIndex = 1;
            DestinationLabel.Text = "Varış Yeri :";
            // 
            // DepartureLabel
            // 
            DepartureLabel.AutoSize = true;
            DepartureLabel.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            DepartureLabel.Location = new Point(6, 24);
            DepartureLabel.Name = "DepartureLabel";
            DepartureLabel.Size = new Size(85, 20);
            DepartureLabel.TabIndex = 0;
            DepartureLabel.Text = "Kalkış Yeri :";
            // 
            // UserGroupBox
            // 
            UserGroupBox.Controls.Add(GenderLabel);
            UserGroupBox.Controls.Add(EmailLabel);
            UserGroupBox.Controls.Add(PhoneLabel);
            UserGroupBox.Controls.Add(SurnameLabel);
            UserGroupBox.Controls.Add(NameLabel);
            UserGroupBox.Controls.Add(GovIDLabel);
            UserGroupBox.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            UserGroupBox.ForeColor = Color.White;
            UserGroupBox.Location = new Point(12, 38);
            UserGroupBox.Name = "UserGroupBox";
            UserGroupBox.Size = new Size(254, 161);
            UserGroupBox.TabIndex = 30;
            UserGroupBox.TabStop = false;
            UserGroupBox.Text = "Bileti Alacak Kullanıcı";
            // 
            // GenderLabel
            // 
            GenderLabel.AutoSize = true;
            GenderLabel.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            GenderLabel.Location = new Point(6, 125);
            GenderLabel.Name = "GenderLabel";
            GenderLabel.Size = new Size(73, 20);
            GenderLabel.TabIndex = 5;
            GenderLabel.Text = "Cinsiyet :";
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            EmailLabel.Location = new Point(6, 105);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(70, 20);
            EmailLabel.TabIndex = 4;
            EmailLabel.Text = "E-Posta :";
            // 
            // PhoneLabel
            // 
            PhoneLabel.AutoSize = true;
            PhoneLabel.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneLabel.Location = new Point(6, 84);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new Size(69, 20);
            PhoneLabel.TabIndex = 3;
            PhoneLabel.Text = "Telefon :";
            // 
            // SurnameLabel
            // 
            SurnameLabel.AutoSize = true;
            SurnameLabel.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            SurnameLabel.Location = new Point(6, 64);
            SurnameLabel.Name = "SurnameLabel";
            SurnameLabel.Size = new Size(62, 20);
            SurnameLabel.TabIndex = 2;
            SurnameLabel.Text = "Soyad :";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            NameLabel.Location = new Point(6, 44);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(38, 20);
            NameLabel.TabIndex = 1;
            NameLabel.Text = "Ad :";
            // 
            // GovIDLabel
            // 
            GovIDLabel.AutoSize = true;
            GovIDLabel.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            GovIDLabel.Location = new Point(6, 24);
            GovIDLabel.Name = "GovIDLabel";
            GovIDLabel.Size = new Size(106, 20);
            GovIDLabel.TabIndex = 0;
            GovIDLabel.Text = "TC Kimlik No : ";
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
            CancelButton.Location = new Point(12, 417);
            CancelButton.Margin = new Padding(3, 2, 3, 2);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(82, 22);
            CancelButton.TabIndex = 29;
            CancelButton.Text = "İptal";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // BuyButton
            // 
            BuyButton.BackColor = Color.FromArgb(62, 62, 62);
            BuyButton.FlatAppearance.BorderSize = 0;
            BuyButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 120, 120);
            BuyButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 90, 90);
            BuyButton.FlatStyle = FlatStyle.Flat;
            BuyButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BuyButton.ForeColor = Color.Transparent;
            BuyButton.Location = new Point(382, 417);
            BuyButton.Margin = new Padding(3, 2, 3, 2);
            BuyButton.Name = "BuyButton";
            BuyButton.Size = new Size(82, 22);
            BuyButton.TabIndex = 28;
            BuyButton.Text = "Satın Al";
            BuyButton.UseVisualStyleBackColor = false;
            BuyButton.Click += BuyButton_Click;
            // 
            // TopLabel
            // 
            TopLabel.AutoSize = true;
            TopLabel.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            TopLabel.ForeColor = Color.White;
            TopLabel.Location = new Point(11, 9);
            TopLabel.Margin = new Padding(2, 0, 2, 0);
            TopLabel.Name = "TopLabel";
            TopLabel.Size = new Size(135, 25);
            TopLabel.TabIndex = 33;
            TopLabel.Text = "Bilet Satın Al";
            // 
            // TicketBuy
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(42, 42, 42);
            ClientSize = new Size(476, 450);
            Controls.Add(TopLabel);
            Controls.Add(SeatGB);
            Controls.Add(RouteGroupBox);
            Controls.Add(UserGroupBox);
            Controls.Add(CancelButton);
            Controls.Add(BuyButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "TicketBuy";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Bilet Satın Al";
            FormClosing += TicketBuy_FormClosing;
            Shown += TicketBuy_Shown;
            RouteGroupBox.ResumeLayout(false);
            RouteGroupBox.PerformLayout();
            UserGroupBox.ResumeLayout(false);
            UserGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox SeatGB;
        private GroupBox RouteGroupBox;
        private Label PlateLabel;
        private Label PriceLabel;
        private Label EtaLabel;
        private Label RouteDate;
        private Label DestinationLabel;
        private Label DepartureLabel;
        private GroupBox UserGroupBox;
        private Label GenderLabel;
        private Label EmailLabel;
        private Label PhoneLabel;
        private Label SurnameLabel;
        private Label NameLabel;
        private Label GovIDLabel;
        private Button CancelButton;
        private Button BuyButton;
        private Label TopLabel;
    }
}