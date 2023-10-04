class again_little_change_but_new_prog
{
    static void Main()
    {

        Random rnd = new Random();
        int number = rnd.Next(0, 10);
        int guess_counter = 0;
    check:
        Console.Write("guess num(1-10) ");
        int guess = Convert.ToInt16(Console.ReadLine());
        
        
        if (guess==number)
        {
            guess_counter +=1;
            Console.WriteLine("MEGAHAROSH");
            Console.WriteLine("attemps " + guess_counter);
            Console.Write("ANOTHER ONE?(Y/N) ");
            string retry = Console.ReadLine();
            if (retry == "Y")
            {
                Main();
            }
        }
        else
        {
            guess_counter+= 1;
            if (guess > number)
            {
                Console.WriteLine("too big");
                
            }
            else
            {
                Console.WriteLine("too small");
                
            }
            goto check;
        }
        Console.WriteLine("GG");            
    }
}           //boring