class Circle
{
    static void Main()
    {
        Console.Write("R = ");
        int r = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("L = "+r*2*3.14);
        Console.WriteLine("S = " + r*r * 3.14);
        Console.WriteLine("V = " + (4.0 / 3) * r * r * r *3.14);
    }
}