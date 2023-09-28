class time2126
{
    static void Main()
    {
        Console.Write("DAI CHISLO ");
        int x = Convert.ToInt16(Console.ReadLine());
        int y;
        if (x == 0)
        {
            y = 0;
        }
        else if (x > 0)
        {
            y = -2 * x + 1;
        }
        else
        {
            y = 3 * Math.Abs(x) - 1;
        }
        Console.WriteLine(y);
    }
}