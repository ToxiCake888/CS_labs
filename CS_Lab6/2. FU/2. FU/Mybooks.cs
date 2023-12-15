using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _2._FU
{
    internal class Mybooks
    {
        Book mybook { get; set; }
        public Mybooks() {}

        List<Book> library= new List<Book>();


        public void AddBook(int cost, string title, string author)
        {
            Book mybook = new Book( cost,  title, author);
            library.Add(mybook);
        }

        public void ShowBooks()
        {
            int finalcost = 0;
            foreach (Book book in library)
            {
                Console.WriteLine("Title: " + book.title + "\t" + "Author: " + book.author + "\t" + "cost: " + book.cost);
                finalcost += book.cost;
            }
            Console.WriteLine("Full cost: " + finalcost);
        }

        public void CheaperThen(int money)
        {
            foreach (Book item in library)
            {
                if (item.cost <= money)
                {
                    Console.WriteLine("Title: " + item.title + "\t" + "Author: " + item.author + "\t" + "cost: " + item.cost);
                }
            }
        }

    }

    public class Book
    {
        public string title { get;  }
        public int cost { get;}
        public string author { get; }

        public Book(int cost, string title, string author)
        {
            this.cost = cost;
            this.author=author;
            this.title = title;
        }

    }
}
