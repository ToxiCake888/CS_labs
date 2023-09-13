class sus
{
    static void Main()
    {
        Console.Write("insert side: ");
        int a = Convert.ToInt16(Console.ReadLine());
        Console.Write("P = ");
        int p = Convert.ToInt16(Console.ReadLine());
        Console.Write("Other sides: ");
        Console.Write((p-a)/2.0);
    }
}