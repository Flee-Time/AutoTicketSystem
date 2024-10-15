namespace OBS
{
    partial class BusAdd
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
            SaveButton = new Button();
            CancelButton = new Button();
            label1 = new Label();
            MaxPassengerNUD = new NumericUpDown();
            SeatingOrderCB = new ComboBox();
            label2 = new Label();
            PlateTextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            IDLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)MaxPassengerNUD).BeginInit();
            SuspendLayout();
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
            SaveButton.Location = new Point(278, 212);
            SaveButton.Margin = new Padding(4, 2, 4, 2);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(102, 28);
            SaveButton.TabIndex = 4;
            SaveButton.Text = "Kaydet";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
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
            CancelButton.Location = new Point(12, 212);
            CancelButton.Margin = new Padding(4, 2, 4, 2);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(102, 28);
            CancelButton.TabIndex = 5;
            CancelButton.Text = "İptal";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(198, 25);
            label1.TabIndex = 3;
            label1.Text = "Otobüs Ekle/Düzenle";
            // 
            // MaxPassengerNUD
            // 
            MaxPassengerNUD.Location = new Point(238, 152);
            MaxPassengerNUD.Margin = new Padding(4, 2, 4, 2);
            MaxPassengerNUD.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            MaxPassengerNUD.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            MaxPassengerNUD.Name = "MaxPassengerNUD";
            MaxPassengerNUD.Size = new Size(52, 27);
            MaxPassengerNUD.TabIndex = 3;
            MaxPassengerNUD.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // SeatingOrderCB
            // 
            SeatingOrderCB.FormattingEnabled = true;
            SeatingOrderCB.Items.AddRange(new object[] { "1+1", "2+2", "1+2" });
            SeatingOrderCB.Location = new Point(50, 152);
            SeatingOrderCB.Margin = new Padding(4, 2, 4, 2);
            SeatingOrderCB.Name = "SeatingOrderCB";
            SeatingOrderCB.Size = new Size(65, 28);
            SeatingOrderCB.TabIndex = 2;
            SeatingOrderCB.Text = "2+2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(128, 71);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 6;
            label2.Text = "Plaka :";
            // 
            // PlateTextBox
            // 
            PlateTextBox.Location = new Point(129, 92);
            PlateTextBox.Margin = new Padding(4, 2, 4, 2);
            PlateTextBox.MaxLength = 10;
            PlateTextBox.Name = "PlateTextBox";
            PlateTextBox.PlaceholderText = "16 ABC 321";
            PlateTextBox.Size = new Size(136, 27);
            PlateTextBox.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(176, 131);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(168, 20);
            label3.TabIndex = 8;
            label3.Text = "Maksimum Yolcu Sayısı :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(36, 130);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 9;
            label4.Text = "Oturma Sırası :";
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.ForeColor = Color.White;
            IDLabel.Location = new Point(24, 42);
            IDLabel.Margin = new Padding(4, 0, 4, 0);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(309, 20);
            IDLabel.TabIndex = 10;
            IDLabel.Text = "ID : 5d9f4232-49b4-45de-af5c-3af2721864d6";
            // 
            // BusAdd
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(42, 42, 42);
            ClientSize = new Size(394, 251);
            Controls.Add(IDLabel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(PlateTextBox);
            Controls.Add(label2);
            Controls.Add(SeatingOrderCB);
            Controls.Add(MaxPassengerNUD);
            Controls.Add(label1);
            Controls.Add(CancelButton);
            Controls.Add(SaveButton);
            Margin = new Padding(4, 2, 4, 2);
            Name = "BusAdd";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Otobüs Ekle/Düzenle";
            Shown += BusAdd_Shown;
            ((System.ComponentModel.ISupportInitialize)MaxPassengerNUD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button SaveButton;
        private Button CancelButton;
        private Label label1;
        private NumericUpDown MaxPassengerNUD;
        private ComboBox SeatingOrderCB;
        private Label label2;
        private TextBox PlateTextBox;
        private Label label3;
        private Label label4;
        private Label IDLabel;
    }
}