namespace OnlineShop
{
    public class Book
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Book> Books { get; set; }

        public void AddBook()
        {
            Book book = new Book();

            book.Title = "Web programming";
            book.Description = "Programación web para principantes";

            Books.Add(book);
        }
    }
}
