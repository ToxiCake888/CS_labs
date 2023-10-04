class amdnasjdbhasnfij
{
    static void Main()
    {
        Console.Write("number dai ");
        int num = Convert.ToInt32(Console.ReadLine());   
        bool check=true;
        for (int i = 2; i < num; i++)                  
        {
            if (num % i == 0)
            {
                
                check = false;
            }
        }
        Console.Write("is elementery? ");
        Console.WriteLine(check);
    }
}