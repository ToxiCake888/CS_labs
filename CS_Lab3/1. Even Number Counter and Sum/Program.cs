class prog
{
    static void Main()
    {
        int sum = 0 ;
        for (int i = 2; i <= 100; i+=2) 
        {
            Console.WriteLine(i);
            sum += i;
        }
        Console.WriteLine(sum);
    }
}