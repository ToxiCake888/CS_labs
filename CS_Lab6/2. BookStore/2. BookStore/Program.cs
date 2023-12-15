using _2._BookStore;
using System;
class skibidi_prog
{
    static void Main()
    {
        int option;

        Book testbook = new Book(99, "how to basic","somebody" );
        
        do
        {
            Console.WriteLine("0-end , 1-add book , 2-show all books , 3-cheaper then: ");
            option=Convert.ToInt32(Console.ReadLine());

            switch(option)
            {
                case 0:
                    {
                        option = 0;
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("cost: ");
                        int c = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("author: ");
                        string a = Console.ReadLine();
                        Console.WriteLine("name: ");
                        string n = Console.ReadLine();
                        testbook.AddBook(c, n, a);
                        break;
                    }
                case 2:
                    {
                        testbook.ShowBooks();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("cheaper then: ");
                        int costchecker = Convert.ToInt32(Console.ReadLine());  
                        testbook.CheaperThen(costchecker);
                        break;
                    }
            }



        }while (option!=0);
    }
}