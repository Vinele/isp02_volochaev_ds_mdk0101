using System;

namespace ConsoleApp1
{
    class Book
    {
        public string Title { get; set; }
        public string [] AuthorsList { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            string res = Title + " " + Price + " ";

            foreach (var author in AuthorsList)
                res += author + " ";


            return res;
        }

        public Book(string bookTitle, string [] authorsList, int BookPrice)
        {
            Title = bookTitle;
            AuthorsList = authorsList;
            Price = BookPrice;
        }
    }
}
