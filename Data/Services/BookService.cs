using System.Collections.Generic;
using System.Linq;
using Summaries.Data.Models;

namespace Summaries.Data.Services
{
    public class BookService : IBookService
    {
        public void AddBook(Book newBook)
        {
            Data.Books.Add(newBook);
        }

        public void DeleteBook(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Book> GetAllBooks()
        {
            return Data.Books.ToList();
        }

        public Book GetBookById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateBook(int id, Book newBook)
        {
            var oldBook = Data.Books.FirstOrDefault(n => n.Id == id);
            if (oldBook == null) return;
            oldBook.Title = newBook.Title;
            oldBook.Author = newBook.Author;
            oldBook.Description = newBook.Description;
            oldBook.Rate = newBook.Rate;
            oldBook.DateStart = newBook.DateStart;
            oldBook.DateRead = newBook.DateRead;
        }
    }
}