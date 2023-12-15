using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._BookStore
{
    internal class Book
    {
        public int cost { get; }
        public string name { get; }
        public string author { get; }

        
        public Book(int cot , string nam , string aut) 
        {
            this.author=aut;
            this.cost = cot;
            this.name = nam;
        }
        List<test> library = new List<test>();

        public void AddBook(int cost, string name, string author)
        {
            test newbook = new test(cost, name, author);
            library.Add(newbook);
        }

        public void ShowBooks()
        {
            int finalcost = 0;
            foreach (var book in library)
            {
                Console.WriteLine("Title: "+this.name +"\t"+"Author: " + this.author +"\t"+ "cost: " + this.cost);
                finalcost +=this.cost;
            }
            Console.WriteLine("Full cost: " + finalcost);
        }

        public void CheaperThen(int money)
        {
            foreach(test item in library)
            {
                if(item.cost <= money)
                {
                    Console.WriteLine("Title: " + this.name + "\t" + "Author: " + this.author + "\t" + "cost: " + this.cost);
                }
            }
        }
    }
    class test
    {
        public int cost;
        string name;
        string author;
        public test(int cost , string name , string author)
            {
            this.cost = cost;
            this.author = author;
            this.name = name;

            }
    }

}
