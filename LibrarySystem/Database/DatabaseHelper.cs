using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace LibrarySystem.Database
{
    /// <summary>
    /// DatabaseHelper handles all database operations using ADO.NET with MySQL.
    /// This is the Data Access Layer (DAL) of the application.
    /// All SQL queries are centralised here — no SQL in Form files.
    /// </summary>
    public static class DatabaseHelper
    {
        // ── Connection String ────────────────────────────────────────────────
        // Change Host, Port, Database, Uid, Pwd to match your MySQL setup.
        private static readonly string connectionString =
            "Server=localhost;Port=3306;Database=library_db;Uid=root;Pwd=sadaf@123;";

        // ── Connection Factory ───────────────────────────────────────────────
        /// <summary>Returns a new open MySqlConnection.</summary>
        public static MySqlConnection GetConnection()
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            return conn;
        }

        // ════════════════════════════════════════════════════════════════════
        //  DATABASE INITIALISATION
        // ════════════════════════════════════════════════════════════════════
        /// <summary>
        /// Creates all required tables if they do not already exist.
        /// Called once at application startup.
        /// </summary>
        public static void InitialiseDatabase()
        {
            using (MySqlConnection conn = GetConnection())
            {
                // Users table for login
                string createUsers = @"
                    CREATE TABLE IF NOT EXISTS users (
                        user_id     INT AUTO_INCREMENT PRIMARY KEY,
                        username    VARCHAR(50)  NOT NULL UNIQUE,
                        password    VARCHAR(100) NOT NULL,
                        role        VARCHAR(20)  NOT NULL DEFAULT 'admin',
                        is_active   TINYINT(1)   NOT NULL DEFAULT 1,
                        created_at  DATETIME     NOT NULL DEFAULT CURRENT_TIMESTAMP
                    );";

                // Books table (Entity 1)
                string createBooks = @"
                    CREATE TABLE IF NOT EXISTS books (
                        book_id     INT AUTO_INCREMENT PRIMARY KEY,
                        book_code   VARCHAR(20)  NOT NULL UNIQUE,
                        title       VARCHAR(200) NOT NULL,
                        author      VARCHAR(100) NOT NULL,
                        category    VARCHAR(50)  NOT NULL,
                        status      VARCHAR(20)  NOT NULL DEFAULT 'Available',
                        year        VARCHAR(10),
                        is_deleted  TINYINT(1)   NOT NULL DEFAULT 0,
                        created_at  DATETIME     NOT NULL DEFAULT CURRENT_TIMESTAMP
                    );";

                // Students table (Entity 2)
                string createStudents = @"
                    CREATE TABLE IF NOT EXISTS students (
                        student_id      INT AUTO_INCREMENT PRIMARY KEY,
                        student_code    VARCHAR(20)  NOT NULL UNIQUE,
                        full_name       VARCHAR(100) NOT NULL,
                        class_name      VARCHAR(20)  NOT NULL,
                        contact         VARCHAR(20),
                        is_deleted      TINYINT(1)   NOT NULL DEFAULT 0,
                        created_at      DATETIME     NOT NULL DEFAULT CURRENT_TIMESTAMP
                    );";

                // Issue/Return records table (Entity 3 — relationship)
                string createIssues = @"
                    CREATE TABLE IF NOT EXISTS issue_records (
                        issue_id        INT AUTO_INCREMENT PRIMARY KEY,
                        book_id         INT          NOT NULL,
                        student_id      INT          NOT NULL,
                        issue_date      DATE         NOT NULL,
                        return_date     DATE         NOT NULL,
                        actual_return   DATE,
                        status          VARCHAR(20)  NOT NULL DEFAULT 'Issued',
                        created_at      DATETIME     NOT NULL DEFAULT CURRENT_TIMESTAMP,
                        FOREIGN KEY (book_id)    REFERENCES books(book_id),
                        FOREIGN KEY (student_id) REFERENCES students(student_id)
                    );";

                // Seed default admin user (password: 1234)
                string seedUser = @"
                    INSERT IGNORE INTO users (username, password, role)
                    VALUES ('admin', '1234', 'admin');";

                ExecuteNonQuery(conn, createUsers);
                ExecuteNonQuery(conn, createBooks);
                ExecuteNonQuery(conn, createStudents);
                ExecuteNonQuery(conn, createIssues);
                ExecuteNonQuery(conn, seedUser);
            }
        }

        // ── Private Helper ───────────────────────────────────────────────────
        private static void ExecuteNonQuery(MySqlConnection conn, string sql)
        {
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                cmd.ExecuteNonQuery();
        }

        // ════════════════════════════════════════════════════════════════════
        //  USER / LOGIN
        // ════════════════════════════════════════════════════════════════════
        /// <summary>Returns true if username+password match an active user.</summary>
        public static bool ValidateLogin(string username, string password)
        {
            string sql = "SELECT COUNT(*) FROM users WHERE username=@u AND password=@p AND is_active=1";
            using (MySqlConnection conn = GetConnection())
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        // ════════════════════════════════════════════════════════════════════
        //  BOOKS — CRUD
        // ════════════════════════════════════════════════════════════════════
        /// <summary>Returns all non-deleted books, optionally filtered by keyword.</summary>
        public static DataTable GetBooks(string searchKeyword = "")
        {
            string sql = @"SELECT book_id, book_code, title, author, category, status, year
                           FROM books
                           WHERE is_deleted = 0
                             AND (book_code LIKE @k OR title LIKE @k OR author LIKE @k)
                           ORDER BY book_id DESC";
            using (MySqlConnection conn = GetConnection())
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@k", "%" + searchKeyword + "%");
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        /// <summary>Inserts a new book record.</summary>
        public static void AddBook(string bookCode, string title, string author,
                                   string category, string status, string year)
        {
            string sql = @"INSERT INTO books (book_code, title, author, category, status, year)
                           VALUES (@code, @title, @author, @cat, @status, @year)";
            using (MySqlConnection conn = GetConnection())
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@code",   bookCode);
                cmd.Parameters.AddWithValue("@title",  title);
                cmd.Parameters.AddWithValue("@author", author);
                cmd.Parameters.AddWithValue("@cat",    category);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@year",   year);
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>Updates an existing book by its database ID.</summary>
        public static void UpdateBook(int bookId, string title, string author,
                                      string category, string status, string year)
        {
            string sql = @"UPDATE books
                           SET title=@title, author=@author, category=@cat,
                               status=@status, year=@year
                           WHERE book_id=@id";
            using (MySqlConnection conn = GetConnection())
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@title",  title);
                cmd.Parameters.AddWithValue("@author", author);
                cmd.Parameters.AddWithValue("@cat",    category);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@year",   year);
                cmd.Parameters.AddWithValue("@id",     bookId);
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>Soft-deletes a book (sets is_deleted = 1).</summary>
        public static void DeleteBook(int bookId)
        {
            string sql = "UPDATE books SET is_deleted=1 WHERE book_id=@id";
            using (MySqlConnection conn = GetConnection())
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id", bookId);
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>Returns true if a book_code is already taken.</summary>
        public static bool BookCodeExists(string bookCode)
        {
            string sql = "SELECT COUNT(*) FROM books WHERE book_code=@code AND is_deleted=0";
            using (MySqlConnection conn = GetConnection())
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@code", bookCode);
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        // ════════════════════════════════════════════════════════════════════
        //  STUDENTS — CRUD
        // ════════════════════════════════════════════════════════════════════
        /// <summary>Returns all non-deleted students, optionally filtered.</summary>
        public static DataTable GetStudents(string searchKeyword = "")
        {
            string sql = @"SELECT student_id, student_code, full_name, class_name, contact
                           FROM students
                           WHERE is_deleted = 0
                             AND (student_code LIKE @k OR full_name LIKE @k)
                           ORDER BY student_id DESC";
            using (MySqlConnection conn = GetConnection())
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@k", "%" + searchKeyword + "%");
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        /// <summary>Inserts a new student record.</summary>
        public static void AddStudent(string studentCode, string fullName,
                                      string className, string contact)
        {
            string sql = @"INSERT INTO students (student_code, full_name, class_name, contact)
                           VALUES (@code, @name, @class, @contact)";
            using (MySqlConnection conn = GetConnection())
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@code",    studentCode);
                cmd.Parameters.AddWithValue("@name",    fullName);
                cmd.Parameters.AddWithValue("@class",   className);
                cmd.Parameters.AddWithValue("@contact", contact);
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>Updates an existing student by database ID.</summary>
        public static void UpdateStudent(int studentId, string fullName,
                                         string className, string contact)
        {
            string sql = @"UPDATE students
                           SET full_name=@name, class_name=@class, contact=@contact
                           WHERE student_id=@id";
            using (MySqlConnection conn = GetConnection())
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@name",    fullName);
                cmd.Parameters.AddWithValue("@class",   className);
                cmd.Parameters.AddWithValue("@contact", contact);
                cmd.Parameters.AddWithValue("@id",      studentId);
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>Soft-deletes a student.</summary>
        public static void DeleteStudent(int studentId)
        {
            string sql = "UPDATE students SET is_deleted=1 WHERE student_id=@id";
            using (MySqlConnection conn = GetConnection())
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id", studentId);
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>Returns true if a student_code is already taken.</summary>
        public static bool StudentCodeExists(string studentCode)
        {
            string sql = "SELECT COUNT(*) FROM students WHERE student_code=@code AND is_deleted=0";
            using (MySqlConnection conn = GetConnection())
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@code", studentCode);
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        // ════════════════════════════════════════════════════════════════════
        //  ISSUE / RETURN
        // ════════════════════════════════════════════════════════════════════
        /// <summary>Returns all issue records joined with book and student names.</summary>
        public static DataTable GetIssueRecords()
        {
            string sql = @"SELECT ir.issue_id,
                                  b.book_code, b.title AS book_title,
                                  s.student_code, s.full_name AS student_name,
                                  ir.issue_date, ir.return_date, ir.status
                           FROM issue_records ir
                           JOIN books    b ON b.book_id    = ir.book_id
                           JOIN students s ON s.student_id = ir.student_id
                           ORDER BY ir.issue_id DESC";
            using (MySqlConnection conn = GetConnection())
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        /// <summary>Issues a book to a student and marks book status as Issued.</summary>
        public static void IssueBook(int bookId, int studentId,
                                     DateTime issueDate, DateTime returnDate)
        {
            using (MySqlConnection conn = GetConnection())
            {
                // Insert issue record
                string insertSql = @"INSERT INTO issue_records
                                         (book_id, student_id, issue_date, return_date, status)
                                     VALUES (@bid, @sid, @idate, @rdate, 'Issued')";
                using (MySqlCommand cmd = new MySqlCommand(insertSql, conn))
                {
                    cmd.Parameters.AddWithValue("@bid",   bookId);
                    cmd.Parameters.AddWithValue("@sid",   studentId);
                    cmd.Parameters.AddWithValue("@idate", issueDate.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@rdate", returnDate.ToString("yyyy-MM-dd"));
                    cmd.ExecuteNonQuery();
                }
                // Update book status to Issued
                string updateBook = "UPDATE books SET status='Issued' WHERE book_id=@id";
                using (MySqlCommand cmd = new MySqlCommand(updateBook, conn))
                {
                    cmd.Parameters.AddWithValue("@id", bookId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>Marks an issue record as Returned and sets book back to Available.</summary>
        public static void ReturnBook(int issueId, int bookId)
        {
            using (MySqlConnection conn = GetConnection())
            {
                // Update issue record
                string updateIssue = @"UPDATE issue_records
                                       SET status='Returned', actual_return=CURDATE()
                                       WHERE issue_id=@iid";
                using (MySqlCommand cmd = new MySqlCommand(updateIssue, conn))
                {
                    cmd.Parameters.AddWithValue("@iid", issueId);
                    cmd.ExecuteNonQuery();
                }
                // Mark book available again
                string updateBook = "UPDATE books SET status='Available' WHERE book_id=@bid";
                using (MySqlCommand cmd = new MySqlCommand(updateBook, conn))
                {
                    cmd.Parameters.AddWithValue("@bid", bookId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>Returns available books as DataTable for ComboBox binding.</summary>
        public static DataTable GetAvailableBooks()
        {
            string sql = "SELECT book_id, CONCAT(book_code,' - ',title) AS display FROM books WHERE status='Available' AND is_deleted=0";
            using (MySqlConnection conn = GetConnection())
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        /// <summary>Returns active students as DataTable for ComboBox binding.</summary>
        public static DataTable GetActiveStudents()
        {
            string sql = "SELECT student_id, CONCAT(student_code,' - ',full_name) AS display FROM students WHERE is_deleted=0";
            using (MySqlConnection conn = GetConnection())
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // ════════════════════════════════════════════════════════════════════
        //  DASHBOARD STATISTICS
        // ════════════════════════════════════════════════════════════════════
        /// <summary>Returns total count of non-deleted books.</summary>
        public static int GetTotalBooks()
        {
            return GetCount("SELECT COUNT(*) FROM books WHERE is_deleted=0");
        }

        /// <summary>Returns count of available books.</summary>
        public static int GetAvailableBookCount()
        {
            return GetCount("SELECT COUNT(*) FROM books WHERE status='Available' AND is_deleted=0");
        }

        /// <summary>Returns total count of non-deleted students.</summary>
        public static int GetTotalStudents()
        {
            return GetCount("SELECT COUNT(*) FROM students WHERE is_deleted=0");
        }

        /// <summary>Returns count of currently issued books.</summary>
        public static int GetCurrentlyIssuedCount()
        {
            return GetCount("SELECT COUNT(*) FROM issue_records WHERE status='Issued'");
        }

        private static int GetCount(string sql)
        {
            using (MySqlConnection conn = GetConnection())
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                return Convert.ToInt32(cmd.ExecuteScalar());
        }
    }
}
