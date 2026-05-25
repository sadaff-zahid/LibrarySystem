using System;

namespace LibrarySystem.Models
{
    /// <summary>
    /// Model representing a book issue/return record.
    /// Maps to the 'issue_records' table in the database.
    /// </summary>
    public class IssueRecord
    {
        public int      IssueId      { get; set; }
        public int      BookId       { get; set; }
        public int      StudentId    { get; set; }
        public DateTime IssueDate    { get; set; }
        public DateTime ReturnDate   { get; set; }
        public string   Status       { get; set; }
    }
}
