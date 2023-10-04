class amdnasjdbhasnfij
{
    static void Main()
    {
        Console.Write("diapozon start ");
        int start = Convert.ToInt32(Console.ReadLine());
        Console.Write("diapozon end ");
        int end = Convert.ToInt32(Console.ReadLine());


        for (int k = start; k < end; k++)
        {
            int num = k;          //elementery test ctr+c ctr+v
            bool check = true;
            
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {

                    check = false;
                }
            }
            if (check == true)
            {
                Console.WriteLine(k);
            }
        }
    }
}