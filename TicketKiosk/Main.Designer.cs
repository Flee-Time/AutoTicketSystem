namespace OBS
{
    partial class Main
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            AdminPanel = new TabControl();
            UserPanel = new TabPage();
            ExportUsersButton = new Button();
            UserDeleteButton = new Button();
            UserUpdateButton = new Button();
            UserAddButton = new Button();
            UserGridView = new DataGridView();
            BusPanel = new TabPage();
            ExportBussesButton = new Button();
            BusDeleteButton = new Button();
            BusEditButton = new Button();
            BusAddButton = new Button();
            BusGridView = new DataGridView();
            BusRoutesPanel = new TabPage();
            ExportRoutesButton = new Button();
            RouteDeleteButton = new Button();
            RouteEditButton = new Button();
            RouteAddButton = new Button();
            RouteGridView = new DataGridView();
            TicketPanel = new TabPage();
            ExportTicketsButton = new Button();
            TicketDeleteButton = new Button();
            TicketEditButton = new Button();
            TicketAddButton = new Button();
            TicketGridView = new DataGridView();
            LogPanel = new TabPage();
            ExportLogsButton = new Button();
            LogGridView = new DataGridView();
            UserView = new TabPage();
            AdminLabel = new Label();
            LogoutButton = new Button();
            UpdateTimer = new System.Windows.Forms.Timer(components);
            LongUpdateTimer = new System.Windows.Forms.Timer(components);
            AdminPanel.SuspendLayout();
            UserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserGridView).BeginInit();
            BusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BusGridView).BeginInit();
            BusRoutesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RouteGridView).BeginInit();
            TicketPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TicketGridView).BeginInit();
            LogPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogGridView).BeginInit();
            SuspendLayout();
            // 
            // AdminPanel
            // 
            AdminPanel.Controls.Add(UserPanel);
            AdminPanel.Controls.Add(BusPanel);
            AdminPanel.Controls.Add(BusRoutesPanel);
            AdminPanel.Controls.Add(TicketPanel);
            AdminPanel.Controls.Add(LogPanel);
            AdminPanel.Controls.Add(UserView);
            AdminPanel.Location = new Point(13, 41);
            AdminPanel.Name = "AdminPanel";
            AdminPanel.SelectedIndex = 0;
            AdminPanel.Size = new Size(776, 396);
            AdminPanel.TabIndex = 0;
            // 
            // UserPanel
            // 
            UserPanel.BackColor = Color.FromArgb(42, 42, 42);
            UserPanel.Controls.Add(ExportUsersButton);
            UserPanel.Controls.Add(UserDeleteButton);
            UserPanel.Controls.Add(UserUpdateButton);
            UserPanel.Controls.Add(UserAddButton);
            UserPanel.Controls.Add(UserGridView);
            UserPanel.ForeColor = Color.Black;
            UserPanel.Location = new Point(4, 24);
            UserPanel.Name = "UserPanel";
            UserPanel.Padding = new Padding(3);
            UserPanel.Size = new Size(768, 368);
            UserPanel.TabIndex = 0;
            UserPanel.Text = "Kullanıcı İşlemleri";
            // 
            // ExportUsersButton
            // 
            ExportUsersButton.BackColor = Color.FromArgb(62, 62, 62);
            ExportUsersButton.FlatAppearance.BorderSize = 0;
            ExportUsersButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 120, 120);
            ExportUsersButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 90, 90);
            ExportUsersButton.FlatStyle = FlatStyle.Flat;
            ExportUsersButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ExportUsersButton.ForeColor = Color.Transparent;
            ExportUsersButton.Location = new Point(645, 334);
            ExportUsersButton.Margin = new Padding(2);
            ExportUsersButton.Name = "ExportUsersButton";
            ExportUsersButton.Size = new Size(114, 23);
            ExportUsersButton.TabIndex = 5;
            ExportUsersButton.Text = "Dışa Aktar";
            ExportUsersButton.UseVisualStyleBackColor = false;
            ExportUsersButton.Click += ExportUsersButton_Click;
            // 
            // UserDeleteButton
            // 
            UserDeleteButton.BackColor = Color.FromArgb(62, 62, 62);
            UserDeleteButton.FlatAppearance.BorderSize = 0;
            UserDeleteButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 120, 120);
            UserDeleteButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 90, 90);
            UserDeleteButton.FlatStyle = FlatStyle.Flat;
            UserDeleteButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            UserDeleteButton.ForeColor = Color.Transparent;
            UserDeleteButton.Location = new Point(645, 95);
            UserDeleteButton.Margin = new Padding(2);
            UserDeleteButton.Name = "UserDeleteButton";
            UserDeleteButton.Size = new Size(114, 23);
            UserDeleteButton.TabIndex = 4;
            UserDeleteButton.Text = "Kullanıcı Sil";
            UserDeleteButton.UseVisualStyleBackColor = false;
            UserDeleteButton.Click += UserDeleteButton_Click;
            // 
            // UserUpdateButton
            // 
            UserUpdateButton.BackColor = Color.FromArgb(62, 62, 62);
            UserUpdateButton.FlatAppearance.BorderSize = 0;
            UserUpdateButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 120, 120);
            UserUpdateButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 90, 90);
            UserUpdateButton.FlatStyle = FlatStyle.Flat;
            UserUpdateButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            UserUpdateButton.ForeColor = Color.Transparent;
            UserUpdateButton.Location = new Point(645, 54);
            UserUpdateButton.Margin = new Padding(2);
            UserUpdateButton.Name = "UserUpdateButton";
            UserUpdateButton.Size = new Size(114, 23);
            UserUpdateButton.TabIndex = 3;
            UserUpdateButton.Text = "Kullanıcı Düzenle";
            UserUpdateButton.UseVisualStyleBackColor = false;
            UserUpdateButton.Click += UserUpdateButton_Click;
            // 
            // UserAddButton
            // 
            UserAddButton.BackColor = Color.FromArgb(62, 62, 62);
            UserAddButton.FlatAppearance.BorderSize = 0;
            UserAddButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 120, 120);
            UserAddButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 90, 90);
            UserAddButton.FlatStyle = FlatStyle.Flat;
            UserAddButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            UserAddButton.ForeColor = Color.Transparent;
            UserAddButton.Location = new Point(645, 14);
            UserAddButton.Margin = new Padding(2);
            UserAddButton.Name = "UserAddButton";
            UserAddButton.Size = new Size(114, 23);
            UserAddButton.TabIndex = 2;
            UserAddButton.Text = "Kullanıcı Ekle";
            UserAddButton.UseVisualStyleBackColor = false;
            UserAddButton.Click += UserAddButton_Click;
            // 
            // UserGridView
            // 
            UserGridView.AllowUserToAddRows = false;
            UserGridView.AllowUserToDeleteRows = false;
            UserGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            UserGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            UserGridView.BackgroundColor = Color.FromArgb(50, 50, 50);
            UserGridView.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ScrollBar;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            UserGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            UserGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ScrollBar;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            UserGridView.DefaultCellStyle = dataGridViewCellStyle2;
            UserGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            UserGridView.Location = new Point(2, 2);
            UserGridView.Margin = new Padding(2);
            UserGridView.MultiSelect = false;
            UserGridView.Name = "UserGridView";
            UserGridView.RowHeadersWidth = 51;
            UserGridView.RowTemplate.Height = 29;
            UserGridView.Size = new Size(630, 365);
            UserGridView.TabIndex = 1;
            UserGridView.SelectionChanged += UserGridView_SelectionChanged;
            // 
            // BusPanel
            // 
            BusPanel.BackColor = Color.FromArgb(42, 42, 42);
            BusPanel.Controls.Add(ExportBussesButton);
            BusPanel.Controls.Add(BusDeleteButton);
            BusPanel.Controls.Add(BusEditButton);
            BusPanel.Controls.Add(BusAddButton);
            BusPanel.Controls.Add(BusGridView);
            BusPanel.Location = new Point(4, 24);
            BusPanel.Name = "BusPanel";
            BusPanel.Padding = new Padding(3);
            BusPanel.Size = new Size(768, 368);
            BusPanel.TabIndex = 1;
            BusPanel.Text = "Otobüs İşlemleri";
            // 
            // ExportBussesButton
            // 
            ExportBussesButton.BackColor = Color.FromArgb(62, 62, 62);
            ExportBussesButton.FlatAppearance.BorderSize = 0;
            ExportBussesButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 120, 120);
            ExportBussesButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 90, 90);
            ExportBussesButton.FlatStyle = FlatStyle.Flat;
            ExportBussesButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ExportBussesButton.ForeColor = Color.Transparent;
            ExportBussesButton.Location = new Point(645, 334);
            ExportBussesButton.Margin = new Padding(2);
            ExportBussesButton.Name = "ExportBussesButton";
            ExportBussesButton.Size = new Size(114, 23);
            ExportBussesButton.TabIndex = 5;
            ExportBussesButton.Text = "Dışa Aktar";
            ExportBussesButton.UseVisualStyleBackColor = false;
            ExportBussesButton.Click += ExportBussesButton_Click;
            // 
            // BusDeleteButton
            // 
            BusDeleteButton.BackColor = Color.FromArgb(62, 62, 62);
            BusDeleteButton.FlatAppearance.BorderSize = 0;
            BusDeleteButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 120, 120);
            BusDeleteButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 90, 90);
            BusDeleteButton.FlatStyle = FlatStyle.Flat;
            BusDeleteButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BusDeleteButton.ForeColor = Color.Transparent;
            BusDeleteButton.Location = new Point(645, 95);
            BusDeleteButton.Margin = new Padding(2);
            BusDeleteButton.Name = "BusDeleteButton";
            BusDeleteButton.Size = new Size(114, 23);
            BusDeleteButton.TabIndex = 4;
            BusDeleteButton.Text = "Otobüs Sil";
            BusDeleteButton.UseVisualStyleBackColor = false;
            BusDeleteButton.Click += BusDeleteButton_Click;
            // 
            // BusEditButton
            // 
            BusEditButton.BackColor = Color.FromArgb(62, 62, 62);
            BusEditButton.FlatAppearance.BorderSize = 0;
            BusEditButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 120, 120);
            BusEditButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 90, 90);
            BusEditButton.FlatStyle = FlatStyle.Flat;
            BusEditButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BusEditButton.ForeColor = Color.Transparent;
            BusEditButton.Location = new Point(645, 54);
            BusEditButton.Margin = new Padding(2);
            BusEditButton.Name = "BusEditButton";
            BusEditButton.Size = new Size(114, 23);
            BusEditButton.TabIndex = 3;
            BusEditButton.Text = "Otobüs Düzenle";
            BusEditButton.UseVisualStyleBackColor = false;
            BusEditButton.Click += BusEditButton_Click;
            // 
            // BusAddButton
            // 
            BusAddButton.BackColor = Color.FromArgb(62, 62, 62);
            BusAddButton.FlatAppearance.BorderSize = 0;
            BusAddButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 120, 120);
            BusAddButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 90, 90);
            BusAddButton.FlatStyle = FlatStyle.Flat;
            BusAddButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BusAddButton.ForeColor = Color.Transparent;
            BusAddButton.Location = new Point(645, 14);
            BusAddButton.Margin = new Padding(2);
            BusAddButton.Name = "BusAddButton";
            BusAddButton.Size = new Size(114, 23);
            BusAddButton.TabIndex = 2;
            BusAddButton.Text = "Otobüs Ekle";
            BusAddButton.UseVisualStyleBackColor = false;
            BusAddButton.Click += BusAddButton_Click;
            // 
            // BusGridView
            // 
            BusGridView.AllowUserToAddRows = false;
            BusGridView.AllowUserToDeleteRows = false;
            BusGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            BusGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            BusGridView.BackgroundColor = Color.FromArgb(50, 50, 50);
            BusGridView.BorderStyle = BorderStyle.None;
            BusGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ScrollBar;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            BusGridView.DefaultCellStyle = dataGridViewCellStyle3;
            BusGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            BusGridView.Location = new Point(2, 2);
            BusGridView.Margin = new Padding(2);
            BusGridView.MultiSelect = false;
            BusGridView.Name = "BusGridView";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.ScrollBar;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            BusGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            BusGridView.RowHeadersWidth = 51;
            BusGridView.RowTemplate.Height = 29;
            BusGridView.Size = new Size(630, 365);
            BusGridView.TabIndex = 1;
            BusGridView.SelectionChanged += BusGridView_SelectionChanged;
            // 
            // BusRoutesPanel
            // 
            BusRoutesPanel.BackColor = Color.FromArgb(42, 42, 42);
            BusRoutesPanel.Controls.Add(ExportRoutesButton);
            BusRoutesPanel.Controls.Add(RouteDeleteButton);
            BusRoutesPanel.Controls.Add(RouteEditButton);
            BusRoutesPanel.Controls.Add(RouteAddButton);
            BusRoutesPanel.Controls.Add(RouteGridView);
            BusRoutesPanel.Location = new Point(4, 24);
            BusRoutesPanel.Name = "BusRoutesPanel";
            BusRoutesPanel.Size = new Size(768, 368);
            BusRoutesPanel.TabIndex = 2;
            BusRoutesPanel.Text = "Rota İşlemleri";
            // 
            // ExportRoutesButton
            // 
            ExportRoutesButton.BackColor = Color.FromArgb(62, 62, 62);
            ExportRoutesButton.FlatAppearance.BorderSize = 0;
            ExportRoutesButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 120, 120);
            ExportRoutesButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 90, 90);
            ExportRoutesButton.FlatStyle = FlatStyle.Flat;
            ExportRoutesButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ExportRoutesButton.ForeColor = Color.Transparent;
            ExportRoutesButton.Location = new Point(645, 334);
            ExportRoutesButton.Margin = new Padding(2);
            ExportRoutesButton.Name = "ExportRoutesButton";
            ExportRoutesButton.Size = new Size(114, 23);
            ExportRoutesButton.TabIndex = 5;
            ExportRoutesButton.Text = "Dışa Aktar";
            ExportRoutesButton.UseVisualStyleBackColor = false;
            ExportRoutesButton.Click += ExportRoutesButton_Click;
            // 
            // RouteDeleteButton
            // 
            RouteDeleteButton.BackColor = Color.FromArgb(62, 62, 62);
            RouteDeleteButton.FlatAppearance.BorderSize = 0;
            RouteDeleteButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 120, 120);
            RouteDeleteButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 90, 90);
            RouteDeleteButton.FlatStyle = FlatStyle.Flat;
            RouteDeleteButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            RouteDeleteButton.ForeColor = Color.Transparent;
            RouteDeleteButton.Location = new Point(645, 95);
            RouteDeleteButton.Margin = new Padding(2);
            RouteDeleteButton.Name = "RouteDeleteButton";
            RouteDeleteButton.Size = new Size(114, 23);
            RouteDeleteButton.TabIndex = 4;
            RouteDeleteButton.Text = "Rota Sil";
            RouteDeleteButton.UseVisualStyleBackColor = false;
            RouteDeleteButton.Click += RouteDeleteButton_Click;
            // 
            // RouteEditButton
            // 
            RouteEditButton.BackColor = Color.FromArgb(62, 62, 62);
            RouteEditButton.FlatAppearance.BorderSize = 0;
            RouteEditButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 120, 120);
            RouteEditButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 90, 90);
            RouteEditButton.FlatStyle = FlatStyle.Flat;
            RouteEditButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            RouteEditButton.ForeColor = Color.Transparent;
            RouteEditButton.Location = new Point(645, 54);
            RouteEditButton.Margin = new Padding(2);
            RouteEditButton.Name = "RouteEditButton";
            RouteEditButton.Size = new Size(114, 23);
            RouteEditButton.TabIndex = 3;
            RouteEditButton.Text = "Rota Düzenle";
            RouteEditButton.UseVisualStyleBackColor = false;
            RouteEditButton.Click += RouteEditButton_Click;
            // 
            // RouteAddButton
            // 
            RouteAddButton.BackColor = Color.FromArgb(62, 62, 62);
            RouteAddButton.FlatAppearance.BorderSize = 0;
            RouteAddButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 120, 120);
            RouteAddButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 90, 90);
            RouteAddButton.FlatStyle = FlatStyle.Flat;
            RouteAddButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            RouteAddButton.ForeColor = Color.Transparent;
            RouteAddButton.Location = new Point(645, 14);
            RouteAddButton.Margin = new Padding(2);
            RouteAddButton.Name = "RouteAddButton";
            RouteAddButton.Size = new Size(114, 23);
            RouteAddButton.TabIndex = 2;
            RouteAddButton.Text = "Rota Ekle";
            RouteAddButton.UseVisualStyleBackColor = false;
            RouteAddButton.Click += RouteAddButton_Click;
            // 
            // RouteGridView
            // 
            RouteGridView.AllowUserToAddRows = false;
            RouteGridView.AllowUserToDeleteRows = false;
            RouteGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            RouteGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            RouteGridView.BackgroundColor = Color.FromArgb(50, 50, 50);
            RouteGridView.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.ScrollBar;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            RouteGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            RouteGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.ScrollBar;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            RouteGridView.DefaultCellStyle = dataGridViewCellStyle6;
            RouteGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            RouteGridView.Location = new Point(2, 2);
            RouteGridView.Margin = new Padding(2);
            RouteGridView.MultiSelect = false;
            RouteGridView.Name = "RouteGridView";
            RouteGridView.RowHeadersWidth = 51;
            RouteGridView.RowTemplate.Height = 29;
            RouteGridView.Size = new Size(630, 365);
            RouteGridView.TabIndex = 1;
            RouteGridView.SelectionChanged += RouteGridView_SelectionChanged;
            // 
            // TicketPanel
            // 
            TicketPanel.BackColor = Color.FromArgb(42, 42, 42);
            TicketPanel.Controls.Add(ExportTicketsButton);
            TicketPanel.Controls.Add(TicketDeleteButton);
            TicketPanel.Controls.Add(TicketEditButton);
            TicketPanel.Controls.Add(TicketAddButton);
            TicketPanel.Controls.Add(TicketGridView);
            TicketPanel.Location = new Point(4, 24);
            TicketPanel.Name = "TicketPanel";
            TicketPanel.Size = new Size(768, 368);
            TicketPanel.TabIndex = 3;
            TicketPanel.Text = "Bilet İşlemleri";
            // 
            // ExportTicketsButton
            // 
            ExportTicketsButton.BackColor = Color.FromArgb(62, 62, 62);
            ExportTicketsButton.FlatAppearance.BorderSize = 0;
            ExportTicketsButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 120, 120);
            ExportTicketsButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 90, 90);
            ExportTicketsButton.FlatStyle = FlatStyle.Flat;
            ExportTicketsButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ExportTicketsButton.ForeColor = Color.Transparent;
            ExportTicketsButton.Location = new Point(645, 334);
            ExportTicketsButton.Margin = new Padding(2);
            ExportTicketsButton.Name = "ExportTicketsButton";
            ExportTicketsButton.Size = new Size(114, 23);
            ExportTicketsButton.TabIndex = 5;
            ExportTicketsButton.Text = "Dışa Aktar";
            ExportTicketsButton.UseVisualStyleBackColor = false;
            ExportTicketsButton.Click += ExportTicketsButton_Click;
            // 
            // TicketDeleteButton
            // 
            TicketDeleteButton.BackColor = Color.FromArgb(62, 62, 62);
            TicketDeleteButton.FlatAppearance.BorderSize = 0;
            TicketDeleteButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 120, 120);
            TicketDeleteButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 90, 90);
            TicketDeleteButton.FlatStyle = FlatStyle.Flat;
            TicketDeleteButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TicketDeleteButton.ForeColor = Color.Transparent;
            TicketDeleteButton.Location = new Point(645, 95);
            TicketDeleteButton.Margin = new Padding(2);
            TicketDeleteButton.Name = "TicketDeleteButton";
            TicketDeleteButton.Size = new Size(114, 23);
            TicketDeleteButton.TabIndex = 4;
            TicketDeleteButton.Text = "Bilet Sil";
            TicketDeleteButton.UseVisualStyleBackColor = false;
            TicketDeleteButton.Click += TicketDeleteButton_Click;
            // 
            // TicketEditButton
            // 
            TicketEditButton.BackColor = Color.FromArgb(62, 62, 62);
            TicketEditButton.FlatAppearance.BorderSize = 0;
            TicketEditButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 120, 120);
            TicketEditButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 90, 90);
            TicketEditButton.FlatStyle = FlatStyle.Flat;
            TicketEditButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TicketEditButton.ForeColor = Color.Transparent;
            TicketEditButton.Location = new Point(645, 54);
            TicketEditButton.Margin = new Padding(2);
            TicketEditButton.Name = "TicketEditButton";
            TicketEditButton.Size = new Size(114, 23);
            TicketEditButton.TabIndex = 3;
            TicketEditButton.Text = "Bilet Düzenle";
            TicketEditButton.UseVisualStyleBackColor = false;
            TicketEditButton.Click += TicketEditButton_Click;
            // 
            // TicketAddButton
            // 
            TicketAddButton.BackColor = Color.FromArgb(62, 62, 62);
            TicketAddButton.FlatAppearance.BorderSize = 0;
            TicketAddButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 120, 120);
            TicketAddButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 90, 90);
            TicketAddButton.FlatStyle = FlatStyle.Flat;
            TicketAddButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TicketAddButton.ForeColor = Color.Transparent;
            TicketAddButton.Location = new Point(645, 14);
            TicketAddButton.Margin = new Padding(2);
            TicketAddButton.Name = "TicketAddButton";
            TicketAddButton.Size = new Size(114, 23);
            TicketAddButton.TabIndex = 2;
            TicketAddButton.Text = "Bilet Ekle";
            TicketAddButton.UseVisualStyleBackColor = false;
            TicketAddButton.Click += TicketAddButton_Click;
            // 
            // TicketGridView
            // 
            TicketGridView.AllowUserToAddRows = false;
            TicketGridView.AllowUserToDeleteRows = false;
            TicketGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            TicketGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            TicketGridView.BackgroundColor = Color.FromArgb(50, 50, 50);
            TicketGridView.BorderStyle = BorderStyle.None;
            TicketGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.ScrollBar;
            dataGridViewCellStyle7.SelectionForeColor = Color.Black;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            TicketGridView.DefaultCellStyle = dataGridViewCellStyle7;
            TicketGridView.Location = new Point(2, 2);
            TicketGridView.Margin = new Padding(2);
            TicketGridView.MultiSelect = false;
            TicketGridView.Name = "TicketGridView";
            TicketGridView.RowHeadersWidth = 51;
            TicketGridView.RowTemplate.Height = 29;
            TicketGridView.Size = new Size(630, 365);
            TicketGridView.TabIndex = 1;
            TicketGridView.SelectionChanged += TicketGridView_SelectionChanged;
            // 
            // LogPanel
            // 
            LogPanel.BackColor = Color.FromArgb(42, 42, 42);
            LogPanel.Controls.Add(ExportLogsButton);
            LogPanel.Controls.Add(LogGridView);
            LogPanel.Location = new Point(4, 24);
            LogPanel.Name = "LogPanel";
            LogPanel.Size = new Size(768, 368);
            LogPanel.TabIndex = 4;
            LogPanel.Text = "Log Görüntüle";
            // 
            // ExportLogsButton
            // 
            ExportLogsButton.BackColor = Color.FromArgb(62, 62, 62);
            ExportLogsButton.FlatAppearance.BorderSize = 0;
            ExportLogsButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 120, 120);
            ExportLogsButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 90, 90);
            ExportLogsButton.FlatStyle = FlatStyle.Flat;
            ExportLogsButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ExportLogsButton.ForeColor = Color.Transparent;
            ExportLogsButton.Location = new Point(645, 334);
            ExportLogsButton.Margin = new Padding(2);
            ExportLogsButton.Name = "ExportLogsButton";
            ExportLogsButton.Size = new Size(114, 23);
            ExportLogsButton.TabIndex = 2;
            ExportLogsButton.Text = "Dışa Aktar";
            ExportLogsButton.UseVisualStyleBackColor = false;
            ExportLogsButton.Click += ExportLogsButton_Click;
            // 
            // LogGridView
            // 
            LogGridView.AllowUserToAddRows = false;
            LogGridView.AllowUserToDeleteRows = false;
            LogGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            LogGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            LogGridView.BackgroundColor = Color.FromArgb(50, 50, 50);
            LogGridView.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.ScrollBar;
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            LogGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            LogGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.White;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.ScrollBar;
            dataGridViewCellStyle9.SelectionForeColor = Color.Black;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            LogGridView.DefaultCellStyle = dataGridViewCellStyle9;
            LogGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            LogGridView.Location = new Point(2, 2);
            LogGridView.Margin = new Padding(2);
            LogGridView.MultiSelect = false;
            LogGridView.Name = "LogGridView";
            LogGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            LogGridView.RowTemplate.Height = 29;
            LogGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LogGridView.Size = new Size(630, 365);
            LogGridView.TabIndex = 1;
            // 
            // UserView
            // 
            UserView.AutoScroll = true;
            UserView.BackColor = Color.FromArgb(42, 42, 42);
            UserView.Location = new Point(4, 24);
            UserView.Name = "UserView";
            UserView.Size = new Size(768, 368);
            UserView.TabIndex = 5;
            UserView.Text = "Kullanıcı Görüşü";
            // 
            // AdminLabel
            // 
            AdminLabel.AutoSize = true;
            AdminLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            AdminLabel.ForeColor = Color.White;
            AdminLabel.Location = new Point(16, 9);
            AdminLabel.Name = "AdminLabel";
            AdminLabel.Size = new Size(297, 20);
            AdminLabel.TabIndex = 6;
            AdminLabel.Text = "Otobüs Bilet Otomasyonu - Admin Paneli";
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
            LogoutButton.Location = new Point(701, 12);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(75, 23);
            LogoutButton.TabIndex = 7;
            LogoutButton.Text = "Çıkış Yap";
            LogoutButton.UseVisualStyleBackColor = false;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // UpdateTimer
            // 
            UpdateTimer.Interval = 10000;
            UpdateTimer.Tick += UpdateTimer_Tick;
            // 
            // LongUpdateTimer
            // 
            LongUpdateTimer.Interval = 300000;
            LongUpdateTimer.Tick += LongUpdateTimer_Tick;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            BackColor = Color.FromArgb(42, 42, 42);
            ClientSize = new Size(800, 450);
            Controls.Add(LogoutButton);
            Controls.Add(AdminLabel);
            Controls.Add(AdminPanel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Paneli";
            FormClosing += Main_FormClosing;
            Load += Main_Load;
            AdminPanel.ResumeLayout(false);
            UserPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)UserGridView).EndInit();
            BusPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BusGridView).EndInit();
            BusRoutesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)RouteGridView).EndInit();
            TicketPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TicketGridView).EndInit();
            LogPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)LogGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl AdminPanel;
        private TabPage UserPanel;
        private TabPage BusPanel;
        private TabPage BusRoutesPanel;
        private TabPage TicketPanel;
        private TabPage LogPanel;
        private TabPage UserView;
        private Label AdminLabel;
        private Button LogoutButton;
        private DataGridView UserGridView;
        private DataGridView BusGridView;
        private DataGridView RouteGridView;
        private DataGridView TicketGridView;
        private DataGridView LogGridView;
        private Button UserDeleteButton;
        private Button UserUpdateButton;
        private Button UserAddButton;
        private Button BusDeleteButton;
        private Button BusEditButton;
        private Button BusAddButton;
        private Button RouteDeleteButton;
        private Button RouteEditButton;
        private Button RouteAddButton;
        private Button TicketDeleteButton;
        private Button TicketEditButton;
        private Button TicketAddButton;
        private System.Windows.Forms.Timer UpdateTimer;
        private Button ExportLogsButton;
        private Button ExportTicketsButton;
        private Button ExportRoutesButton;
        private Button ExportBussesButton;
        private Button ExportUsersButton;
        private System.Windows.Forms.Timer LongUpdateTimer;
    }
}