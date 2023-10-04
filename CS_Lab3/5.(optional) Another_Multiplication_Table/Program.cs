
class tfgrtghyujikolo
{
    static void Main()
    {
        int attempts_right = 0;
        int attempts_wrong = 0;
        double attempts = 0.0;
        start:
        Random rnd = new Random();
        int a = rnd.Next(0, 10);
        int b = rnd.Next(0, 10);

        Console.Write(a + " " + "* " + b + " = ");
        int guess = Convert.ToInt32(Console.ReadLine());
        attempts += 1;
        if (guess == a * b)
        {
            attempts_right += 1;
            Console.WriteLine("MEGAHAROSH");          
            Console.Write("ANOTHER ONE?(Y/N) ");
            string retry = Console.ReadLine();

            if (retry == "Y")
            {
                goto start;
            }
            else
            {
                goto end;
            }
        }
        else
        {
            attempts_wrong += 1;
            Console.WriteLine("MISTAKE");
            Console.Write("ANOTHER ONE?(Y/N) ");
            string retry = Console.ReadLine();
            if (retry == "Y")
            {
                goto start;
            }
            else
            {
                goto end;
            }
        }

        end:;
        Console.WriteLine("GG");                                                                                //END STATS AND DIV ON 0 CHECK

        Console.WriteLine("attempts = " + attempts);                                                            //DUMBASS ON DEV
        Console.WriteLine("wrong = " + attempts_wrong + "( " + attempts_wrong / attempts *100 + " %)");
        Console.WriteLine("right = " + attempts_right + "( " + attempts_right / attempts * 100 + " %)");
                                                          

    }
}