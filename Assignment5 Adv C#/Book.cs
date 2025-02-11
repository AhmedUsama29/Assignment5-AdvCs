using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_Adv_C_
{
    public class Book
    {

        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }

        public Book(string iSBN, string title, string[] authors, DateTime publicationDate, decimal price)
        {
            ISBN = iSBN;
            Title = title;
            Authors = authors;
            PublicationDate = publicationDate;
            Price = price;
        }
        public override string ToString()
        {

            return $"ISBN: {ISBN}, Title: {Title}, Authors: {string.Join(", ", Authors)}, Publication Date: {PublicationDate}, Price: {Price}";
        }
    }

    class BookFunction
    {

        public static string GetTitle(Book B)
        {
            return $"Title: {B.Title}";
        }
        public static string GetAuthors(Book B)
        {
            return $"Authors: {string.Join(", ", B.Authors)}";
        }
        public static string GetPrice(Book B)
        {
            return $"Price: {B.Price}";
        }

    }
}
