class SUS
{
    static void Main()
    {
        string b_string;
        double x = 6.251 , y = 0.827 , z = 25.001, b_example = 0.7121 , b , e = 2.718;
        b = Math.Pow(y , Math.Pow(Math.Abs(x), 1.0/3)) + Math.Pow(Math.Cos(y), 3) * ((Math.Abs(x-y)-(1.0 + Math.Pow(Math.Sin(z),2)))/(Math.Pow(e,Math.Abs(x-y)) + x/2));
        Console.WriteLine(b_example);
        b_string = (Convert.ToString(b)).Substring(0, 6);
        Console.WriteLine(b_string);
    }
}

