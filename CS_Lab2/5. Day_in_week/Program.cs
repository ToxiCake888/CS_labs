class Useless_boring_laba
{
    static void Main()
    {
        Console.Write("Number from 1-7");
        int day_num = Convert.ToInt32(Console.ReadLine());
        switch(day_num)
        {
            case 1:
                Console.WriteLine("понедельник");
                break;
            case 2:
                Console.WriteLine("вт");
                break;
            case 3:
                Console.WriteLine("среда");
                break;
            case 4:
                Console.WriteLine("чт");
                break;
            case 5:
                Console.WriteLine("пт");
                break;
            case 6:
                Console.WriteLine("сб");
                break;
            case 7:
                Console.WriteLine("вскр");
                break;
            default:
            Console.WriteLine("durak");
            break;

        }

    }
}