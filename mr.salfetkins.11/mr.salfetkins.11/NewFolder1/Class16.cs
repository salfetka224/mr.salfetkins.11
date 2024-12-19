using System.Collections.Generic;

public class Library
{
    public class Book
    {
        public string Title { get; set; }
        public Author BookAuthor { get; set; }
    }

    public class Author
    {
        public string Name { get; set; }
    }

    public class Reader
    {
        public string Name { get; set; }
        public List<Book> BorrowedBooks { get; set; }
    }
}