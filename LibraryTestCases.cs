using LibraryRepository;

namespace LibraryTestCases
{
    [TestClass]
    public class LibraryTestCases

    {
        public TestContext TestContext { get; set; }
        [TestMethod]
        [ExpectedException(typeof(OutOfMemoryException), "Thier is No Space Left to Add the Given Book")]
        public void AddMethodTest()
        {

            Book book1 = new Book(1, "MoneyPower", "RGV");
            Book book2 = new Book(2, "Crime", "Thiru");
            LibraryManager libraryObj = new LibraryManager();
            libraryObj.AddBook(book1);
            libraryObj.AddBook(book2);
            TestContext.WriteLine("The Value of Books Count is " + LibraryManager.BooksCount);
        }




        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Book Details Cannot be Fetched")]
        public void GetAllBooksTest()
        {
            LibraryManager libraryObj = new LibraryManager();
            List<Book> allBooks = libraryObj.GetAllBooks();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Book With Given Id is not Present")]
        public void GetBookByIdTest()
        {
            Book book1 = new Book(10, "Game", "Mark");

            LibraryManager libraryObj = new LibraryManager();
            libraryObj.AddBook(book1);
            TestContext.WriteLine("The Value of the BooksCount is " + LibraryManager.BooksCount);
            // libraryObj.GetBookById(11);
            libraryObj.GetBookById(1);
            
            
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetBooksByAuthorName()
        {
            Book book1 = new Book(10, "Game", "Mark");
            Book book2 = new Book(11, "GameChanger", "Henry");
            
            LibraryManager libraryObj = new LibraryManager();
            libraryObj.AddBook(book1);
            libraryObj.AddBook(book2);
            libraryObj.GetBooksByAuthorName("Mark");




        }


        [TestMethod]
        public void IsLibraryEmptyTest()
        {
            bool value = true; //Considering library is Empty
            if (LibraryManager.BooksCount != 0)
            {
                value = false;
            }
            Assert.IsTrue(value);
        }
    }
}