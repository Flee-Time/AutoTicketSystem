namespace OBS.UC
{
    partial class RouteListItem
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
            BuyButton = new Button();
            pictureBox1 = new PictureBox();
            RouteLabel = new Label();
            label2 = new Label();
            label3 = new Label();
            ETALabel = new Label();
            label5 = new Label();
            DateLabel = new Label();
            label7 = new Label();
            EmptySeatsLabel = new Label();
            label9 = new Label();
            PriceLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BuyButton
            // 
            BuyButton.BackColor = Color.FromArgb(62, 62, 62);
            BuyButton.FlatAppearance.BorderSize = 0;
            BuyButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 120, 120);
            BuyButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 90, 90);
            BuyButton.FlatStyle = FlatStyle.Flat;
            BuyButton.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BuyButton.ForeColor = Color.White;
            BuyButton.Location = new Point(611, 96);
            BuyButton.Margin = new Padding(3, 4, 3, 4);
            BuyButton.Name = "BuyButton";
            BuyButton.Size = new Size(120, 40);
            BuyButton.TabIndex = 0;
            BuyButton.Text = "Satın Al";
            BuyButton.UseVisualStyleBackColor = false;
            BuyButton.Click += BuyButton_Click;
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
            label3.Location = new Point(18, 105);
            label3.Name = "label3";
            label3.Size = new Size(62, 22);
            label3.TabIndex = 4;
            label3.Text = "Saat :";
            // 
            // ETALabel
            // 
            ETALabel.AutoSize = true;
            ETALabel.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ETALabel.ForeColor = Color.White;
            ETALabel.Location = new Point(81, 105);
            ETALabel.Name = "ETALabel";
            ETALabel.Size = new Size(124, 22);
            ETALabel.TabIndex = 5;
            ETALabel.Text = "12:30 - 15:30";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(318, 20);
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
            DateLabel.Location = new Point(381, 20);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(114, 22);
            DateLabel.TabIndex = 7;
            DateLabel.Text = "25/12/2023";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(318, 105);
            label7.Name = "label7";
            label7.Size = new Size(161, 22);
            label7.TabIndex = 8;
            label7.Text = "Boş Koltuk Sayısı :";
            // 
            // EmptySeatsLabel
            // 
            EmptySeatsLabel.AutoSize = true;
            EmptySeatsLabel.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            EmptySeatsLabel.ForeColor = Color.White;
            EmptySeatsLabel.Location = new Point(474, 105);
            EmptySeatsLabel.Name = "EmptySeatsLabel";
            EmptySeatsLabel.Size = new Size(21, 22);
            EmptySeatsLabel.TabIndex = 9;
            EmptySeatsLabel.Text = "8";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(656, 20);
            label9.Name = "label9";
            label9.Size = new Size(63, 22);
            label9.TabIndex = 10;
            label9.Text = "Fiyat :";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            PriceLabel.ForeColor = Color.White;
            PriceLabel.Location = new Point(662, 52);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(53, 23);
            PriceLabel.TabIndex = 11;
            PriceLabel.Text = "487₺";
            // 
            // RouteListItem
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(42, 42, 42);
            Controls.Add(PriceLabel);
            Controls.Add(label9);
            Controls.Add(EmptySeatsLabel);
            Controls.Add(label7);
            Controls.Add(DateLabel);
            Controls.Add(label5);
            Controls.Add(ETALabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(RouteLabel);
            Controls.Add(pictureBox1);
            Controls.Add(BuyButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RouteListItem";
            Size = new Size(743, 160);
            Load += RouteListItem_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BuyButton;
        private PictureBox pictureBox1;
        private Label RouteLabel;
        private Label label2;
        private Label label3;
        private Label ETALabel;
        private Label label5;
        private Label DateLabel;
        private Label label7;
        private Label EmptySeatsLabel;
        private Label label9;
        private Label PriceLabel;
    }
}
