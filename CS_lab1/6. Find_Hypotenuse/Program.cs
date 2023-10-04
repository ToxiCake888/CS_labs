class sus
{
    static void Main()
    {
        Console.Write("P = ");
        double p = Convert.ToDouble(Console.ReadLine());
        Console.Write("Insert first cathetus: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Insert second cathetus: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Hypothenuse = ");
        Console.Write(p - a - b);
    }
}