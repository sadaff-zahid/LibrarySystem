# Library Management System — Project Documentation
## CS-412 Visual Programming | Semester Project

---

## 1. SRS / Design Document

### 1.1 Problem Statement
Libraries in schools and colleges manage hundreds of books and student borrowing records
manually, which leads to errors, lost records, and difficulty in tracking. This project
provides a simple digital Library Management System to solve these problems.

### 1.2 Objectives
- Allow admin to manage books (add, update, delete, search)
- Allow admin to manage students (add, update, delete, search)
- Track which books are issued to which students
- Show a live dashboard with key statistics
- Secure access through a login system

### 1.3 User Roles
| Role  | Access                                        |
|-------|-----------------------------------------------|
| Admin | Full access to all features (login: admin/1234)|

### 1.4 Features List
- User login with database authentication
- Dashboard with 4 live statistics cards
- Full CRUD on Books entity
- Full CRUD on Students entity
- Issue book to student with date pickers
- Return book from issue records
- Search/filter on both Books and Students
- Soft delete (records kept in DB, not shown in UI)
- Dropdown menus for Category, Status, Class

---

## 2. Database Design

### 2.1 Tables

**users**
| Column     | Type         | Notes                  |
|------------|--------------|------------------------|
| user_id    | INT PK AI    | Auto increment         |
| username   | VARCHAR(50)  | Unique                 |
| password   | VARCHAR(100) |                        |
| role       | VARCHAR(20)  | 'admin'                |
| is_active  | TINYINT(1)   | 1=active, 0=disabled   |
| created_at | DATETIME     |                        |

**books**
| Column     | Type         | Notes                          |
|------------|--------------|--------------------------------|
| book_id    | INT PK AI    |                                |
| book_code  | VARCHAR(20)  | Unique code e.g. B001          |
| title      | VARCHAR(200) |                                |
| author     | VARCHAR(100) |                                |
| category   | VARCHAR(50)  |                                |
| status     | VARCHAR(20)  | Available / Issued / Lost      |
| year       | VARCHAR(10)  |                                |
| is_deleted | TINYINT(1)   | Soft delete flag               |
| created_at | DATETIME     |                                |

**students**
| Column       | Type         | Notes                      |
|--------------|--------------|----------------------------|
| student_id   | INT PK AI    |                            |
| student_code | VARCHAR(20)  | Unique code e.g. S001      |
| full_name    | VARCHAR(100) |                            |
| class_name   | VARCHAR(20)  |                            |
| contact      | VARCHAR(20)  |                            |
| is_deleted   | TINYINT(1)   | Soft delete flag           |
| created_at   | DATETIME     |                            |

**issue_records**
| Column       | Type     | Notes                           |
|--------------|----------|---------------------------------|
| issue_id     | INT PK AI|                                 |
| book_id      | INT FK   | References books.book_id        |
| student_id   | INT FK   | References students.student_id  |
| issue_date   | DATE     |                                 |
| return_date  | DATE     | Expected return date            |
| actual_return| DATE     | Filled on actual return         |
| status       | VARCHAR  | Issued / Returned               |
| created_at   | DATETIME |                                 |

### 2.2 Relationships
- books → issue_records : One book can have many issue records (one at a time when status=Issued)
- students → issue_records : One student can borrow multiple books over time

---

## 3. Application Architecture

### 3.1 Layers
```
┌────────────────────────────────┐
│   UI Layer (Forms)             │
│   LoginForm.cs / MainForm.cs   │
├────────────────────────────────┤
│   Data Access Layer (DAL)      │
│   Database/DatabaseHelper.cs   │
├────────────────────────────────┤
│   Model Layer                  │
│   Models/Book.cs               │
│   Models/Student.cs            │
│   Models/IssueRecord.cs        │
├────────────────────────────────┤
│   MySQL Database               │
│   library_db                   │
└────────────────────────────────┘
```

### 3.2 Folder Structure
```
LibrarySystem/
├── Program.cs               Entry point
├── Database/
│   └── DatabaseHelper.cs    All SQL queries (ADO.NET)
├── Models/
│   ├── Book.cs
│   ├── Student.cs
│   └── IssueRecord.cs
├── Forms/
│   ├── LoginForm.cs + Designer
│   └── MainForm.cs + Designer
├── database.sql             DB creation script
├── DEPLOYMENT.md
└── REPOSITORY.txt
```

---

## 4. Technical Manual

### Prerequisites
- Windows 10/11
- .NET Framework 4.7.2
- Visual Studio 2019/2022
- MySQL Server 8.0+

### Setup Steps
1. Run `database.sql` in MySQL Workbench
2. Open `DatabaseHelper.cs`, update `Pwd=` with your MySQL password
3. Open `LibrarySystem.sln` in Visual Studio
4. Right-click Solution → Restore NuGet Packages
5. Press F5 to run

### Technology Choices
- **MySQL**: Chosen over SQLite because it supports multi-user access,
  is widely used in industry, and is better for learning production-level skills.
- **ADO.NET**: Chosen over Entity Framework for learning purposes —
  it makes SQL visible and explicit, which helps understand what queries are running.
- **.NET 4.7.2 Windows Forms**: Required by the course (CS-412 Visual Programming).

---

## 5. User Manual

### Login
1. Enter username: `admin`
2. Enter password: `1234`
3. Click LOGIN

### Dashboard Tab
- Shows live counts: Total Books, Available Books, Total Students, Currently Issued

### Books Tab — Add a Book
1. Enter Book Code (e.g. B007)
2. Enter Title, Author
3. Select Category from dropdown
4. Select Status (default: Available)
5. Enter Year
6. Click **Add Book**

### Books Tab — Update a Book
1. Click any row in the table — fields auto-fill
2. Change the values you want
3. Click **Update Book**

### Books Tab — Delete a Book
1. Click a row to select it
2. Click **Delete Book**
3. Confirm the dialog — book is soft-deleted (hidden but kept in DB)

### Books Tab — Search
1. Type a keyword in the search box
2. Click **Search** — filters by Title, Author, or Book Code
3. Click **Show All** to reset

### Students Tab
Same as Books Tab — Add, Update, Delete, Search students.

### Issue / Return Tab — Issue a Book
1. Select an available book from the dropdown
2. Select a student from the dropdown
3. Set Issue Date and Return Date
4. Click **Issue Book**

### Issue / Return Tab — Return a Book
1. Click a row in the issue records table
2. Click **Return Book**
3. Book status changes back to Available

---

## 6. Challenges & Solutions

| Challenge | Solution |
|-----------|----------|
| MySql.Data not found on build | Added NuGet package reference in .csproj and packages.config |
| Book IDs hidden but needed for update/delete | Stored book_id in hidden DataGridView column, retrieved on row click |
| Preventing duplicate codes | Added BookCodeExists() / StudentCodeExists() check before INSERT |
| Return needs book_id | ReturnBook() method does a JOIN inside DatabaseHelper using issue_id |
| Designer helper methods causing compile errors | Removed all helper methods from Designer; wrote all control properties fully inline |

---

## 7. Trade-offs & Decisions

| Decision | Chosen | Alternative | Reason |
|----------|--------|-------------|--------|
| Database | MySQL | SQLite | MySQL is multi-user, industry standard; good for learning |
| Data Access | ADO.NET | Entity Framework | ADO.NET makes SQL explicit; better for beginners to understand |
| UI Framework | Windows Forms | WPF | Required by CS-412 course specification |
| Delete | Soft Delete | Hard Delete | Soft delete preserves data integrity and history |
| Architecture | 3-layer (UI/DAL/Models) | Monolithic | Separation of concerns; easier to maintain and explain in viva |
