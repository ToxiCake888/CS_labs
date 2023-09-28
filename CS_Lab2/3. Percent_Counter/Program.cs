class Ia_kak_Tomas_Shelby
{
    static void Main()
    {
        Console.Write("Chislo bistro!!!: ");
        double contribution = Convert.ToDouble(Console.ReadLine());
        if (contribution < 100)
        {
            Console.Write("Твой вкид вырастет до: ");
            Console.WriteLine(Convert.ToString(contribution * 1.05));
        }
        else if (contribution < 200)
        {
            Console.Write("Твой вкид вырастет до: ");
            Console.WriteLine(Convert.ToString(contribution * 1.07));
        }
        else
        {
            Console.Write("Твой вкид вырастет до: ");
            Console.WriteLine(Convert.ToString(contribution * 1.1));
        }
    }
}