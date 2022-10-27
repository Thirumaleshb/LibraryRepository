using LibraryRepository;
using System.ComponentModel;

namespace LibraryTestCases
{
    [TestClass]
    public class LibraryTestCases

    {
        public TestContext TestContext { get; set; }
        [TestMethod]

        public void AddMethodTest()
        {

            Book book1 = new Book(1, "MoneyPower", "RGV");
            Book book2 = new Book(2, "Crime", "Thiru");
            Consolelogger logger = new Consolelogger();
            LibraryManager libraryObj = new LibraryManager(logger);
           // int value = libraryObj.GetAllBooks().Count;
            libraryObj.AddBook(book1);
            libraryObj.AddBook(book2);
            Assert.AreEqual(2, libraryObj.GetAllBooks().Count);
        }




        [TestMethod]

        public void GetAllBooksTest()
        {
            ILogger logger = new Consolelogger();
            LibraryManager libraryObj = new LibraryManager(logger);
            Book book1 = new Book(110, "Game", "Mark");
            libraryObj.AddBook(book1);
            List<Book> bookList = libraryObj.GetAllBooks();
           
            int value = libraryObj.GetAllBooks().Count;
            Book book2 = new Book(10, "Game", "Mark");
            libraryObj.AddBook(book1);
            int value1 = bookList.Count;

            Assert.IsTrue(value != libraryObj.GetAllBooks().Count);




        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Book With Given Id is not Present")]
        public void GetBookByIdTest()
        {
           ILogger logger = new Consolelogger();
            Book book1 = new Book(10, "Game", "Mark");
            LibraryManager libraryObj = new LibraryManager(logger);
            //libraryObj.AddBook(book1);
            libraryObj.GetBookById(0);


        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetBooksByAuthorName()
        {
            Book book1 = new Book(10, "Game", "Mark");
            Book book2 = new Book(11, "GameChanger", "Henry");
            ILogger logger = new Consolelogger();

            LibraryManager libraryObj = new LibraryManager(logger);
            libraryObj.AddBook(book1);
            libraryObj.AddBook(book2);
            libraryObj.GetBooksByAuthorName("Chethan");
        }

        [TestMethod]
     
        public void NonExceptionForGetBookById()
        {
            Book book1 = new Book(10, "Game", "Mark");
            ILogger logger = new Consolelogger();
            LibraryManager libraryObj = new LibraryManager(logger);
            libraryObj.AddBook(book1);
           // libraryObj.GetBookById(0);
            Book book= libraryObj.GetBookById(10);
            Assert.IsNotNull(book); 


        }

        [TestMethod]
       
        public void NonExceptionForGetBooksByAuthorName()
        {
            Book book1 = new Book(10, "Game", "Mark");
            Book book2 = new Book(11, "GameChanger", "Henry");
            Consolelogger logger = new Consolelogger();
            LibraryManager libraryObj = new LibraryManager(logger);
            libraryObj.AddBook(book1);
            libraryObj.AddBook(book2);
            List<Book>bookList=libraryObj.GetBooksByAuthorName("Henry");
            Assert.IsNotNull(bookList);

        }
    }
}
