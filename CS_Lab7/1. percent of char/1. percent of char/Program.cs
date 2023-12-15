class sus
{
    static void Main()
    {
        List<string> strings = new List<string>();

        Console.WriteLine("line: ");
        string line = Console.ReadLine();
        line.ToLower();
        Console.WriteLine("letter: ");
        char letter = Convert.ToChar(Console.ReadLine());

        float linelenght = line.Length;

        string[] arr = line.Split(new char[] { letter });

        foreach(var item in arr)
        {
            strings.Add(item);
        }
        float counter = strings.Count();
        Console.Write("answer: ");
        Console.WriteLine(linelenght/counter/100);
        
    }
}

