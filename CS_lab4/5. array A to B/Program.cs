class xdd
{
    static void Main()
    {
        int[] A = new int[20];
        int[] B = new int[20];
        for (int i = 0; i < 20; i++)
        {
            Random rnd = new Random();
            int number = rnd.Next(0, 1000);
            A[i] = number;
            if (number <= 888)
            {
                B[i] = number;
            }
        }
        Console.WriteLine("A ");
        foreach (int i in A)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("B ");
        Array.Sort(B);
        Array.Reverse(B);
        foreach (int i in B)
        {
            Console.WriteLine(i);
        }
    }
}