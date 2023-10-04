class prog
{
    static void Main()
    {
        Console.Write("insert start ");
        string a=Console.ReadLine();

        Console.Write("insert end ");
        string b = Console.ReadLine();


        for (int i = Convert.ToInt32(a); i < Convert.ToInt32(b);  i++)
        {
            string i_str = Convert.ToString(i);
            if (i_str[i_str.Length-1] == '5')
            {
                Console.WriteLine(i);
            }
               
        }
    }
}