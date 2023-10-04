class sadfgghjklkjhgfds
{
    static void Main()
    {
        Console.Write("contribution is ");
        double contribution = Convert.ToDouble(Console.ReadLine());
        Console.Write("mounth quantity is ");
        int mounths = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i<mounths; i++)
        {
            contribution = contribution * 1.04;
        }
        Console.Write("final contribution is ");
        Console.Write(contribution);
    }
}