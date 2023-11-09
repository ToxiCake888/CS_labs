using System.Collections;

class sus
{
    static void Main()
    {
        Console.WriteLine("privetstvie: ");
        ArrayList aboba = new ArrayList();
        aboba.Add(Console.ReadLine());

        
        for (int t = 0;t < 3; t++)
        {
            var rnd = new Random();
            aboba.Add(rnd.Next(1,100));
        }

        foreach(var i in aboba)
        {
            Console.WriteLine(i);
        }
    }
}