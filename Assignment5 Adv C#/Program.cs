namespace Assignment5_Adv_C_
{
    public class Program
    {
        //delegate declaration
        public delegate string BookDetails(Book B);
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>
            {
                new Book("ISBN1", "OOP ", new[] { "Ahmed Osama", "Kareem Osama" }, new DateTime(2020, 1, 1), 30),
                new Book("ISBN2", "Advanced C#", new[] { "Mohammed Elsayed" }, new DateTime(2022, 5, 15), 60)
            };

            Console.WriteLine("==================================");
            Console.WriteLine("My Delegate");
            //My Delegate
            BookDetails TitleDelegate = BookFunction.GetTitle;
            LibraryEngine.ProcessBooks(books, TitleDelegate);

            Console.WriteLine("==================================");
            Console.WriteLine("Func Delegate");

            //Built in Delegate (Func)
            Func<Book, string> AuthorsDelegate = BookFunction.GetAuthors;
            LibraryEngine.ProcessBooks(books, new BookDetails(AuthorsDelegate)); //Convert Func to delegate

            Console.WriteLine("==================================");
            Console.WriteLine("Anonymous Delegate");
            //Anonymous Method
            BookDetails ISBNDelegate = delegate (Book B) 
            {
                return $"ISBN: {B.ISBN}"; 
            };

            LibraryEngine.ProcessBooks(books, ISBNDelegate);

            Console.WriteLine("==================================");
            Console.WriteLine("Lambda Expression");
            //Lambda Expression (Goes To)
            BookDetails PubDateDelegate = B => $"Publication Date: {B.PublicationDate.ToShortDateString()}";
            LibraryEngine.ProcessBooks(books, PubDateDelegate);

        }
    }
}
