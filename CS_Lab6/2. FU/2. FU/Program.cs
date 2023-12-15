using _2._FU;
using System;
class skibidi_prog
{
    static void Main()
    {
        int option;

        Mybooks mybooks = new Mybooks();

        do
        {
            Console.WriteLine("0-end , 1-add book , 2-show all books , 3-cheaper then: ");
            option = Convert.ToInt32(Console.ReadLine());

            switch (option)
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
                        mybooks.AddBook(c, n, a);
                        break;
                    }
                case 2:
                    {
                        mybooks.ShowBooks();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("cheaper then: ");
                        int costchecker = Convert.ToInt32(Console.ReadLine());
                        mybooks.CheaperThen(costchecker);
                        break;
                    }
            }



        } while (option != 0);
    }
}