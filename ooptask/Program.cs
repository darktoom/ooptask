namespace ooptask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("math","ahmed","123456");
            BorrowedBook book1 = new BorrowedBook(new Book("math","ahmed","123456"),"hatem",DateTime.Now);
            Console.WriteLine(book1.ToString()); 
         


        }
    }
}
