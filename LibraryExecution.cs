// See https://aka.ms/new-console-template for more information
using LibraryRepository;
using System;
public class LibraryExecution
{
    public static void Main (string[] args)
    {
        LibraryManager library = new LibraryManager();
        library.IsLibraryEmpty();
        Book book1 = new Book(1,"Ramayanam", "Valmiki");
        Book book2 = new Book(2,"HarryPotter", "Jk Rowling");
        Book book3 = new Book(3,"Merchant of venice", "Shakesphere");
        Book book4 = new Book(4,"Crime", "Henry");

       
        try
        {
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);

        }
        catch (OutOfMemoryException ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.WriteLine("Enter the Author Name Whose Books has to be fetched ");
        string? author = Console.ReadLine();
        try
        {
           List<Book>BooksByAuthor= library.GetBooksByAuthorName(author!);
           Console.WriteLine($"The Book Written by {author} are :");
           foreach(Book books in BooksByAuthor)
            {
                Console.WriteLine(books.BookName);
            }
        }
        
        catch (ArgumentNullException ex)
        {
            Console.WriteLine(ex.Message);
        }

        try
        {
           List<Book>AllBooks=library.GetAllBooks();
           foreach(Book books in AllBooks)
            {
                Console.WriteLine($"The Book {books.BookName} With ID {books.Id} is Written By {books.Author}");
            }

        }
        catch(ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        try
        {
            Book book = library.GetBookById(1);
            Console.WriteLine("The Book With the Given Id is " + book.BookName);

        }
        catch(ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
 

        library.IsLibraryEmpty();
        
        




    }

}
