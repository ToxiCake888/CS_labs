class sus
{
    static void Main()
    {
        Console.Write("num = ");
        string num = Console.ReadLine();
        int a = Convert.ToInt32(num[0] - '0');
        int b = Convert.ToInt32(num[1] - '0');
        int c = Convert.ToInt32(num[2] - '0');
        int d = a + b + c;
        Console.Write("Multiplication = ") ;
        Console.WriteLine(a*b*c);
        Console.Write("Summ = ");
        Console.WriteLine(d);
    }
}
