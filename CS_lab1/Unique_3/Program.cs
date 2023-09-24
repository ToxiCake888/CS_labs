class Main_program
{
    static void Main()
    {
        string v_string;
        double x = 3.74 * Math.Pow(10, -2), y = -0.825, z = 0.16 * Math.Pow(10, 2), v_example = 1.0553, v;
        v = (1.0 + Math.Pow(Math.Sin(x + y), 2)) * Math.Pow(x, Math.Abs(y)) / (Math.Abs( x - 2*y/(1.0 + Math.Pow(x , 2) * Math.Pow(y , 2)))) + Math.Pow(Math.Cos(Math.Atan(1.0 / z)), 2);
        Console.Write("Пример: ");
        Console.WriteLine(v_example);
        Console.Write("Рассчетное значение: ");
        v_string = (Convert.ToString(v)).Substring(0, 6);
        Console.WriteLine(v_string);
    }
}