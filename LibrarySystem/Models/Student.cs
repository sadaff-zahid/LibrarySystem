namespace LibrarySystem.Models
{
    /// <summary>
    /// Model class representing a Student entity.
    /// Maps to the 'students' table in the database.
    /// </summary>
    public class Student
    {
        public int    StudentId   { get; set; }
        public string StudentCode { get; set; }
        public string FullName    { get; set; }
        public string ClassName   { get; set; }
        public string Contact     { get; set; }
    }
}
