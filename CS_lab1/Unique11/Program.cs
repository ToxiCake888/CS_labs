class sus
{
    static void Main()
    {

        double x = 6.251, y = 0.827, z = 25.001, b_example = 0.7121, b;
        b = (Math.Pow(y, Math.Pow(Math.Abs(x), 1.0 / 3))) + (Math.Pow(Math.Cos(y * (Math.Abs(x-y)-(1.0+(Math.Pow(Math.Sin(z),2))/Math.Pow(x+y, 0.5)))/ (Math.Pow(Math.Abs(x-y)+x*0.5, 3))),3));
        Console.WriteLine(b);
        Console.WriteLine(b_example);

        //Console.WriteLine(Math.Pow(3, 2));
    }
}