using System.Collections;
using System;

class sas
{
    static void Main()
    {
        List<string> arr = new List<string>();

        Console.WriteLine("arr lenght: ");
        int len = Convert.ToInt32(Console.ReadLine());
        int counter = 0;
        for (int i = 0; i < len; i++)
        {
            string input = Console.ReadLine();
            arr.Add(input);
            int num;
            bool result = int.TryParse(input,out num);
            if (result == true)
            {
                counter += 1;
            }
        }
        Console.WriteLine("int: " + counter);
        Console.WriteLine("string: " + (len-counter));
    }
}