class sus
{
    static void Main()
    {
        Console.WriteLine("insert text");
        string text = Console.ReadLine();
        string[] arr = text.Split(' ');
        int counter = arr.Length;
        Console.WriteLine(counter);
    }
}