class dumb_task
{
    static void Main()
    {

        Console.Write("Chislo bistro!!!: ");
        double contribution = Convert.ToDouble(Console.ReadLine());
        if (contribution < 18000)
        {
            Console.Write("Итоговая цена: ");
            contribution= contribution*0.99;
        }
        else if (contribution < 30000)
        {
            Console.Write("Итоговая цена: ");
            contribution= contribution*0.95;
        }
        else
        {
            Console.Write("Итоговая цена: ");
            contribution = contribution*0.9;
        }

        Console.Write("UR SOCIAL RANK(0-5)!!!: ");
        int rank = Convert.ToInt16(Console.ReadLine());
        switch (rank)
        {
            case 0:
                break;
            case 1:
                contribution = contribution - 200;
                break;
            case 2:
                contribution = contribution - 400;
                break;
            case 3:
                contribution = contribution - 600;
                break;
            case 4:
                contribution = contribution - 700;
                break;
            case 5:
                contribution = contribution - 800;
                break;
        }



        Console.WriteLine(contribution);
    }
}