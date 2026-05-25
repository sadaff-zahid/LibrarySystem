-- ============================================================
--  Library Management System — MySQL Database Script
--  CS-412 Visual Programming — Semester Project
--  Run this script in MySQL Workbench or phpMyAdmin
-- ============================================================

CREATE DATABASE IF NOT EXISTS library_db
    CHARACTER SET utf8mb4
    COLLATE utf8mb4_unicode_ci;

USE library_db;

-- ── Users Table (Login) ──────────────────────────────────────
CREATE TABLE IF NOT EXISTS users (
    user_id     INT AUTO_INCREMENT PRIMARY KEY,
    username    VARCHAR(50)  NOT NULL UNIQUE,
    password    VARCHAR(100) NOT NULL,
    role        VARCHAR(20)  NOT NULL DEFAULT 'admin',
    is_active   TINYINT(1)   NOT NULL DEFAULT 1,
    created_at  DATETIME     NOT NULL DEFAULT CURRENT_TIMESTAMP
);

-- Default admin user  (username: admin, password: 1234)
INSERT IGNORE INTO users (username, password, role)
VALUES ('admin', '1234', 'admin');

-- ── Books Table (Entity 1) ───────────────────────────────────
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
);

-- Sample book data
INSERT IGNORE INTO books (book_code, title, author, category, status, year) VALUES
('B001', 'Islamiat Notes',    'Maulana Tariq', 'Religion',   'Available', '2020'),
('B002', 'Pakistan Studies',  'Ahmed Ali',     'History',    'Available', '2019'),
('B003', 'English Grammar',   'Oxford Press',  'Language',   'Available', '2021'),
('B004', 'Computer Science',  'Ali Raza',      'Technology', 'Available', '2022'),
('B005', 'Urdu Adab',         'Faiz Ahmed',    'Literature', 'Available', '2018'),
('B006', 'Mathematics',       'Prof. Saleem',  'Science',    'Available', '2023');

-- ── Students Table (Entity 2) ────────────────────────────────
CREATE TABLE IF NOT EXISTS students (
    student_id    INT AUTO_INCREMENT PRIMARY KEY,
    student_code  VARCHAR(20)  NOT NULL UNIQUE,
    full_name     VARCHAR(100) NOT NULL,
    class_name    VARCHAR(20)  NOT NULL,
    contact       VARCHAR(20),
    is_deleted    TINYINT(1)   NOT NULL DEFAULT 0,
    created_at    DATETIME     NOT NULL DEFAULT CURRENT_TIMESTAMP
);

-- Sample student data
INSERT IGNORE INTO students (student_code, full_name, class_name, contact) VALUES
('S001', 'Hassan Ali',    '10th A', '0300-1234567'),
('S002', 'Fatima Khan',   '10th B', '0301-2345678'),
('S003', 'Umar Farooq',   '9th A',  '0302-3456789'),
('S004', 'Ayesha Siddiq', '9th B',  '0303-4567890');

-- ── Issue Records Table (Entity 3) ──────────────────────────
CREATE TABLE IF NOT EXISTS issue_records (
    issue_id      INT AUTO_INCREMENT PRIMARY KEY,
    book_id       INT  NOT NULL,
    student_id    INT  NOT NULL,
    issue_date    DATE NOT NULL,
    return_date   DATE NOT NULL,
    actual_return DATE,
    status        VARCHAR(20) NOT NULL DEFAULT 'Issued',
    created_at    DATETIME    NOT NULL DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (book_id)    REFERENCES books(book_id),
    FOREIGN KEY (student_id) REFERENCES students(student_id)
);
