# Deployment Guide — Library Management System
## CS-412 Visual Programming — Semester Project

---

## System Requirements

| Component       | Requirement                         |
|-----------------|-------------------------------------|
| OS              | Windows 10 / 11                     |
| .NET Framework  | 4.7.2 or higher                     |
| Visual Studio   | 2019 or 2022 (Community Edition OK) |
| MySQL Server    | 8.0 or higher                       |
| MySQL Connector | MySql.Data 8.3.0 (via NuGet)        |

---

## Step-by-Step Setup on a New Machine

### Step 1 — Install MySQL Server
1. Download MySQL Installer from https://dev.mysql.com/downloads/installer/
2. Install **MySQL Server 8.0** and **MySQL Workbench**
3. During setup, set root password (remember it for Step 3)

### Step 2 — Create the Database
1. Open **MySQL Workbench**
2. Connect to `localhost` with your root credentials
3. Open the file `database.sql` from the project folder
4. Click the lightning bolt (Execute) button to run the script
5. The database `library_db` with all tables will be created automatically

### Step 3 — Configure Connection String
1. Open `Database\DatabaseHelper.cs` in Visual Studio
2. Find this line near the top:
   ```
   private static readonly string connectionString =
       "Server=localhost;Port=3306;Database=library_db;Uid=root;Pwd=;";
   ```
3. Replace `Pwd=` with your MySQL root password, e.g. `Pwd=yourpassword;`

### Step 4 — Restore NuGet Packages
1. Open `LibrarySystem.sln` in Visual Studio
2. Right-click the Solution in Solution Explorer
3. Click **Restore NuGet Packages**
4. This will download `MySql.Data` automatically

### Step 5 — Build and Run
1. Press **F5** or click the green **Start** button
2. The Login form will appear

---

## Default Login Credentials

| Username | Password |
|----------|----------|
| admin    | 1234     |

---

## Database Migration (Moving to Another Machine)

Option A — Run the SQL script (recommended):
1. Copy `database.sql` to the new machine
2. Open MySQL Workbench on the new machine
3. Run the script — it creates the database and all tables

Option B — Export from MySQL Workbench:
1. Go to Server → Data Export
2. Select `library_db`
3. Export to a `.sql` file and import on the new machine

---

## Troubleshooting

| Problem                          | Solution                                          |
|----------------------------------|---------------------------------------------------|
| "MySQL connection failed"        | Check MySQL service is running; verify password   |
| "MySql.Data.dll not found"       | Restore NuGet packages (Step 4)                   |
| Build errors after opening       | Retarget project to .NET 4.7.2 in Project settings|
| Tables not found                 | Re-run database.sql script                        |
