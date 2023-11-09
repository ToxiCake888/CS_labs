using System;
class gigi
{
    static void Main()
    {
        int[] arr = new int[10];
        for (int i = 0; i < 10; i++)
        {
            Random rnd = new Random();
            int number = rnd.Next(0, 101);
            arr[i] = number;
        }

        foreach (int i in arr)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("num search in array:");
        int num = Convert.ToInt32(Console.ReadLine());

        bool value = Array.Exists(arr, element => element == num);
        int index = Array.IndexOf(arr ,num);
        if (value == true)
        {
            Console.WriteLine("Found");
            Console.WriteLine(index+1);
        }
        else
        {
            Console.WriteLine("Not Found");
        }
    }
}