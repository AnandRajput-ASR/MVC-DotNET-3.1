using ASR.Bookstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASR.Bookstore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int Id)
        {
            return DataSource().Where(x => x.Id == Id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title, string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(authorName)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id=1, Title="MVC", Author="Anand"},
                new BookModel(){Id=2, Title="Java", Author="Tanjirou"},
                new BookModel(){Id=3, Title="C#", Author="Remi"},
                new BookModel(){Id=4, Title="PHP", Author="Nitish"},
                new BookModel(){Id=5, Title="Azure", Author="Anand"},
            };
        }
    }
}
