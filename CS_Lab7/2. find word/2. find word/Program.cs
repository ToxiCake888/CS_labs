class sus
{
    static void Main()
    {
        Console.WriteLine("insert text: ");
        string text = Console.ReadLine();
        Console.WriteLine("insert word: ");
        string word = Console.ReadLine();

        int index = text.IndexOf(word);
        if(index == -1)
        {
            Console.WriteLine("does not found " + word);
        }
        else
        {
            Console.WriteLine("founded");
        }
    }
}