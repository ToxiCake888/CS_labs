class sus
{
    static void Main()
    {
        Console.Write("insert side: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("P = ");
        double p = Convert.ToDouble(Console.ReadLine());
        Console.Write("Other sides: ");
        Console.Write((p-a)/2.0);
    }
}