namespace LibrarySystem
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            // ── Declarations ─────────────────────────────────────────────────
            this.panelHeader      = new System.Windows.Forms.Panel();
            this.lblMainTitle     = new System.Windows.Forms.Label();
            this.lblWelcome       = new System.Windows.Forms.Label();
            this.btnLogout        = new System.Windows.Forms.Button();
            this.panelFooter      = new System.Windows.Forms.Panel();
            this.lblFooter        = new System.Windows.Forms.Label();
            this.tabControl       = new System.Windows.Forms.TabControl();
            this.tabDashboard     = new System.Windows.Forms.TabPage();
            this.tabBooks         = new System.Windows.Forms.TabPage();
            this.tabStudents      = new System.Windows.Forms.TabPage();
            this.tabIssue         = new System.Windows.Forms.TabPage();

            // Dashboard
            this.pnlStatTotalBooks    = new System.Windows.Forms.Panel();
            this.lblStatTotalBooksTitle = new System.Windows.Forms.Label();
            this.lblStatTotalBooks    = new System.Windows.Forms.Label();
            this.pnlStatAvailable     = new System.Windows.Forms.Panel();
            this.lblStatAvailableTitle = new System.Windows.Forms.Label();
            this.lblStatAvailable     = new System.Windows.Forms.Label();
            this.pnlStatStudents      = new System.Windows.Forms.Panel();
            this.lblStatStudentsTitle = new System.Windows.Forms.Label();
            this.lblStatTotalStudents = new System.Windows.Forms.Label();
            this.pnlStatIssued        = new System.Windows.Forms.Panel();
            this.lblStatIssuedTitle   = new System.Windows.Forms.Label();
            this.lblStatIssued        = new System.Windows.Forms.Label();
            this.lblDashWelcome       = new System.Windows.Forms.Label();

            // Books tab
            this.grpBookInput     = new System.Windows.Forms.GroupBox();
            this.lblBookID        = new System.Windows.Forms.Label();
            this.txtBookID        = new System.Windows.Forms.TextBox();
            this.lblBookTitle     = new System.Windows.Forms.Label();
            this.txtBookTitle     = new System.Windows.Forms.TextBox();
            this.lblBookAuthor    = new System.Windows.Forms.Label();
            this.txtBookAuthor    = new System.Windows.Forms.TextBox();
            this.lblBookCat       = new System.Windows.Forms.Label();
            this.cmbBookCategory  = new System.Windows.Forms.ComboBox();
            this.lblBookStatus    = new System.Windows.Forms.Label();
            this.cmbBookStatus    = new System.Windows.Forms.ComboBox();
            this.lblBookYear      = new System.Windows.Forms.Label();
            this.txtBookYear      = new System.Windows.Forms.TextBox();
            this.grpBookActions   = new System.Windows.Forms.GroupBox();
            this.btnAddBook       = new System.Windows.Forms.Button();
            this.btnUpdateBook    = new System.Windows.Forms.Button();
            this.btnDeleteBook    = new System.Windows.Forms.Button();
            this.btnClearBook     = new System.Windows.Forms.Button();
            this.grpBookSearch    = new System.Windows.Forms.GroupBox();
            this.txtSearchBook    = new System.Windows.Forms.TextBox();
            this.btnSearchBook    = new System.Windows.Forms.Button();
            this.btnShowAllBooks  = new System.Windows.Forms.Button();
            this.dgvBooks         = new System.Windows.Forms.DataGridView();
            this.lblBookCount     = new System.Windows.Forms.Label();

            // Students tab
            this.grpStudentInput    = new System.Windows.Forms.GroupBox();
            this.lblStudentID       = new System.Windows.Forms.Label();
            this.txtStudentID       = new System.Windows.Forms.TextBox();
            this.lblStudentName     = new System.Windows.Forms.Label();
            this.txtStudentName     = new System.Windows.Forms.TextBox();
            this.lblStudentClass    = new System.Windows.Forms.Label();
            this.cmbStudentClass    = new System.Windows.Forms.ComboBox();
            this.lblStudentContact  = new System.Windows.Forms.Label();
            this.txtStudentContact  = new System.Windows.Forms.TextBox();
            this.grpStudentActions  = new System.Windows.Forms.GroupBox();
            this.btnAddStudent      = new System.Windows.Forms.Button();
            this.btnUpdateStudent   = new System.Windows.Forms.Button();
            this.btnDeleteStudent   = new System.Windows.Forms.Button();
            this.btnClearStudent    = new System.Windows.Forms.Button();
            this.grpStudentSearch   = new System.Windows.Forms.GroupBox();
            this.txtSearchStudent   = new System.Windows.Forms.TextBox();
            this.btnSearchStudent   = new System.Windows.Forms.Button();
            this.btnShowAllStudents = new System.Windows.Forms.Button();
            this.dgvStudents        = new System.Windows.Forms.DataGridView();
            this.lblStudentCount    = new System.Windows.Forms.Label();

            // Issue/Return tab
            this.grpIssueForm    = new System.Windows.Forms.GroupBox();
            this.lblIssueBook    = new System.Windows.Forms.Label();
            this.cmbIssueBook    = new System.Windows.Forms.ComboBox();
            this.lblIssueStudent = new System.Windows.Forms.Label();
            this.cmbIssueStudent = new System.Windows.Forms.ComboBox();
            this.lblIssueDate    = new System.Windows.Forms.Label();
            this.dtpIssueDate    = new System.Windows.Forms.DateTimePicker();
            this.lblReturnDate   = new System.Windows.Forms.Label();
            this.dtpReturnDate   = new System.Windows.Forms.DateTimePicker();
            this.btnIssueBook    = new System.Windows.Forms.Button();
            this.btnReturnBook   = new System.Windows.Forms.Button();
            this.dgvIssued       = new System.Windows.Forms.DataGridView();
            this.lblIssuedCount  = new System.Windows.Forms.Label();

            this.panelHeader.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabDashboard.SuspendLayout();
            this.tabBooks.SuspendLayout();
            this.tabStudents.SuspendLayout();
            this.tabIssue.SuspendLayout();
            this.grpBookInput.SuspendLayout();
            this.grpBookActions.SuspendLayout();
            this.grpBookSearch.SuspendLayout();
            this.grpStudentInput.SuspendLayout();
            this.grpStudentActions.SuspendLayout();
            this.grpStudentSearch.SuspendLayout();
            this.grpIssueForm.SuspendLayout();
            this.pnlStatTotalBooks.SuspendLayout();
            this.pnlStatAvailable.SuspendLayout();
            this.pnlStatStudents.SuspendLayout();
            this.pnlStatIssued.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssued)).BeginInit();
            this.SuspendLayout();

            // ════════════════════════════════════════════════════════════════
            //  HEADER
            // ════════════════════════════════════════════════════════════════
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(20, 60, 120);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Height = 65;
            this.panelHeader.Controls.Add(this.lblMainTitle);
            this.panelHeader.Controls.Add(this.lblWelcome);
            this.panelHeader.Controls.Add(this.btnLogout);

            this.lblMainTitle.AutoSize = false;
            this.lblMainTitle.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lblMainTitle.ForeColor = System.Drawing.Color.White;
            this.lblMainTitle.Location = new System.Drawing.Point(15, 10);
            this.lblMainTitle.Size = new System.Drawing.Size(600, 35);
            this.lblMainTitle.Text = "LIBRARY MANAGEMENT SYSTEM";
            this.lblMainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.lblWelcome.AutoSize = false;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(170, 210, 255);
            this.lblWelcome.Location = new System.Drawing.Point(15, 44);
            this.lblWelcome.Size = new System.Drawing.Size(300, 16);
            this.lblWelcome.Text = "Logged in as: Admin";

            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(180, 30, 30);
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLogout.Size = new System.Drawing.Size(95, 35);
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnLogout.Location = new System.Drawing.Point(870, 15);
            this.btnLogout.Text = "Logout";
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // ════════════════════════════════════════════════════════════════
            //  FOOTER
            // ════════════════════════════════════════════════════════════════
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(20, 60, 120);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Height = 28;
            this.panelFooter.Controls.Add(this.lblFooter);

            this.lblFooter.AutoSize = false;
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblFooter.ForeColor = System.Drawing.Color.FromArgb(160, 200, 255);
            this.lblFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFooter.Text = "Library Management System  |  Version 1.0  |  Visual Programming CS-412";
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ════════════════════════════════════════════════════════════════
            //  TAB CONTROL
            // ════════════════════════════════════════════════════════════════
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tabControl.ItemSize = new System.Drawing.Size(150, 32);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.Padding = new System.Drawing.Point(10, 5);
            this.tabControl.Controls.Add(this.tabDashboard);
            this.tabControl.Controls.Add(this.tabBooks);
            this.tabControl.Controls.Add(this.tabStudents);
            this.tabControl.Controls.Add(this.tabIssue);

            this.tabDashboard.Text = "  Dashboard";
            this.tabDashboard.BackColor = System.Drawing.Color.FromArgb(245, 248, 255);
            this.tabBooks.Text = "  Books";
            this.tabBooks.BackColor = System.Drawing.Color.FromArgb(245, 248, 255);
            this.tabStudents.Text = "  Students";
            this.tabStudents.BackColor = System.Drawing.Color.FromArgb(245, 248, 255);
            this.tabIssue.Text = "  Issue / Return";
            this.tabIssue.BackColor = System.Drawing.Color.FromArgb(245, 248, 255);

            // ════════════════════════════════════════════════════════════════
            //  TAB 0 – DASHBOARD
            // ════════════════════════════════════════════════════════════════
            this.lblDashWelcome.AutoSize = false;
            this.lblDashWelcome.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblDashWelcome.ForeColor = System.Drawing.Color.FromArgb(20, 60, 120);
            this.lblDashWelcome.Location = new System.Drawing.Point(20, 25);
            this.lblDashWelcome.Size = new System.Drawing.Size(700, 40);
            this.lblDashWelcome.Text = "Dashboard — Quick Statistics";

            // Stat Card: Total Books
            this.pnlStatTotalBooks.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.pnlStatTotalBooks.Location = new System.Drawing.Point(30, 85);
            this.pnlStatTotalBooks.Size = new System.Drawing.Size(200, 110);
            this.pnlStatTotalBooks.Controls.Add(this.lblStatTotalBooksTitle);
            this.pnlStatTotalBooks.Controls.Add(this.lblStatTotalBooks);

            this.lblStatTotalBooksTitle.AutoSize = false;
            this.lblStatTotalBooksTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStatTotalBooksTitle.ForeColor = System.Drawing.Color.White;
            this.lblStatTotalBooksTitle.Location = new System.Drawing.Point(10, 15);
            this.lblStatTotalBooksTitle.Size = new System.Drawing.Size(180, 25);
            this.lblStatTotalBooksTitle.Text = "Total Books";
            this.lblStatTotalBooksTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblStatTotalBooks.AutoSize = false;
            this.lblStatTotalBooks.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.lblStatTotalBooks.ForeColor = System.Drawing.Color.White;
            this.lblStatTotalBooks.Location = new System.Drawing.Point(10, 45);
            this.lblStatTotalBooks.Size = new System.Drawing.Size(180, 55);
            this.lblStatTotalBooks.Text = "0";
            this.lblStatTotalBooks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Stat Card: Available Books
            this.pnlStatAvailable.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.pnlStatAvailable.Location = new System.Drawing.Point(260, 85);
            this.pnlStatAvailable.Size = new System.Drawing.Size(200, 110);
            this.pnlStatAvailable.Controls.Add(this.lblStatAvailableTitle);
            this.pnlStatAvailable.Controls.Add(this.lblStatAvailable);

            this.lblStatAvailableTitle.AutoSize = false;
            this.lblStatAvailableTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStatAvailableTitle.ForeColor = System.Drawing.Color.White;
            this.lblStatAvailableTitle.Location = new System.Drawing.Point(10, 15);
            this.lblStatAvailableTitle.Size = new System.Drawing.Size(180, 25);
            this.lblStatAvailableTitle.Text = "Available Books";
            this.lblStatAvailableTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblStatAvailable.AutoSize = false;
            this.lblStatAvailable.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.lblStatAvailable.ForeColor = System.Drawing.Color.White;
            this.lblStatAvailable.Location = new System.Drawing.Point(10, 45);
            this.lblStatAvailable.Size = new System.Drawing.Size(180, 55);
            this.lblStatAvailable.Text = "0";
            this.lblStatAvailable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Stat Card: Total Students
            this.pnlStatStudents.BackColor = System.Drawing.Color.FromArgb(142, 68, 173);
            this.pnlStatStudents.Location = new System.Drawing.Point(490, 85);
            this.pnlStatStudents.Size = new System.Drawing.Size(200, 110);
            this.pnlStatStudents.Controls.Add(this.lblStatStudentsTitle);
            this.pnlStatStudents.Controls.Add(this.lblStatTotalStudents);

            this.lblStatStudentsTitle.AutoSize = false;
            this.lblStatStudentsTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStatStudentsTitle.ForeColor = System.Drawing.Color.White;
            this.lblStatStudentsTitle.Location = new System.Drawing.Point(10, 15);
            this.lblStatStudentsTitle.Size = new System.Drawing.Size(180, 25);
            this.lblStatStudentsTitle.Text = "Total Students";
            this.lblStatStudentsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblStatTotalStudents.AutoSize = false;
            this.lblStatTotalStudents.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.lblStatTotalStudents.ForeColor = System.Drawing.Color.White;
            this.lblStatTotalStudents.Location = new System.Drawing.Point(10, 45);
            this.lblStatTotalStudents.Size = new System.Drawing.Size(180, 55);
            this.lblStatTotalStudents.Text = "0";
            this.lblStatTotalStudents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Stat Card: Currently Issued
            this.pnlStatIssued.BackColor = System.Drawing.Color.FromArgb(211, 84, 0);
            this.pnlStatIssued.Location = new System.Drawing.Point(720, 85);
            this.pnlStatIssued.Size = new System.Drawing.Size(200, 110);
            this.pnlStatIssued.Controls.Add(this.lblStatIssuedTitle);
            this.pnlStatIssued.Controls.Add(this.lblStatIssued);

            this.lblStatIssuedTitle.AutoSize = false;
            this.lblStatIssuedTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStatIssuedTitle.ForeColor = System.Drawing.Color.White;
            this.lblStatIssuedTitle.Location = new System.Drawing.Point(10, 15);
            this.lblStatIssuedTitle.Size = new System.Drawing.Size(180, 25);
            this.lblStatIssuedTitle.Text = "Currently Issued";
            this.lblStatIssuedTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblStatIssued.AutoSize = false;
            this.lblStatIssued.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.lblStatIssued.ForeColor = System.Drawing.Color.White;
            this.lblStatIssued.Location = new System.Drawing.Point(10, 45);
            this.lblStatIssued.Size = new System.Drawing.Size(180, 55);
            this.lblStatIssued.Text = "0";
            this.lblStatIssued.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.tabDashboard.Controls.Add(this.lblDashWelcome);
            this.tabDashboard.Controls.Add(this.pnlStatTotalBooks);
            this.tabDashboard.Controls.Add(this.pnlStatAvailable);
            this.tabDashboard.Controls.Add(this.pnlStatStudents);
            this.tabDashboard.Controls.Add(this.pnlStatIssued);

            // ════════════════════════════════════════════════════════════════
            //  TAB 1 – BOOKS
            // ════════════════════════════════════════════════════════════════

            // grpBookInput
            this.grpBookInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpBookInput.ForeColor = System.Drawing.Color.FromArgb(20, 60, 120);
            this.grpBookInput.Location = new System.Drawing.Point(10, 10);
            this.grpBookInput.Size = new System.Drawing.Size(500, 205);
            this.grpBookInput.Text = "Book Information";

            this.lblBookID.AutoSize = true;
            this.lblBookID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBookID.ForeColor = System.Drawing.Color.FromArgb(50, 50, 80);
            this.lblBookID.Location = new System.Drawing.Point(12, 28);
            this.lblBookID.Text = "Book Code :";
            this.grpBookInput.Controls.Add(this.lblBookID);

            this.txtBookID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBookID.Location = new System.Drawing.Point(125, 25);
            this.txtBookID.Size = new System.Drawing.Size(140, 23);
            this.txtBookID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grpBookInput.Controls.Add(this.txtBookID);

            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBookTitle.ForeColor = System.Drawing.Color.FromArgb(50, 50, 80);
            this.lblBookTitle.Location = new System.Drawing.Point(12, 58);
            this.lblBookTitle.Text = "Title :";
            this.grpBookInput.Controls.Add(this.lblBookTitle);

            this.txtBookTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBookTitle.Location = new System.Drawing.Point(125, 55);
            this.txtBookTitle.Size = new System.Drawing.Size(360, 23);
            this.txtBookTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grpBookInput.Controls.Add(this.txtBookTitle);

            this.lblBookAuthor.AutoSize = true;
            this.lblBookAuthor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBookAuthor.ForeColor = System.Drawing.Color.FromArgb(50, 50, 80);
            this.lblBookAuthor.Location = new System.Drawing.Point(12, 88);
            this.lblBookAuthor.Text = "Author :";
            this.grpBookInput.Controls.Add(this.lblBookAuthor);

            this.txtBookAuthor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBookAuthor.Location = new System.Drawing.Point(125, 85);
            this.txtBookAuthor.Size = new System.Drawing.Size(360, 23);
            this.txtBookAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grpBookInput.Controls.Add(this.txtBookAuthor);

            this.lblBookCat.AutoSize = true;
            this.lblBookCat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBookCat.ForeColor = System.Drawing.Color.FromArgb(50, 50, 80);
            this.lblBookCat.Location = new System.Drawing.Point(12, 118);
            this.lblBookCat.Text = "Category :";
            this.grpBookInput.Controls.Add(this.lblBookCat);

            this.cmbBookCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbBookCategory.Location = new System.Drawing.Point(125, 115);
            this.cmbBookCategory.Size = new System.Drawing.Size(165, 23);
            this.cmbBookCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBookCategory.Items.AddRange(new object[] { "Religion", "History", "Language", "Technology", "Literature", "Science", "Mathematics", "Fiction", "General", "Other" });
            this.cmbBookCategory.SelectedIndex = 0;
            this.grpBookInput.Controls.Add(this.cmbBookCategory);

            this.lblBookStatus.AutoSize = true;
            this.lblBookStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBookStatus.ForeColor = System.Drawing.Color.FromArgb(50, 50, 80);
            this.lblBookStatus.Location = new System.Drawing.Point(12, 148);
            this.lblBookStatus.Text = "Status :";
            this.grpBookInput.Controls.Add(this.lblBookStatus);

            this.cmbBookStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbBookStatus.Location = new System.Drawing.Point(125, 145);
            this.cmbBookStatus.Size = new System.Drawing.Size(140, 23);
            this.cmbBookStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBookStatus.Items.AddRange(new object[] { "Available", "Issued", "Lost", "Damaged" });
            this.cmbBookStatus.SelectedIndex = 0;
            this.grpBookInput.Controls.Add(this.cmbBookStatus);

            this.lblBookYear.AutoSize = true;
            this.lblBookYear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBookYear.ForeColor = System.Drawing.Color.FromArgb(50, 50, 80);
            this.lblBookYear.Location = new System.Drawing.Point(310, 148);
            this.lblBookYear.Text = "Year :";
            this.grpBookInput.Controls.Add(this.lblBookYear);

            this.txtBookYear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBookYear.Location = new System.Drawing.Point(360, 145);
            this.txtBookYear.Size = new System.Drawing.Size(80, 23);
            this.txtBookYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grpBookInput.Controls.Add(this.txtBookYear);

            // grpBookActions
            this.grpBookActions.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpBookActions.ForeColor = System.Drawing.Color.FromArgb(20, 60, 120);
            this.grpBookActions.Location = new System.Drawing.Point(520, 10);
            this.grpBookActions.Size = new System.Drawing.Size(430, 205);
            this.grpBookActions.Text = "Actions";

            this.btnAddBook.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBook.FlatAppearance.BorderSize = 0;
            this.btnAddBook.ForeColor = System.Drawing.Color.White;
            this.btnAddBook.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddBook.Location = new System.Drawing.Point(20, 30);
            this.btnAddBook.Size = new System.Drawing.Size(180, 40);
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            this.grpBookActions.Controls.Add(this.btnAddBook);

            this.btnUpdateBook.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.btnUpdateBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateBook.FlatAppearance.BorderSize = 0;
            this.btnUpdateBook.ForeColor = System.Drawing.Color.White;
            this.btnUpdateBook.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdateBook.Location = new System.Drawing.Point(220, 30);
            this.btnUpdateBook.Size = new System.Drawing.Size(180, 40);
            this.btnUpdateBook.Text = "Update Book";
            this.btnUpdateBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            this.grpBookActions.Controls.Add(this.btnUpdateBook);

            this.btnDeleteBook.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnDeleteBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteBook.FlatAppearance.BorderSize = 0;
            this.btnDeleteBook.ForeColor = System.Drawing.Color.White;
            this.btnDeleteBook.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeleteBook.Location = new System.Drawing.Point(20, 85);
            this.btnDeleteBook.Size = new System.Drawing.Size(180, 40);
            this.btnDeleteBook.Text = "Delete Book";
            this.btnDeleteBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            this.grpBookActions.Controls.Add(this.btnDeleteBook);

            this.btnClearBook.BackColor = System.Drawing.Color.FromArgb(127, 140, 141);
            this.btnClearBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearBook.FlatAppearance.BorderSize = 0;
            this.btnClearBook.ForeColor = System.Drawing.Color.White;
            this.btnClearBook.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClearBook.Location = new System.Drawing.Point(220, 85);
            this.btnClearBook.Size = new System.Drawing.Size(180, 40);
            this.btnClearBook.Text = "Clear Fields";
            this.btnClearBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearBook.Click += new System.EventHandler(this.btnClearBook_Click);
            this.grpBookActions.Controls.Add(this.btnClearBook);

            // grpBookSearch
            this.grpBookSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpBookSearch.ForeColor = System.Drawing.Color.FromArgb(20, 60, 120);
            this.grpBookSearch.Location = new System.Drawing.Point(10, 225);
            this.grpBookSearch.Size = new System.Drawing.Size(940, 55);
            this.grpBookSearch.Text = "Search Books";

            this.txtSearchBook.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchBook.Location = new System.Drawing.Point(12, 20);
            this.txtSearchBook.Size = new System.Drawing.Size(380, 23);
            this.txtSearchBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grpBookSearch.Controls.Add(this.txtSearchBook);

            this.btnSearchBook.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.btnSearchBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchBook.FlatAppearance.BorderSize = 0;
            this.btnSearchBook.ForeColor = System.Drawing.Color.White;
            this.btnSearchBook.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSearchBook.Location = new System.Drawing.Point(405, 17);
            this.btnSearchBook.Size = new System.Drawing.Size(100, 28);
            this.btnSearchBook.Text = "Search";
            this.btnSearchBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
            this.grpBookSearch.Controls.Add(this.btnSearchBook);

            this.btnShowAllBooks.BackColor = System.Drawing.Color.FromArgb(22, 160, 133);
            this.btnShowAllBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAllBooks.FlatAppearance.BorderSize = 0;
            this.btnShowAllBooks.ForeColor = System.Drawing.Color.White;
            this.btnShowAllBooks.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnShowAllBooks.Location = new System.Drawing.Point(515, 17);
            this.btnShowAllBooks.Size = new System.Drawing.Size(100, 28);
            this.btnShowAllBooks.Text = "Show All";
            this.btnShowAllBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowAllBooks.Click += new System.EventHandler(this.btnShowAllBooks_Click);
            this.grpBookSearch.Controls.Add(this.btnShowAllBooks);

            // dgvBooks
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.BackgroundColor = System.Drawing.Color.White;
            this.dgvBooks.RowHeadersVisible = false;
            this.dgvBooks.MultiSelect = false;
            this.dgvBooks.Location = new System.Drawing.Point(10, 290);
            this.dgvBooks.Size = new System.Drawing.Size(940, 310);
            this.dgvBooks.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;
            this.dgvBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_CellClick);

            this.lblBookCount.AutoSize = true;
            this.lblBookCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblBookCount.ForeColor = System.Drawing.Color.FromArgb(20, 60, 120);
            this.lblBookCount.Location = new System.Drawing.Point(10, 608);
            this.lblBookCount.Text = "Total Books: 0";

            this.tabBooks.Controls.Add(this.grpBookInput);
            this.tabBooks.Controls.Add(this.grpBookActions);
            this.tabBooks.Controls.Add(this.grpBookSearch);
            this.tabBooks.Controls.Add(this.dgvBooks);
            this.tabBooks.Controls.Add(this.lblBookCount);

            // ════════════════════════════════════════════════════════════════
            //  TAB 2 – STUDENTS
            // ════════════════════════════════════════════════════════════════

            this.grpStudentInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpStudentInput.ForeColor = System.Drawing.Color.FromArgb(20, 60, 120);
            this.grpStudentInput.Location = new System.Drawing.Point(10, 10);
            this.grpStudentInput.Size = new System.Drawing.Size(500, 165);
            this.grpStudentInput.Text = "Student Information";

            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStudentID.ForeColor = System.Drawing.Color.FromArgb(50, 50, 80);
            this.lblStudentID.Location = new System.Drawing.Point(12, 28);
            this.lblStudentID.Text = "Student Code :";
            this.grpStudentInput.Controls.Add(this.lblStudentID);

            this.txtStudentID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtStudentID.Location = new System.Drawing.Point(130, 25);
            this.txtStudentID.Size = new System.Drawing.Size(140, 23);
            this.txtStudentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grpStudentInput.Controls.Add(this.txtStudentID);

            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStudentName.ForeColor = System.Drawing.Color.FromArgb(50, 50, 80);
            this.lblStudentName.Location = new System.Drawing.Point(12, 58);
            this.lblStudentName.Text = "Full Name :";
            this.grpStudentInput.Controls.Add(this.lblStudentName);

            this.txtStudentName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtStudentName.Location = new System.Drawing.Point(130, 55);
            this.txtStudentName.Size = new System.Drawing.Size(300, 23);
            this.txtStudentName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grpStudentInput.Controls.Add(this.txtStudentName);

            this.lblStudentClass.AutoSize = true;
            this.lblStudentClass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStudentClass.ForeColor = System.Drawing.Color.FromArgb(50, 50, 80);
            this.lblStudentClass.Location = new System.Drawing.Point(12, 88);
            this.lblStudentClass.Text = "Class :";
            this.grpStudentInput.Controls.Add(this.lblStudentClass);

            this.cmbStudentClass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbStudentClass.Location = new System.Drawing.Point(130, 85);
            this.cmbStudentClass.Size = new System.Drawing.Size(140, 23);
            this.cmbStudentClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStudentClass.Items.AddRange(new object[] { "6th", "7th", "8th", "9th A", "9th B", "10th A", "10th B", "11th", "12th" });
            this.cmbStudentClass.SelectedIndex = 0;
            this.grpStudentInput.Controls.Add(this.cmbStudentClass);

            this.lblStudentContact.AutoSize = true;
            this.lblStudentContact.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStudentContact.ForeColor = System.Drawing.Color.FromArgb(50, 50, 80);
            this.lblStudentContact.Location = new System.Drawing.Point(12, 118);
            this.lblStudentContact.Text = "Contact :";
            this.grpStudentInput.Controls.Add(this.lblStudentContact);

            this.txtStudentContact.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtStudentContact.Location = new System.Drawing.Point(130, 115);
            this.txtStudentContact.Size = new System.Drawing.Size(200, 23);
            this.txtStudentContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grpStudentInput.Controls.Add(this.txtStudentContact);

            this.grpStudentActions.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpStudentActions.ForeColor = System.Drawing.Color.FromArgb(20, 60, 120);
            this.grpStudentActions.Location = new System.Drawing.Point(520, 10);
            this.grpStudentActions.Size = new System.Drawing.Size(430, 165);
            this.grpStudentActions.Text = "Actions";

            this.btnAddStudent.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudent.FlatAppearance.BorderSize = 0;
            this.btnAddStudent.ForeColor = System.Drawing.Color.White;
            this.btnAddStudent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddStudent.Location = new System.Drawing.Point(20, 30);
            this.btnAddStudent.Size = new System.Drawing.Size(180, 40);
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            this.grpStudentActions.Controls.Add(this.btnAddStudent);

            this.btnUpdateStudent.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.btnUpdateStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStudent.FlatAppearance.BorderSize = 0;
            this.btnUpdateStudent.ForeColor = System.Drawing.Color.White;
            this.btnUpdateStudent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdateStudent.Location = new System.Drawing.Point(220, 30);
            this.btnUpdateStudent.Size = new System.Drawing.Size(180, 40);
            this.btnUpdateStudent.Text = "Update Student";
            this.btnUpdateStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateStudent_Click);
            this.grpStudentActions.Controls.Add(this.btnUpdateStudent);

            this.btnDeleteStudent.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnDeleteStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStudent.FlatAppearance.BorderSize = 0;
            this.btnDeleteStudent.ForeColor = System.Drawing.Color.White;
            this.btnDeleteStudent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeleteStudent.Location = new System.Drawing.Point(20, 85);
            this.btnDeleteStudent.Size = new System.Drawing.Size(180, 40);
            this.btnDeleteStudent.Text = "Delete Student";
            this.btnDeleteStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            this.grpStudentActions.Controls.Add(this.btnDeleteStudent);

            this.btnClearStudent.BackColor = System.Drawing.Color.FromArgb(127, 140, 141);
            this.btnClearStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearStudent.FlatAppearance.BorderSize = 0;
            this.btnClearStudent.ForeColor = System.Drawing.Color.White;
            this.btnClearStudent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClearStudent.Location = new System.Drawing.Point(220, 85);
            this.btnClearStudent.Size = new System.Drawing.Size(180, 40);
            this.btnClearStudent.Text = "Clear Fields";
            this.btnClearStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearStudent.Click += new System.EventHandler(this.btnClearStudent_Click);
            this.grpStudentActions.Controls.Add(this.btnClearStudent);

            this.grpStudentSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpStudentSearch.ForeColor = System.Drawing.Color.FromArgb(20, 60, 120);
            this.grpStudentSearch.Location = new System.Drawing.Point(10, 185);
            this.grpStudentSearch.Size = new System.Drawing.Size(940, 55);
            this.grpStudentSearch.Text = "Search Students";

            this.txtSearchStudent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchStudent.Location = new System.Drawing.Point(12, 20);
            this.txtSearchStudent.Size = new System.Drawing.Size(380, 23);
            this.txtSearchStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grpStudentSearch.Controls.Add(this.txtSearchStudent);

            this.btnSearchStudent.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.btnSearchStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchStudent.FlatAppearance.BorderSize = 0;
            this.btnSearchStudent.ForeColor = System.Drawing.Color.White;
            this.btnSearchStudent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSearchStudent.Location = new System.Drawing.Point(405, 17);
            this.btnSearchStudent.Size = new System.Drawing.Size(100, 28);
            this.btnSearchStudent.Text = "Search";
            this.btnSearchStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);
            this.grpStudentSearch.Controls.Add(this.btnSearchStudent);

            this.btnShowAllStudents.BackColor = System.Drawing.Color.FromArgb(22, 160, 133);
            this.btnShowAllStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAllStudents.FlatAppearance.BorderSize = 0;
            this.btnShowAllStudents.ForeColor = System.Drawing.Color.White;
            this.btnShowAllStudents.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnShowAllStudents.Location = new System.Drawing.Point(515, 17);
            this.btnShowAllStudents.Size = new System.Drawing.Size(100, 28);
            this.btnShowAllStudents.Text = "Show All";
            this.btnShowAllStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowAllStudents.Click += new System.EventHandler(this.btnShowAllStudents_Click);
            this.grpStudentSearch.Controls.Add(this.btnShowAllStudents);

            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.BackgroundColor = System.Drawing.Color.White;
            this.dgvStudents.RowHeadersVisible = false;
            this.dgvStudents.MultiSelect = false;
            this.dgvStudents.Location = new System.Drawing.Point(10, 250);
            this.dgvStudents.Size = new System.Drawing.Size(940, 350);
            this.dgvStudents.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;
            this.dgvStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellClick);

            this.lblStudentCount.AutoSize = true;
            this.lblStudentCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStudentCount.ForeColor = System.Drawing.Color.FromArgb(20, 60, 120);
            this.lblStudentCount.Location = new System.Drawing.Point(10, 608);
            this.lblStudentCount.Text = "Total Students: 0";

            this.tabStudents.Controls.Add(this.grpStudentInput);
            this.tabStudents.Controls.Add(this.grpStudentActions);
            this.tabStudents.Controls.Add(this.grpStudentSearch);
            this.tabStudents.Controls.Add(this.dgvStudents);
            this.tabStudents.Controls.Add(this.lblStudentCount);

            // ════════════════════════════════════════════════════════════════
            //  TAB 3 – ISSUE / RETURN
            // ════════════════════════════════════════════════════════════════

            this.grpIssueForm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpIssueForm.ForeColor = System.Drawing.Color.FromArgb(20, 60, 120);
            this.grpIssueForm.Location = new System.Drawing.Point(10, 10);
            this.grpIssueForm.Size = new System.Drawing.Size(940, 160);
            this.grpIssueForm.Text = "Issue Book to Student";

            this.lblIssueBook.AutoSize = true;
            this.lblIssueBook.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblIssueBook.ForeColor = System.Drawing.Color.FromArgb(50, 50, 80);
            this.lblIssueBook.Location = new System.Drawing.Point(12, 32);
            this.lblIssueBook.Text = "Select Book :";
            this.grpIssueForm.Controls.Add(this.lblIssueBook);

            this.cmbIssueBook.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbIssueBook.Location = new System.Drawing.Point(130, 29);
            this.cmbIssueBook.Size = new System.Drawing.Size(350, 23);
            this.cmbIssueBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.grpIssueForm.Controls.Add(this.cmbIssueBook);

            this.lblIssueStudent.AutoSize = true;
            this.lblIssueStudent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblIssueStudent.ForeColor = System.Drawing.Color.FromArgb(50, 50, 80);
            this.lblIssueStudent.Location = new System.Drawing.Point(12, 68);
            this.lblIssueStudent.Text = "Select Student :";
            this.grpIssueForm.Controls.Add(this.lblIssueStudent);

            this.cmbIssueStudent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbIssueStudent.Location = new System.Drawing.Point(130, 65);
            this.cmbIssueStudent.Size = new System.Drawing.Size(350, 23);
            this.cmbIssueStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.grpIssueForm.Controls.Add(this.cmbIssueStudent);

            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblIssueDate.ForeColor = System.Drawing.Color.FromArgb(50, 50, 80);
            this.lblIssueDate.Location = new System.Drawing.Point(510, 32);
            this.lblIssueDate.Text = "Issue Date :";
            this.grpIssueForm.Controls.Add(this.lblIssueDate);

            this.dtpIssueDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpIssueDate.Location = new System.Drawing.Point(620, 29);
            this.dtpIssueDate.Size = new System.Drawing.Size(170, 23);
            this.dtpIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.grpIssueForm.Controls.Add(this.dtpIssueDate);

            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblReturnDate.ForeColor = System.Drawing.Color.FromArgb(50, 50, 80);
            this.lblReturnDate.Location = new System.Drawing.Point(510, 68);
            this.lblReturnDate.Text = "Return Date :";
            this.grpIssueForm.Controls.Add(this.lblReturnDate);

            this.dtpReturnDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpReturnDate.Location = new System.Drawing.Point(620, 65);
            this.dtpReturnDate.Size = new System.Drawing.Size(170, 23);
            this.dtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReturnDate.Value = System.DateTime.Now.AddDays(14);
            this.grpIssueForm.Controls.Add(this.dtpReturnDate);

            this.btnIssueBook.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnIssueBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssueBook.FlatAppearance.BorderSize = 0;
            this.btnIssueBook.ForeColor = System.Drawing.Color.White;
            this.btnIssueBook.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnIssueBook.Location = new System.Drawing.Point(130, 108);
            this.btnIssueBook.Size = new System.Drawing.Size(170, 38);
            this.btnIssueBook.Text = "Issue Book";
            this.btnIssueBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIssueBook.Click += new System.EventHandler(this.btnIssueBook_Click);
            this.grpIssueForm.Controls.Add(this.btnIssueBook);

            this.btnReturnBook.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnReturnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnBook.FlatAppearance.BorderSize = 0;
            this.btnReturnBook.ForeColor = System.Drawing.Color.White;
            this.btnReturnBook.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnReturnBook.Location = new System.Drawing.Point(320, 108);
            this.btnReturnBook.Size = new System.Drawing.Size(170, 38);
            this.btnReturnBook.Text = "Return Book";
            this.btnReturnBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            this.grpIssueForm.Controls.Add(this.btnReturnBook);

            this.dgvIssued.AllowUserToAddRows = false;
            this.dgvIssued.AllowUserToDeleteRows = false;
            this.dgvIssued.ReadOnly = true;
            this.dgvIssued.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIssued.BackgroundColor = System.Drawing.Color.White;
            this.dgvIssued.RowHeadersVisible = false;
            this.dgvIssued.MultiSelect = false;
            this.dgvIssued.Location = new System.Drawing.Point(10, 180);
            this.dgvIssued.Size = new System.Drawing.Size(940, 415);
            this.dgvIssued.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;
            this.dgvIssued.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIssued_CellClick);

            this.lblIssuedCount.AutoSize = true;
            this.lblIssuedCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblIssuedCount.ForeColor = System.Drawing.Color.FromArgb(20, 60, 120);
            this.lblIssuedCount.Location = new System.Drawing.Point(10, 603);
            this.lblIssuedCount.Text = "Total Records: 0";

            this.tabIssue.Controls.Add(this.grpIssueForm);
            this.tabIssue.Controls.Add(this.dgvIssued);
            this.tabIssue.Controls.Add(this.lblIssuedCount);

            // ════════════════════════════════════════════════════════════════
            //  MAIN FORM
            // ════════════════════════════════════════════════════════════════
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(235, 242, 255);
            this.ClientSize = new System.Drawing.Size(980, 720);
            this.MinimumSize = new System.Drawing.Size(980, 720);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelFooter);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);

            this.panelHeader.ResumeLayout(false);
            this.panelFooter.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabDashboard.ResumeLayout(false);
            this.tabBooks.ResumeLayout(false);
            this.tabBooks.PerformLayout();
            this.tabStudents.ResumeLayout(false);
            this.tabStudents.PerformLayout();
            this.tabIssue.ResumeLayout(false);
            this.tabIssue.PerformLayout();
            this.grpBookInput.ResumeLayout(false);
            this.grpBookInput.PerformLayout();
            this.grpBookActions.ResumeLayout(false);
            this.grpBookSearch.ResumeLayout(false);
            this.grpBookSearch.PerformLayout();
            this.grpStudentInput.ResumeLayout(false);
            this.grpStudentInput.PerformLayout();
            this.grpStudentActions.ResumeLayout(false);
            this.grpStudentSearch.ResumeLayout(false);
            this.grpStudentSearch.PerformLayout();
            this.grpIssueForm.ResumeLayout(false);
            this.grpIssueForm.PerformLayout();
            this.pnlStatTotalBooks.ResumeLayout(false);
            this.pnlStatAvailable.ResumeLayout(false);
            this.pnlStatStudents.ResumeLayout(false);
            this.pnlStatIssued.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssued)).EndInit();
            this.ResumeLayout(false);
        }

        // ── Field Declarations ────────────────────────────────────────────────
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabDashboard;
        private System.Windows.Forms.TabPage tabBooks;
        private System.Windows.Forms.TabPage tabStudents;
        private System.Windows.Forms.TabPage tabIssue;

        private System.Windows.Forms.Panel pnlStatTotalBooks;
        private System.Windows.Forms.Label lblStatTotalBooksTitle;
        private System.Windows.Forms.Label lblStatTotalBooks;
        private System.Windows.Forms.Panel pnlStatAvailable;
        private System.Windows.Forms.Label lblStatAvailableTitle;
        private System.Windows.Forms.Label lblStatAvailable;
        private System.Windows.Forms.Panel pnlStatStudents;
        private System.Windows.Forms.Label lblStatStudentsTitle;
        private System.Windows.Forms.Label lblStatTotalStudents;
        private System.Windows.Forms.Panel pnlStatIssued;
        private System.Windows.Forms.Label lblStatIssuedTitle;
        private System.Windows.Forms.Label lblStatIssued;
        private System.Windows.Forms.Label lblDashWelcome;

        private System.Windows.Forms.GroupBox grpBookInput;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.Label lblBookAuthor;
        private System.Windows.Forms.TextBox txtBookAuthor;
        private System.Windows.Forms.Label lblBookCat;
        private System.Windows.Forms.ComboBox cmbBookCategory;
        private System.Windows.Forms.Label lblBookStatus;
        private System.Windows.Forms.ComboBox cmbBookStatus;
        private System.Windows.Forms.Label lblBookYear;
        private System.Windows.Forms.TextBox txtBookYear;
        private System.Windows.Forms.GroupBox grpBookActions;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnClearBook;
        private System.Windows.Forms.GroupBox grpBookSearch;
        private System.Windows.Forms.TextBox txtSearchBook;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.Button btnShowAllBooks;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Label lblBookCount;

        private System.Windows.Forms.GroupBox grpStudentInput;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblStudentClass;
        private System.Windows.Forms.ComboBox cmbStudentClass;
        private System.Windows.Forms.Label lblStudentContact;
        private System.Windows.Forms.TextBox txtStudentContact;
        private System.Windows.Forms.GroupBox grpStudentActions;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnUpdateStudent;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnClearStudent;
        private System.Windows.Forms.GroupBox grpStudentSearch;
        private System.Windows.Forms.TextBox txtSearchStudent;
        private System.Windows.Forms.Button btnSearchStudent;
        private System.Windows.Forms.Button btnShowAllStudents;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Label lblStudentCount;

        private System.Windows.Forms.GroupBox grpIssueForm;
        private System.Windows.Forms.Label lblIssueBook;
        private System.Windows.Forms.ComboBox cmbIssueBook;
        private System.Windows.Forms.Label lblIssueStudent;
        private System.Windows.Forms.ComboBox cmbIssueStudent;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.DateTimePicker dtpIssueDate;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.Button btnIssueBook;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.DataGridView dgvIssued;
        private System.Windows.Forms.Label lblIssuedCount;
    }
}
