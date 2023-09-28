class TIRED
{
    static void Main()
    {
        Console.Write("vvedi 2 chisla ");
        double a = Convert.ToDouble(Console.ReadLine());
        string a_str;

        if (a % 3.0 == 0.0)
        {
            Console.WriteLine("delitsa na 3");
        }
        else
        {
            Console.WriteLine("ne delitsa na 3");
        }

        a_str = Convert.ToString(a);
        if ('3' == a_str[a_str.Length-1])
        {
            Console.Write("KONCHAETSA NA 3");
        }
        else
        {
            Console.Write("NE KONCHAETSA NA 3");
        }

    }
}