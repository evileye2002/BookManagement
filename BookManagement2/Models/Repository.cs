using System.Collections.Generic;
namespace BookManagement2.Models
{
    public static class Repository
    {
        private static List<Book> allBook = new List<Book>();
        public static IEnumerable<Book> AllBook
        {
            get { return allBook; }
        }
        public static void Create(Book book)
        {
            allBook.Add(book);
        }
        public static void Delete(Book book)
        {
            allBook.Remove(book);
        }
    }
}
