namespace Assignment5_Adv_C_
{
    public class Program
    {
        //delegate declaration
        public delegate string BookDetails(Book B);

        static void Main(string[] args)
        {
            #region List
            List<Book> books = new List<Book>
            {
                new Book("ISBN1", "OOP ", new[] { "Ahmed Osama", "Kareem Osama" }, new DateTime(2020, 1, 1), 30),
                new Book("ISBN2", "Advanced C#", new[] { "Mohammed Elsayed" }, new DateTime(2022, 5, 15), 60)
            };
            #endregion

            #region My User-Defind Delegate
            Console.WriteLine("==================================");
            Console.WriteLine("My Delegate");

            BookDetails TitleDelegate = BookFunction.GetTitle;
            LibraryEngine.ProcessBooks(books, TitleDelegate);
            #endregion

            #region Built-in (Func) Delegate
            Console.WriteLine("==================================");
            Console.WriteLine("Func Delegate");

            Func<Book, string> AuthorsDelegate = BookFunction.GetAuthors;

            //i need to change the method to accept (Func<Book, string> fPtr) instead of (BookDetails fPtr)
            //so i used this way to pass the method : new BookDetails(AuthorsDelegate)

            LibraryEngine.ProcessBooks(books, new BookDetails(AuthorsDelegate));

            #endregion

            #region Anonymous Method
            Console.WriteLine("==================================");
            Console.WriteLine("Anonymous Delegate");

            BookDetails ISBNDelegate = delegate (Book B)
            {
                return $"ISBN: {B.ISBN}";
            };

            LibraryEngine.ProcessBooks(books, ISBNDelegate);

            #endregion

            #region Lambda Expression (Goes To)
            Console.WriteLine("==================================");
            Console.WriteLine("Lambda Expression");

            BookDetails PubDateDelegate = B => $"Publication Date: {B.PublicationDate.ToShortDateString()}";
            LibraryEngine.ProcessBooks(books, PubDateDelegate); 
            #endregion

        }
    }
}
