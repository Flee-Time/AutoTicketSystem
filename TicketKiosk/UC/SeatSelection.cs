namespace OBS.UC
{
    public partial class SeatSelection : UserControl
    {
        private bool _edit;

        public SeatSelection(string SeatOrder, string ReservedSeats, int MaxSeats, bool edit)
        {
            InitializeComponent();

            _edit = edit;

            var rSeats = ReservedSeats.Split(',');

            var x = 1;
            var y = 1;
            var z = 1;
            if (SeatOrder == "1+2")
            {
                for (int i = 1; i < MaxSeats + 1; i++)
                {
                    if (i <= Math.Round((double)MaxSeats / 3))
                    {
                        if (rSeats.Contains(Convert.ToString(i)))
                        {
                            CheckBox checkBox = new CheckBox();
                            checkBox.Text = "";
                            checkBox.AutoSize = true;
                            checkBox.Location = new Point(20, 25 * i);
                            checkBox.Checked = true;
                            checkBox.Enabled = false;

                            this.Controls.Add(checkBox);
                        }
                        else
                        {
                            RadioButton radioButton = new RadioButton();
                            radioButton.Text = "";
                            radioButton.AutoSize = true;
                            radioButton.Location = new Point(20, 25 * i);
                            radioButton.Name = Convert.ToString(i);

                            radioButton.CheckedChanged += RadioButton_CheckedChanged;
                            this.Controls.Add(radioButton);
                        }
                    }
                    else if (i <= MaxSeats - Math.Round((double)MaxSeats / 3))
                    {
                        if (rSeats.Contains(Convert.ToString(i)))
                        {
                            CheckBox checkBox = new CheckBox();
                            checkBox.Text = "";
                            checkBox.AutoSize = true;
                            checkBox.Location = new Point(50, 25 * x);
                            checkBox.Checked = true;
                            checkBox.Enabled = false;

                            this.Controls.Add(checkBox);
                        }
                        else
                        {
                            RadioButton radioButton = new RadioButton();
                            radioButton.Text = "";
                            radioButton.AutoSize = true;
                            radioButton.Location = new Point(50, 25 * x);
                            radioButton.Name = Convert.ToString(i);

                            radioButton.CheckedChanged += RadioButton_CheckedChanged;
                            this.Controls.Add(radioButton);
                        }
                        x++;
                    }
                    else
                    {
                        if (rSeats.Contains(Convert.ToString(i)))
                        {
                            CheckBox checkBox = new CheckBox();
                            checkBox.Text = "";
                            checkBox.AutoSize = true;
                            checkBox.Location = new Point(100, 25 * y);
                            checkBox.Checked = true;
                            checkBox.Enabled = false;

                            this.Controls.Add(checkBox);
                        }
                        else
                        {
                            RadioButton radioButton = new RadioButton();
                            radioButton.Text = "";
                            radioButton.AutoSize = true;
                            radioButton.Location = new Point(100, 25 * y);
                            radioButton.Name = Convert.ToString(i);

                            radioButton.CheckedChanged += RadioButton_CheckedChanged;
                            this.Controls.Add(radioButton);
                        }
                        y++;
                    }
                }
            }
            else if (SeatOrder == "1+1")
            {
                for (int i = 1; i < MaxSeats + 1; i++)
                {
                    if (i <= Math.Round((double)MaxSeats / 2))
                    {
                        if (rSeats.Contains(Convert.ToString(i)))
                        {
                            CheckBox checkBox = new CheckBox();
                            checkBox.Text = "";
                            checkBox.AutoSize = true;
                            checkBox.Location = new Point(20, 25 * i);
                            checkBox.Checked = true;
                            checkBox.Enabled = false;

                            this.Controls.Add(checkBox);
                        }
                        else
                        {
                            RadioButton radioButton = new RadioButton();
                            radioButton.Text = "";
                            radioButton.AutoSize = true;
                            radioButton.Location = new Point(20, 25 * i);
                            radioButton.Name = Convert.ToString(i);

                            radioButton.CheckedChanged += RadioButton_CheckedChanged;
                            this.Controls.Add(radioButton);
                        }
                    }
                    else
                    {
                        if (rSeats.Contains(Convert.ToString(i)))
                        {
                            CheckBox checkBox = new CheckBox();
                            checkBox.Text = "";
                            checkBox.AutoSize = true;
                            checkBox.Location = new Point(80, 25 * x);
                            checkBox.Checked = true;
                            checkBox.Enabled = false;

                            this.Controls.Add(checkBox);
                        }
                        else
                        {
                            RadioButton radioButton = new RadioButton();
                            radioButton.Text = "";
                            radioButton.AutoSize = true;
                            radioButton.Location = new Point(80, 25 * x);
                            radioButton.Name = Convert.ToString(i);

                            radioButton.CheckedChanged += RadioButton_CheckedChanged;
                            this.Controls.Add(radioButton);
                        }
                        x++;
                    }
                }
            }
            else // 2+2
            {
                for (int i = 1; i < MaxSeats + 1; i++)
                {
                    if (i <= Math.Round((double)MaxSeats / 4))
                    {
                        if (rSeats.Contains(Convert.ToString(i)))
                        {
                            CheckBox checkBox = new CheckBox();
                            checkBox.Text = "";
                            checkBox.AutoSize = true;
                            checkBox.Location = new Point(20, 25 * i);
                            checkBox.Checked = true;
                            checkBox.Enabled = false;

                            this.Controls.Add(checkBox);
                        }
                        else
                        {
                            RadioButton radioButton = new RadioButton();
                            radioButton.Text = "";
                            radioButton.AutoSize = true;
                            radioButton.Location = new Point(20, 25 * i);
                            radioButton.Name = Convert.ToString(i);

                            radioButton.CheckedChanged += RadioButton_CheckedChanged;
                            this.Controls.Add(radioButton);
                        }
                    }
                    else if (i <= MaxSeats - Math.Round((double)MaxSeats / 2))
                    {
                        if (rSeats.Contains(Convert.ToString(i)))
                        {
                            CheckBox checkBox = new CheckBox();
                            checkBox.Text = "";
                            checkBox.AutoSize = true;
                            checkBox.Location = new Point(50, 25 * x);
                            checkBox.Checked = true;
                            checkBox.Enabled = false;

                            this.Controls.Add(checkBox);
                        }
                        else
                        {
                            RadioButton radioButton = new RadioButton();
                            radioButton.Text = "";
                            radioButton.AutoSize = true;
                            radioButton.Location = new Point(50, 25 * x);
                            radioButton.Name = Convert.ToString(i);

                            radioButton.CheckedChanged += RadioButton_CheckedChanged;
                            this.Controls.Add(radioButton);
                        }
                        x++;
                    }
                    else if (i <= MaxSeats - Math.Round((double)MaxSeats / 4))
                    {
                        if (rSeats.Contains(Convert.ToString(i)))
                        {
                            CheckBox checkBox = new CheckBox();
                            checkBox.Text = "";
                            checkBox.AutoSize = true;
                            checkBox.Location = new Point(100, 25 * y);
                            checkBox.Checked = true;
                            checkBox.Enabled = false;

                            this.Controls.Add(checkBox);
                        }
                        else
                        {
                            RadioButton radioButton = new RadioButton();
                            radioButton.Text = "";
                            radioButton.AutoSize = true;
                            radioButton.Location = new Point(100, 25 * y);
                            radioButton.Name = Convert.ToString(i);

                            radioButton.CheckedChanged += RadioButton_CheckedChanged;
                            this.Controls.Add(radioButton);
                        }
                        y++;
                    }
                    else
                    {
                        if (rSeats.Contains(Convert.ToString(i)))
                        {
                            CheckBox checkBox = new CheckBox();
                            checkBox.Text = "";
                            checkBox.AutoSize = true;
                            checkBox.Location = new Point(130, 25 * z);
                            checkBox.Checked = true;
                            checkBox.Enabled = false;

                            this.Controls.Add(checkBox);
                        }
                        else
                        {
                            RadioButton radioButton = new RadioButton();
                            radioButton.Text = "";
                            radioButton.AutoSize = true;
                            radioButton.Location = new Point(130, 25 * z);
                            radioButton.Name = Convert.ToString(i);

                            radioButton.CheckedChanged += RadioButton_CheckedChanged;
                            this.Controls.Add(radioButton);
                        }
                        z++;
                    }
                }
            }
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton button = sender as RadioButton;
            if (_edit)
            {
                TicketAdd ticketAdd = TicketAdd.Instance;
                ticketAdd.selectedSeat = Convert.ToInt16(button.Name);
            }
            else
            {
                TicketBuy ticketBuy = TicketBuy.Instance;
                ticketBuy.selectedSeat = Convert.ToInt16(button.Name);
            }
        }
    }
}

