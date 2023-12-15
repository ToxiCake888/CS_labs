using System;
class sus
{
    static void Main()
    {
        Console.WriteLine("text: ");
        string text = Console.ReadLine();
        string[] list;
        list = text.Split(' ');

        Array.Sort(list, (x, y) => y.Length.CompareTo(x.Length));


        Console.WriteLine(list[0]);
        
    }
}