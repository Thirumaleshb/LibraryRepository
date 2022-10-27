using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

using LibraryRepository;

public class LibraryManager : ILibrary
{

    public LibraryManager(ILogger logger)
    {
        this.logger = logger;
    }
    List<Book> books = new List<Book>();
    private readonly ILogger logger;

    public Book GetBookById(int id)
    {
        //consoleObj.logs.AppendLine("User is executing  GetBookById Method");
        logger.Log("User is trying to GetBook By using It's ID");

        Book book = books.Find(i => i?.Id == id);
        Console.WriteLine(book);
        if (book is null)
        {
            throw new ArgumentException("Book With Entered Id is not present");
        }
        return book;
    }

    public void AddBook(Book book)
    {
        //consoleObj.logs.AppendLine("User is Adding Book to Library");
        logger.Log("User is Adding Book to Library");
        books.Add(book);
         
    }

    public List<Book> GetBooksByAuthorName(string Author)
    {
        // consoleObj.logs.AppendLine("User is trying to fetch all the books by using Author name");
        logger.Log("User is Trying to Get all the books by Author Name");
        if (string.IsNullOrEmpty(Author))
        {
            throw new ArgumentNullException("Entered AuthorName is Not Valid");
        }


        List<Book> booksByAuthorName = (from book in books
                                        where book.Author == Author
                                        select book).ToList();
        if (booksByAuthorName.Count == 0)
        {
            throw new ArgumentNullException($"We Couldn't Find the Books written by Author {Author} ");

        }
        return booksByAuthorName;
    }

    public List<Book> GetAllBooks()
    {
        logger.Log("User is trying to get all the books ");

        return books;


    }




}



