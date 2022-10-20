using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

using LibraryRepository;

public class LibraryManager : ILibrary
{
    public static int LibraryCapacity = 250;
    public static int BooksCount = 0;
    static List<Book> Books = new List<Book>();


    public Book GetBookById(int id)
    {

        Book? book = Books?.Find(i => i?.Id == id);
        if (book is null)
        {
            throw new ArgumentException("Book With Entered Id is not present");
        }
        return book;
    }

    public void AddBook(Book book)
    {
        if (BooksCount == LibraryCapacity)
        {
            throw new OutOfMemoryException("Library is Full , Cannot Insert Further Books");
        }
        else
        {
            Books.Add(book);
            BooksCount++;

        }

    }
    public List<Book> GetBooksByAuthorName(string Author)
    {
        if (string.IsNullOrEmpty(Author))
        {
            throw new ArgumentNullException("Entered AuthorName is Not Valid");
        }
        else
        {
            List<Book> booksByAuthorName = (from book in Books
                                            where book.Author == Author
                                            select book).ToList();
            if (booksByAuthorName.Count > 0)
            {
                return booksByAuthorName;

            }
            else
            {
                throw new ArgumentNullException($"We Couldn't Find the Books written by Author {Author} ");
            }



        }


    }

    public List<Book> GetAllBooks()
    {
        if (BooksCount == 0)
        {
            throw new ArgumentException("Thier is No Books Present in the Library");
        }
        else
        {
            return Books;
        }

    }



    public void IsLibraryEmpty()
    {

        if (BooksCount == 0)
        {
            Console.WriteLine("Library is Empty");
        }
        else
        {
            Console.WriteLine($"Library is not Empty it Contains {BooksCount} Books");
        }
    }
}



