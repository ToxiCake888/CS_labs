class dumb_task
{
    static void Main()
    {

            Console.Write("Chislo bistro!!!: ");
            double contribution = Convert.ToDouble(Console.ReadLine());
            if (contribution < 18000)
            {
                Console.Write("Итоговая цена: ");
                Console.WriteLine(Convert.ToString(contribution * 0.99));
            }
            else if (contribution < 30000)
            {
                Console.Write("Итоговая цена: ");
                Console.WriteLine(Convert.ToString(contribution * 0.95));
            }
            else
            {
                Console.Write("Итоговая цена: ");
                Console.WriteLine(Convert.ToString(contribution * 0.9));

    }
}
