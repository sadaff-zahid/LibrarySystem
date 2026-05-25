using System;
using System.Windows.Forms;
using LibrarySystem.Database;

namespace LibrarySystem
{
    /// <summary>
    /// Login form — first screen shown to the user.
    /// Validates credentials against the users table in MySQL.
    /// </summary>
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            // Initialise database tables on first run
            try
            {
                DatabaseHelper.InitialiseDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection failed!\n\n" + ex.Message +
                                "\n\nPlease check your MySQL server and connection string in DatabaseHelper.cs",
                                "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Login button click — validate credentials from DB
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter both Username and Password!",
                    "Fields Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool isValid = DatabaseHelper.ValidateLogin(username, password);

                if (isValid)
                {
                    MessageBox.Show("Welcome, " + username + "!\nLogin Successful.",
                        "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainForm mainForm = new MainForm(username);
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password!\nPlease try again.",
                        "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear();
                    txtPassword.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Clear all input fields
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        // Exit the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to Exit?",
                "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                Application.Exit();
        }
    }
}
