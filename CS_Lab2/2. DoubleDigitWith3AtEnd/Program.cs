class SUS
{
    static void Main()
    {
        char LastChar = '3';

        Console.Write("Ввести число: ");
        string number = Console.ReadLine();
        if (LastChar == number[1])                // ВОПРОС: ПОЧЕМУ ОНО ЖАЛУЕТСЯ ЕСЛИ ПИСАТЬ ЧЕРЕЗ and ???????????????
            if (number.Length == 2)
            {
                Console.WriteLine("Число двухзначное,кончается на 3 , четкое 10/10 кароч");
            }
            else
            {
                Console.WriteLine("Число плохое не уважаю такие");
            }
        else
        {
            Console.WriteLine("Число плохое не уважаю такие");
        }
    }
}