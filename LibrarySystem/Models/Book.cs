namespace LibrarySystem.Models
{
    /// <summary>
    /// Model class representing a Book entity.
    /// Maps to the 'books' table in the database.
    /// </summary>
    public class Book
    {
        public int    BookId    { get; set; }
        public string BookCode  { get; set; }
        public string Title     { get; set; }
        public string Author    { get; set; }
        public string Category  { get; set; }
        public string Status    { get; set; }
        public string Year      { get; set; }
    }
}
