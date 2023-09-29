class sus
{
    static void Main()
    {
        string c;
        Console.Write("a = ");
        string a = Console.ReadLine();
        Console.Write("b = ");
        string b = Console.ReadLine();
        c = a;
        a = b;
        b = c;
        Console.WriteLine("b = "+b);
        Console.WriteLine("a = " + a);
    }
}