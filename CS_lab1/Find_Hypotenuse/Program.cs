class sus
{
    static void Main()
    {
        Console.Write("P = ");
        int p = Convert.ToInt32(Console.ReadLine());
        Console.Write("Insert first cathetus: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Insert second cathetus: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Hypothenuse = ");
        Console.Write(p - a - b);
    }
}