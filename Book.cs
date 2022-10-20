namespace LibraryRepository
{
    public class Book
    {
        public string BookName { get; set; }
        public string Author { get; set; }
        //public int Edition { get; set; }

        public int Id { get; set; }

        public Book(int Id, string bookName, string author)
        {
            this.BookName = bookName;
            this.Author = author;
            //this.Edition = edition;
            this.Id = Id;
        }
    }
}