class TIRED
{
    static void Main()
    {
        Console.Write("vvedi 2 chisla ");
        double a = Convert.ToDouble(Console.ReadLine());
        int b = Convert.ToInt16(Console.ReadLine());
        if (a % 9.0 == 0.0)
        {
            Console.WriteLine("delitsa na 9");
        }
        else
        {
            Console.WriteLine("ne delitsa na 9");
        }
        if (a % b == 0)
        {
            Console.Write("a / b");
            Console.WriteLine(a/b);
        }
        else
        {
            Console.Write("a / b ");
            Console.WriteLine(a/b);
            Console.Write("a % b ");
            Console.WriteLine(a % b);
        }
    }
}