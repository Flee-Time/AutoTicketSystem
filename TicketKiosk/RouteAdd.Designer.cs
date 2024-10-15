namespace OBS
{
    partial class RouteAdd
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
            label2 = new Label();
            DateTimePicker = new DateTimePicker();
            BusSelectCB = new ComboBox();
            DepartueLocationCB = new ComboBox();
            label5 = new Label();
            DestinationLocationCB = new ComboBox();
            label6 = new Label();
            EtaNUP = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            PriceNUP = new NumericUpDown();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)EtaNUP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PriceNUP).BeginInit();
            SuspendLayout();
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.ForeColor = Color.White;
            IDLabel.Location = new Point(26, 45);
            IDLabel.Margin = new Padding(4, 0, 4, 0);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(309, 20);
            IDLabel.TabIndex = 14;
            IDLabel.Text = "ID : 5d9f4232-49b4-45de-af5c-3af2721864d6";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 11);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(174, 25);
            label1.TabIndex = 13;
            label1.Text = "Rota Ekle/Düzenle";
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
            CancelButton.Location = new Point(15, 311);
            CancelButton.Margin = new Padding(4, 2, 4, 2);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(102, 28);
            CancelButton.TabIndex = 8;
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
            SaveButton.Location = new Point(364, 311);
            SaveButton.Margin = new Padding(4, 2, 4, 2);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(102, 28);
            SaveButton.TabIndex = 7;
            SaveButton.Text = "Kaydet";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(26, 85);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 17;
            label2.Text = "Otobüs :";
            // 
            // DateTimePicker
            // 
            DateTimePicker.Format = DateTimePickerFormat.Time;
            DateTimePicker.Location = new Point(234, 248);
            DateTimePicker.Margin = new Padding(4, 4, 4, 4);
            DateTimePicker.Name = "DateTimePicker";
            DateTimePicker.Size = new Size(214, 27);
            DateTimePicker.TabIndex = 6;
            DateTimePicker.Value = new DateTime(2023, 12, 16, 12, 27, 48, 0);
            // 
            // BusSelectCB
            // 
            BusSelectCB.FormattingEnabled = true;
            BusSelectCB.Location = new Point(26, 108);
            BusSelectCB.Margin = new Padding(4, 4, 4, 4);
            BusSelectCB.Name = "BusSelectCB";
            BusSelectCB.Size = new Size(159, 28);
            BusSelectCB.TabIndex = 1;
            // 
            // DepartueLocationCB
            // 
            DepartueLocationCB.FormattingEnabled = true;
            DepartueLocationCB.Location = new Point(26, 175);
            DepartueLocationCB.Margin = new Padding(4, 4, 4, 4);
            DepartueLocationCB.Name = "DepartueLocationCB";
            DepartueLocationCB.Size = new Size(159, 28);
            DepartueLocationCB.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(26, 152);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(82, 20);
            label5.TabIndex = 23;
            label5.Text = "Kalkış Yeri :";
            // 
            // DestinationLocationCB
            // 
            DestinationLocationCB.FormattingEnabled = true;
            DestinationLocationCB.Location = new Point(26, 248);
            DestinationLocationCB.Margin = new Padding(4, 4, 4, 4);
            DestinationLocationCB.Name = "DestinationLocationCB";
            DestinationLocationCB.Size = new Size(159, 28);
            DestinationLocationCB.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(26, 225);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 25;
            label6.Text = "Varış Yeri :";
            // 
            // EtaNUP
            // 
            EtaNUP.Location = new Point(234, 108);
            EtaNUP.Margin = new Padding(4, 4, 4, 4);
            EtaNUP.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            EtaNUP.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            EtaNUP.Name = "EtaNUP";
            EtaNUP.Size = new Size(48, 27);
            EtaNUP.TabIndex = 4;
            EtaNUP.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(234, 85);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(145, 20);
            label3.TabIndex = 28;
            label3.Text = "Tahmini Varış Süresi :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(289, 110);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 29;
            label4.Text = "Saat";
            // 
            // PriceNUP
            // 
            PriceNUP.DecimalPlaces = 2;
            PriceNUP.Location = new Point(234, 175);
            PriceNUP.Margin = new Padding(4, 4, 4, 4);
            PriceNUP.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            PriceNUP.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            PriceNUP.Name = "PriceNUP";
            PriceNUP.Size = new Size(84, 27);
            PriceNUP.TabIndex = 5;
            PriceNUP.Value = new decimal(new int[] { 400, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(234, 152);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(47, 20);
            label7.TabIndex = 31;
            label7.Text = "Fiyat :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(325, 180);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(17, 20);
            label8.TabIndex = 32;
            label8.Text = "₺";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(234, 225);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(166, 20);
            label9.TabIndex = 33;
            label9.Text = "Kalkış Zamanı ve Tarihi :";
            // 
            // RouteAdd
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(42, 42, 42);
            ClientSize = new Size(481, 352);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(PriceNUP);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(EtaNUP);
            Controls.Add(DestinationLocationCB);
            Controls.Add(label6);
            Controls.Add(DepartueLocationCB);
            Controls.Add(label5);
            Controls.Add(BusSelectCB);
            Controls.Add(DateTimePicker);
            Controls.Add(label2);
            Controls.Add(IDLabel);
            Controls.Add(label1);
            Controls.Add(CancelButton);
            Controls.Add(SaveButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            Name = "RouteAdd";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Rota Ekle/Düzenle";
            Shown += RouteAdd_Shown;
            ((System.ComponentModel.ISupportInitialize)EtaNUP).EndInit();
            ((System.ComponentModel.ISupportInitialize)PriceNUP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IDLabel;
        private Label label1;
        private Button CancelButton;
        private Button SaveButton;
        private Label label2;
        private DateTimePicker DateTimePicker;
        private ComboBox BusSelectCB;
        private ComboBox DepartueLocationCB;
        private Label label5;
        private ComboBox DestinationLocationCB;
        private Label label6;
        private NumericUpDown EtaNUP;
        private Label label3;
        private Label label4;
        private NumericUpDown PriceNUP;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}