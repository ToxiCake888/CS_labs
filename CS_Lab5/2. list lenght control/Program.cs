using System.Collections;

class sas
{
    static void Main()
    {
        ArrayList arr = new ArrayList();

        Console.WriteLine("arr lenght: ");
        int len = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < len; i++)
        {
            string input = Console.ReadLine();
            arr.Add((string)input);
            
        }

        foreach(var i in arr)
        {
            Console.WriteLine(i);
        }
    }
}