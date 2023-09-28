



class a_eto_uzhe_interesno
{
    static void Main()
    {
        Random rnd = new Random();
        int a = rnd.Next(1, 10);
        int b = rnd.Next(1, 10);        //посмотрите на меня я верхняя граница диапозона эксклюзивное(а не инклюзивное) значение такое особенное
        Console.Write(b);
        Console.Write(" * ");
        Console.Write(a);
        Console.Write(" = ");
        int input = Convert.ToInt16(Console.ReadLine());
        if (input == a*b)
        {
            Console.WriteLine("Верно");
        }
        else
        {
            Console.WriteLine("Не верно");
        }
        Main();
    }
}                           //so ez