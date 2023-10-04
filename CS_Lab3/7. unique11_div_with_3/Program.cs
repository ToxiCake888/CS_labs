using System.Diagnostics.Metrics;

class aaaaaaaaa
{
    static void Main()
    {
        Console.Write("diapozon start ");
        int start = Convert.ToInt32(Console.ReadLine());
        Console.Write("diapozon end ");
        int end = Convert.ToInt32(Console.ReadLine());
        int counter = 0, sum = 0;

        for (int k = start; k < end; k++)
        {                                 
            if (k%3==0)
            {
                counter += 1;
                sum += k;
                Console.WriteLine(k);
            }
        }
        Console.Write("sum ");
        Console.WriteLine(sum);
        Console.Write("kolichestvo ");
        Console.WriteLine(counter);
    }
}