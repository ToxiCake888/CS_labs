using System;
class gigi
{
    static void Main()
    {
        int[] arr = new int[10];
        for (int i = 0; i < 10; i++)
        {
            
            Random number = new Random();
            arr[i] = number.Next(0,101);
        }
        foreach (int i in arr)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine(" ");
        Array.Sort(arr);
        foreach (int i in arr)
        {
            Console.WriteLine(i);
        }
    }
}