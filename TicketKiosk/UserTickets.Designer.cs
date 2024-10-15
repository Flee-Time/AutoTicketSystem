namespace OBS
{
    partial class UserTickets
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            AdminLabel = new Label();
            refreshTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(120, 120, 120);
            pictureBox1.Location = new Point(21, 39);
            pictureBox1.Margin = new Padding(2, 3, 2, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(600, 3);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // AdminLabel
            // 
            AdminLabel.AutoSize = true;
            AdminLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            AdminLabel.ForeColor = Color.White;
            AdminLabel.Location = new Point(286, 9);
            AdminLabel.Name = "AdminLabel";
            AdminLabel.Size = new Size(77, 20);
            AdminLabel.TabIndex = 19;
            AdminLabel.Text = "Biletlerim";
            // 
            // refreshTimer
            // 
            refreshTimer.Interval = 10000;
            refreshTimer.Tick += refreshTimer_Tick;
            // 
            // UserTickets
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            BackColor = Color.FromArgb(42, 42, 42);
            ClientSize = new Size(642, 362);
            Controls.Add(AdminLabel);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "UserTickets";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Biletlerim";
            Shown += UserTickets_Shown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label AdminLabel;
        private System.Windows.Forms.Timer refreshTimer;
    }
}