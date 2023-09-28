class Even_Check{
    static void Main()
    {
        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number % 2 == 0)
        {
            Console.WriteLine("Число четное , четкое 10/10 кароч");
        }
        else
        {
            Console.WriteLine("Число нечетное , не уважаю такие");
        }
    }
}