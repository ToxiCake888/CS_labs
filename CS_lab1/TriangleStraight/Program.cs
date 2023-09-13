using System;
class sus
{
    static void Main()
    {
        Console.Write("insert first cathetus ");
        double a = Int32.Parse(Console.ReadLine());
        Console.Write("insert second cathetus ");
        double b = Int32.Parse(Console.ReadLine());

        double c = Math.Sqrt(a*a+b*b);

        Console.Write("P = ");
        Console.WriteLine(a + b + c);
        Console.Write("S = ");
        Console.Write(a*b*0.5);
    }
}