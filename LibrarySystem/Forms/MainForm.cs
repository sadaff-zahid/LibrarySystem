using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using LibrarySystem.Database;

namespace LibrarySystem
{
    /// <summary>
    /// Main application form containing three tabs:
    /// Books, Students, and Issue/Return.
    /// All data operations go through DatabaseHelper (DAL).
    /// </summary>
    public partial class MainForm : Form
    {
        // Currently logged-in username (passed from LoginForm)
        private readonly string loggedInUser;

        // Holds the selected database IDs when a grid row is clicked
        private int selectedBookId    = -1;
        private int selectedStudentId = -1;
        private int selectedIssueId   = -1;
        private int selectedIssueBookId = -1;

        public MainForm(string username)
        {
            InitializeComponent();
            loggedInUser = username;
            lblWelcome.Text = "Logged in as: " + username;
        }

        // Load all grids when the form first appears
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadDashboard();
            LoadBooksGrid();
            LoadStudentsGrid();
            LoadIssueGrid();
            LoadIssueDropdowns();
        }

        // ── Dashboard ────────────────────────────────────────────────────────
        /// <summary>Refreshes the four dashboard statistic labels.</summary>
        private void LoadDashboard()
        {
            try
            {
                lblStatTotalBooks.Text     = DatabaseHelper.GetTotalBooks().ToString();
                lblStatAvailable.Text      = DatabaseHelper.GetAvailableBookCount().ToString();
                lblStatTotalStudents.Text  = DatabaseHelper.GetTotalStudents().ToString();
                lblStatIssued.Text         = DatabaseHelper.GetCurrentlyIssuedCount().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dashboard error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ════════════════════════════════════════════════════════════════════
        //  TAB 1 – BOOKS
        // ════════════════════════════════════════════════════════════════════

        /// <summary>Loads book records from DB into dgvBooks.</summary>
        private void LoadBooksGrid(string keyword = "")
        {
            try
            {
                DataTable dt = DatabaseHelper.GetBooks(keyword);
                dgvBooks.DataSource = dt;
                StyleGrid(dgvBooks);
                // Hide internal ID column from user
                if (dgvBooks.Columns["book_id"] != null)
                    dgvBooks.Columns["book_id"].Visible = false;
                lblBookCount.Text = "Total Books: " + dt.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading books: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Add new book to database
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (txtBookID.Text.Trim() == "" || txtBookTitle.Text.Trim() == "" || txtBookAuthor.Text.Trim() == "")
            {
                MessageBox.Show("Book Code, Title and Author are required!", "Missing Fields",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                // Check for duplicate book code
                if (DatabaseHelper.BookCodeExists(txtBookID.Text.Trim()))
                {
                    MessageBox.Show("Book Code already exists! Use a different code.", "Duplicate",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DatabaseHelper.AddBook(txtBookID.Text.Trim(), txtBookTitle.Text.Trim(),
                    txtBookAuthor.Text.Trim(), cmbBookCategory.Text, cmbBookStatus.Text, txtBookYear.Text.Trim());
                MessageBox.Show("Book added successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearBookFields();
                LoadBooksGrid();
                LoadDashboard();
                LoadIssueDropdowns();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding book: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Update selected book in database
        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            if (selectedBookId == -1)
            {
                MessageBox.Show("Please click a book row first to select it!", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtBookTitle.Text.Trim() == "")
            {
                MessageBox.Show("Title cannot be empty!", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                DatabaseHelper.UpdateBook(selectedBookId, txtBookTitle.Text.Trim(),
                    txtBookAuthor.Text.Trim(), cmbBookCategory.Text, cmbBookStatus.Text, txtBookYear.Text.Trim());
                MessageBox.Show("Book updated successfully!", "Updated",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearBookFields();
                LoadBooksGrid();
                LoadDashboard();
                LoadIssueDropdowns();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating book: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Soft-delete selected book (sets is_deleted=1, keeps data in DB)
        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (selectedBookId == -1)
            {
                MessageBox.Show("Please click a book row first to select it!", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dr = MessageBox.Show("Are you sure you want to delete this book?\n(Record will be soft-deleted and kept in database)",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    DatabaseHelper.DeleteBook(selectedBookId);
                    MessageBox.Show("Book deleted!", "Deleted",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearBookFields();
                    LoadBooksGrid();
                    LoadDashboard();
                    LoadIssueDropdowns();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting book: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Search books by keyword
        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            LoadBooksGrid(txtSearchBook.Text.Trim());
        }

        // Show all books (clear search)
        private void btnShowAllBooks_Click(object sender, EventArgs e)
        {
            txtSearchBook.Clear();
            LoadBooksGrid();
        }

        // Clear all book input fields and reset selection
        private void btnClearBook_Click(object sender, EventArgs e) { ClearBookFields(); }

        // When user clicks a row in dgvBooks, fill input fields
        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvBooks.Rows[e.RowIndex];
            // Store the hidden book_id for update/delete operations
            selectedBookId       = Convert.ToInt32(row.Cells["book_id"].Value);
            txtBookID.Text       = row.Cells["book_code"].Value != null ? row.Cells["book_code"].Value.ToString() : "";
            txtBookTitle.Text    = row.Cells["title"].Value     != null ? row.Cells["title"].Value.ToString()     : "";
            txtBookAuthor.Text   = row.Cells["author"].Value    != null ? row.Cells["author"].Value.ToString()    : "";
            cmbBookCategory.Text = row.Cells["category"].Value  != null ? row.Cells["category"].Value.ToString()  : "";
            cmbBookStatus.Text   = row.Cells["status"].Value    != null ? row.Cells["status"].Value.ToString()    : "";
            txtBookYear.Text     = row.Cells["year"].Value      != null ? row.Cells["year"].Value.ToString()      : "";
            // Book code should not be editable after creation
            txtBookID.ReadOnly = true;
        }

        private void ClearBookFields()
        {
            selectedBookId = -1;
            txtBookID.Clear();
            txtBookID.ReadOnly = false;
            txtBookTitle.Clear();
            txtBookAuthor.Clear();
            txtBookYear.Clear();
            txtSearchBook.Clear();
            cmbBookCategory.SelectedIndex = 0;
            cmbBookStatus.SelectedIndex   = 0;
        }

        // ════════════════════════════════════════════════════════════════════
        //  TAB 2 – STUDENTS
        // ════════════════════════════════════════════════════════════════════

        /// <summary>Loads student records from DB into dgvStudents.</summary>
        private void LoadStudentsGrid(string keyword = "")
        {
            try
            {
                DataTable dt = DatabaseHelper.GetStudents(keyword);
                dgvStudents.DataSource = dt;
                StyleGrid(dgvStudents);
                if (dgvStudents.Columns["student_id"] != null)
                    dgvStudents.Columns["student_id"].Visible = false;
                lblStudentCount.Text = "Total Students: " + dt.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading students: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (txtStudentID.Text.Trim() == "" || txtStudentName.Text.Trim() == "")
            {
                MessageBox.Show("Student Code and Name are required!", "Missing Fields",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (DatabaseHelper.StudentCodeExists(txtStudentID.Text.Trim()))
                {
                    MessageBox.Show("Student Code already exists!", "Duplicate",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DatabaseHelper.AddStudent(txtStudentID.Text.Trim(), txtStudentName.Text.Trim(),
                    cmbStudentClass.Text, txtStudentContact.Text.Trim());
                MessageBox.Show("Student added successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearStudentFields();
                LoadStudentsGrid();
                LoadDashboard();
                LoadIssueDropdowns();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding student: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            if (selectedStudentId == -1)
            {
                MessageBox.Show("Please click a student row first!", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                DatabaseHelper.UpdateStudent(selectedStudentId, txtStudentName.Text.Trim(),
                    cmbStudentClass.Text, txtStudentContact.Text.Trim());
                MessageBox.Show("Student updated!", "Updated",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearStudentFields();
                LoadStudentsGrid();
                LoadIssueDropdowns();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating student: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (selectedStudentId == -1)
            {
                MessageBox.Show("Please click a student row first!", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dr = MessageBox.Show("Delete this student? (Soft delete — data kept in DB)",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    DatabaseHelper.DeleteStudent(selectedStudentId);
                    MessageBox.Show("Student deleted!", "Deleted",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearStudentFields();
                    LoadStudentsGrid();
                    LoadDashboard();
                    LoadIssueDropdowns();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting student: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            LoadStudentsGrid(txtSearchStudent.Text.Trim());
        }

        private void btnShowAllStudents_Click(object sender, EventArgs e)
        {
            txtSearchStudent.Clear();
            LoadStudentsGrid();
        }

        private void btnClearStudent_Click(object sender, EventArgs e) { ClearStudentFields(); }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvStudents.Rows[e.RowIndex];
            selectedStudentId      = Convert.ToInt32(row.Cells["student_id"].Value);
            txtStudentID.Text      = row.Cells["student_code"].Value != null ? row.Cells["student_code"].Value.ToString() : "";
            txtStudentName.Text    = row.Cells["full_name"].Value    != null ? row.Cells["full_name"].Value.ToString()    : "";
            cmbStudentClass.Text   = row.Cells["class_name"].Value   != null ? row.Cells["class_name"].Value.ToString()   : "";
            txtStudentContact.Text = row.Cells["contact"].Value      != null ? row.Cells["contact"].Value.ToString()      : "";
            txtStudentID.ReadOnly  = true;
        }

        private void ClearStudentFields()
        {
            selectedStudentId = -1;
            txtStudentID.Clear();
            txtStudentID.ReadOnly = false;
            txtStudentName.Clear();
            txtStudentContact.Clear();
            txtSearchStudent.Clear();
            cmbStudentClass.SelectedIndex = 0;
        }

        // ════════════════════════════════════════════════════════════════════
        //  TAB 3 – ISSUE / RETURN
        // ════════════════════════════════════════════════════════════════════

        /// <summary>Populates dropdowns with available books and active students.</summary>
        private void LoadIssueDropdowns()
        {
            try
            {
                DataTable dtBooks = DatabaseHelper.GetAvailableBooks();
                cmbIssueBook.DataSource    = dtBooks;
                cmbIssueBook.DisplayMember = "display";
                cmbIssueBook.ValueMember   = "book_id";
                if (dtBooks.Rows.Count > 0) cmbIssueBook.SelectedIndex = 0;

                DataTable dtStudents = DatabaseHelper.GetActiveStudents();
                cmbIssueStudent.DataSource    = dtStudents;
                cmbIssueStudent.DisplayMember = "display";
                cmbIssueStudent.ValueMember   = "student_id";
                if (dtStudents.Rows.Count > 0) cmbIssueStudent.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dropdowns: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadIssueGrid()
        {
            try
            {
                DataTable dt = DatabaseHelper.GetIssueRecords();
                dgvIssued.DataSource = dt;
                StyleGrid(dgvIssued);
                if (dgvIssued.Columns["issue_id"] != null)
                    dgvIssued.Columns["issue_id"].Visible = false;
                lblIssuedCount.Text = "Total Records: " + dt.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading issue records: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Issue a book to selected student
        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            if (cmbIssueBook.SelectedValue == null || cmbIssueStudent.SelectedValue == null)
            {
                MessageBox.Show("Please select a Book and a Student!", "Missing Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                int bookId    = Convert.ToInt32(cmbIssueBook.SelectedValue);
                int studentId = Convert.ToInt32(cmbIssueStudent.SelectedValue);
                DatabaseHelper.IssueBook(bookId, studentId, dtpIssueDate.Value, dtpReturnDate.Value);
                MessageBox.Show("Book issued successfully!", "Issued",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadIssueGrid();
                LoadBooksGrid();
                LoadIssueDropdowns();
                LoadDashboard();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error issuing book: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Return selected book from issue records grid
        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            if (selectedIssueId == -1)
            {
                MessageBox.Show("Please click an issue record row to select it!", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                DatabaseHelper.ReturnBook(selectedIssueId, selectedIssueBookId);
                MessageBox.Show("Book returned successfully!", "Returned",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                selectedIssueId     = -1;
                selectedIssueBookId = -1;
                LoadIssueGrid();
                LoadBooksGrid();
                LoadIssueDropdowns();
                LoadDashboard();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error returning book: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Capture issue_id and book_id when a row is clicked
        private void dgvIssued_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvIssued.Rows[e.RowIndex];
            selectedIssueId = Convert.ToInt32(row.Cells["issue_id"].Value);
            // We need book_id to mark it Available on return — fetch from DB via issue_id
            // Simpler: store book_id in a hidden column approach — get from grid via book_code lookup
            // We use a separate query inside ReturnBook using issue_id, so just pass issue_id.
            // book_id is also stored for direct use:
            selectedIssueBookId = -1; // Will be resolved inside DatabaseHelper.ReturnBook using issue_id join
        }

        // ════════════════════════════════════════════════════════════════════
        //  LOGOUT
        // ════════════════════════════════════════════════════════════════════
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to Logout?",
                "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                new LoginForm().Show();
                this.Close();
            }
        }

        // ── Shared Utility ───────────────────────────────────────────────────
        /// <summary>Applies consistent styling to any DataGridView.</summary>
        private void StyleGrid(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 60, 120);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font      = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 245, 255);
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dgv.RowTemplate.Height    = 26;
        }
    }
}
