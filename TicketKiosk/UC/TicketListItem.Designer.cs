namespace OBS.UC
{
    partial class TicketListItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DetailsButton = new Button();
            pictureBox1 = new PictureBox();
            RouteLabel = new Label();
            label2 = new Label();
            label3 = new Label();
            DepartureTimeLabel = new Label();
            label5 = new Label();
            DateLabel = new Label();
            label9 = new Label();
            PNRLabel = new Label();
            label1 = new Label();
            SeatLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // DetailsButton
            // 
            DetailsButton.BackColor = Color.FromArgb(62, 62, 62);
            DetailsButton.FlatAppearance.BorderSize = 0;
            DetailsButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 120, 120);
            DetailsButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 90, 90);
            DetailsButton.FlatStyle = FlatStyle.Flat;
            DetailsButton.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            DetailsButton.ForeColor = Color.White;
            DetailsButton.Location = new Point(573, 53);
            DetailsButton.Margin = new Padding(3, 4, 3, 4);
            DetailsButton.Name = "DetailsButton";
            DetailsButton.Size = new Size(120, 40);
            DetailsButton.TabIndex = 0;
            DetailsButton.Text = "Detaylar";
            DetailsButton.UseVisualStyleBackColor = false;
            DetailsButton.Click += DetailsButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(120, 120, 120);
            pictureBox1.Location = new Point(3, 152);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(739, 4);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // RouteLabel
            // 
            RouteLabel.AutoSize = true;
            RouteLabel.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            RouteLabel.ForeColor = Color.White;
            RouteLabel.Location = new Point(35, 53);
            RouteLabel.Name = "RouteLabel";
            RouteLabel.Size = new Size(160, 23);
            RouteLabel.TabIndex = 2;
            RouteLabel.Text = "Istanbul -> Bursa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(18, 20);
            label2.Name = "label2";
            label2.Size = new Size(64, 22);
            label2.TabIndex = 3;
            label2.Text = "Rota :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(220, 106);
            label3.Name = "label3";
            label3.Size = new Size(117, 22);
            label3.TabIndex = 4;
            label3.Text = "Kalkış Saati :";
            // 
            // DepartureTimeLabel
            // 
            DepartureTimeLabel.AutoSize = true;
            DepartureTimeLabel.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            DepartureTimeLabel.ForeColor = Color.White;
            DepartureTimeLabel.Location = new Point(343, 106);
            DepartureTimeLabel.Name = "DepartureTimeLabel";
            DepartureTimeLabel.Size = new Size(59, 22);
            DepartureTimeLabel.TabIndex = 5;
            DepartureTimeLabel.Text = "12:30";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(18, 106);
            label5.Name = "label5";
            label5.Size = new Size(62, 22);
            label5.TabIndex = 6;
            label5.Text = "Tarih :";
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            DateLabel.ForeColor = Color.White;
            DateLabel.Location = new Point(81, 106);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(114, 22);
            DateLabel.TabIndex = 7;
            DateLabel.Text = "25/12/2023";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(220, 20);
            label9.Name = "label9";
            label9.Size = new Size(57, 22);
            label9.TabIndex = 10;
            label9.Text = "PNR :";
            // 
            // PNRLabel
            // 
            PNRLabel.AutoSize = true;
            PNRLabel.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            PNRLabel.ForeColor = Color.White;
            PNRLabel.Location = new Point(229, 53);
            PNRLabel.Name = "PNRLabel";
            PNRLabel.Size = new Size(77, 23);
            PNRLabel.TabIndex = 11;
            PNRLabel.Text = "AJSIDO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(343, 20);
            label1.Name = "label1";
            label1.Size = new Size(106, 22);
            label1.TabIndex = 12;
            label1.Text = "Koltuk No :";
            // 
            // SeatLabel
            // 
            SeatLabel.AutoSize = true;
            SeatLabel.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            SeatLabel.ForeColor = Color.White;
            SeatLabel.Location = new Point(403, 53);
            SeatLabel.Name = "SeatLabel";
            SeatLabel.Size = new Size(32, 23);
            SeatLabel.TabIndex = 13;
            SeatLabel.Text = "23";
            // 
            // TicketListItem
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(42, 42, 42);
            Controls.Add(SeatLabel);
            Controls.Add(label1);
            Controls.Add(PNRLabel);
            Controls.Add(label9);
            Controls.Add(DateLabel);
            Controls.Add(label5);
            Controls.Add(DepartureTimeLabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(RouteLabel);
            Controls.Add(pictureBox1);
            Controls.Add(DetailsButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TicketListItem";
            Size = new Size(743, 160);
            Load += TicketListItem_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DetailsButton;
        private PictureBox pictureBox1;
        private Label RouteLabel;
        private Label label2;
        private Label label3;
        private Label DepartureTimeLabel;
        private Label label5;
        private Label DateLabel;
        private Label label9;
        private Label PNRLabel;
        private Label label1;
        private Label SeatLabel;
    }
}
