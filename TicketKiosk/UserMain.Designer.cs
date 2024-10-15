namespace OBS
{
    partial class UserMain
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
            LogoutButton = new Button();
            AdminLabel = new Label();
            DepartureCB = new ComboBox();
            DestinationCB = new ComboBox();
            ResetFilterButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ShowUserTicketsButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LogoutButton
            // 
            LogoutButton.BackColor = Color.FromArgb(62, 62, 62);
            LogoutButton.FlatAppearance.BorderSize = 0;
            LogoutButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 120, 120);
            LogoutButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 90, 90);
            LogoutButton.FlatStyle = FlatStyle.Flat;
            LogoutButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LogoutButton.ForeColor = Color.Transparent;
            LogoutButton.Location = new Point(878, 15);
            LogoutButton.Margin = new Padding(4);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(94, 29);
            LogoutButton.TabIndex = 8;
            LogoutButton.Text = "Çıkış Yap";
            LogoutButton.UseVisualStyleBackColor = false;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // AdminLabel
            // 
            AdminLabel.AutoSize = true;
            AdminLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            AdminLabel.ForeColor = Color.White;
            AdminLabel.Location = new Point(15, 11);
            AdminLabel.Margin = new Padding(4, 0, 4, 0);
            AdminLabel.Name = "AdminLabel";
            AdminLabel.Size = new Size(240, 25);
            AdminLabel.TabIndex = 9;
            AdminLabel.Text = "Otobüs Bilet Otomasyonu";
            // 
            // DepartureCB
            // 
            DepartureCB.FormattingEnabled = true;
            DepartureCB.Location = new Point(314, 80);
            DepartureCB.Margin = new Padding(4);
            DepartureCB.Name = "DepartureCB";
            DepartureCB.Size = new Size(150, 28);
            DepartureCB.TabIndex = 10;
            DepartureCB.SelectedIndexChanged += DepartureCB_SelectedIndexChanged;
            // 
            // DestinationCB
            // 
            DestinationCB.FormattingEnabled = true;
            DestinationCB.Location = new Point(522, 80);
            DestinationCB.Margin = new Padding(4);
            DestinationCB.Name = "DestinationCB";
            DestinationCB.Size = new Size(150, 28);
            DestinationCB.TabIndex = 11;
            DestinationCB.SelectedIndexChanged += DestinationCB_SelectedIndexChanged;
            // 
            // ResetFilterButton
            // 
            ResetFilterButton.BackColor = Color.FromArgb(62, 62, 62);
            ResetFilterButton.FlatAppearance.BorderSize = 0;
            ResetFilterButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 120, 120);
            ResetFilterButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 90, 90);
            ResetFilterButton.FlatStyle = FlatStyle.Flat;
            ResetFilterButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ResetFilterButton.ForeColor = Color.Transparent;
            ResetFilterButton.Location = new Point(110, 80);
            ResetFilterButton.Margin = new Padding(4);
            ResetFilterButton.Name = "ResetFilterButton";
            ResetFilterButton.Size = new Size(94, 29);
            ResetFilterButton.TabIndex = 12;
            ResetFilterButton.Text = "Sıfırla";
            ResetFilterButton.UseVisualStyleBackColor = false;
            ResetFilterButton.Click += ResetFilterButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(90, 56);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 13;
            label1.Text = "Filtreler :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(473, 78);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(42, 28);
            label2.TabIndex = 14;
            label2.Text = "-->";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(314, 55);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 15;
            label3.Text = "Kalkış Yeri :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(522, 56);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 16;
            label4.Text = "Varış Yeri :";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(120, 120, 120);
            pictureBox1.Location = new Point(61, 124);
            pictureBox1.Margin = new Padding(2, 4, 2, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(875, 4);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // ShowUserTicketsButton
            // 
            ShowUserTicketsButton.BackColor = Color.FromArgb(62, 62, 62);
            ShowUserTicketsButton.FlatAppearance.BorderSize = 0;
            ShowUserTicketsButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 120, 120);
            ShowUserTicketsButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 90, 90);
            ShowUserTicketsButton.FlatStyle = FlatStyle.Flat;
            ShowUserTicketsButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ShowUserTicketsButton.ForeColor = Color.Transparent;
            ShowUserTicketsButton.Location = new Point(807, 80);
            ShowUserTicketsButton.Margin = new Padding(4);
            ShowUserTicketsButton.Name = "ShowUserTicketsButton";
            ShowUserTicketsButton.Size = new Size(94, 29);
            ShowUserTicketsButton.TabIndex = 18;
            ShowUserTicketsButton.Text = "Biletlerim";
            ShowUserTicketsButton.UseVisualStyleBackColor = false;
            ShowUserTicketsButton.Click += ShowUserTicketsButton_Click;
            // 
            // UserMain
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            BackColor = Color.FromArgb(42, 42, 42);
            ClientSize = new Size(1005, 564);
            Controls.Add(ShowUserTicketsButton);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ResetFilterButton);
            Controls.Add(DestinationCB);
            Controls.Add(DepartureCB);
            Controls.Add(AdminLabel);
            Controls.Add(LogoutButton);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "UserMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Anasayfa";
            FormClosing += UserMain_FormClosing;
            Load += UserMain_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LogoutButton;
        private Label AdminLabel;
        private ComboBox DepartureCB;
        private ComboBox DestinationCB;
        private Button ResetFilterButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private Button ShowUserTicketsButton;
    }
}