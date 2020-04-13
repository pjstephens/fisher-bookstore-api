using System.Collections.Generic;
using Fisher.Bookstore.Data;
using Fisher.Bookstore.Models;

namespace Fisher.Bookstore.Services
{

    public class AuthorsRepository : IAuthorsRepository
    {
        private readonly BookstoreContext db;

        public AuthorsRepository(BookstoreContext db)
        {
            this.db = db;
        }

        public int AddAuthor(Author author)
        {
            throw new System.NotImplementedException();
        }

        public bool AuthorExists(int authorId)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteAuthor(int authorId)
        {
            throw new System.NotImplementedException();
        }

        public Author GetAuthor(int authorId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Author> GetAuthors()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateAuthor(Author author)
        {
            throw new System.NotImplementedException();
        }
    }
}
