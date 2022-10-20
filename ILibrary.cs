using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryRepository
{
     interface ILibrary
    {
        void AddBook(Book item);
        List<Book> GetBooksByAuthorName(string name);

        List<Book> GetAllBooks();


        Book GetBookById(int id);

        void IsLibraryEmpty();


    }
}
