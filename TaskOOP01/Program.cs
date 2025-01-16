namespace TaskOOP01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Black Beauty", "Anna Sewell", "112233");

            BorrowedBook brBook = new BorrowedBook(1, book, "mohamed salah", DateTime.Now);

            brBook.CheckOut();

            brBook.ReturnItem();

            int duration = brBook.CalculateBorrowDuration();
            Console.WriteLine($"\ndays have passed since the book was borrowed : {duration}");
        }
    }
}
