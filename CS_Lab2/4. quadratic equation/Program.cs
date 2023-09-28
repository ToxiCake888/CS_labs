using System;
class SUSSY
{
    static void Main()
    {
        Console.Write("Кэфы сюда отдал: ");
        string[] input_massive = Console.ReadLine().Split(' ');
        double a = Convert.ToInt32(input_massive[0]);
        double b = Convert.ToInt32(input_massive[1]);
        double c = Convert.ToInt32(input_massive[2]);

        double d = b * b - 4 * a * c;
        if (d == 0)
        {
            Console.Write("X1 = X2 = ");
            Console.Write(-b / 2.0 / a);
        }
        else if(d>0)
        {
            Console.Write("x1 = ");
            Console.WriteLine((- b + Math.Sqrt(d))/(2*a));
            Console.Write("x2 = ");
            Console.WriteLine((-b - Math.Sqrt(d)) / (2 * a));
        }
        else
        {
            Console.WriteLine("Корней при D<0 нет");
        }
    }
}