class SUS
{
    static void Main()
    {
        char LastChar = '3';

        Console.Write("Ввести число: ");
        string number = Console.ReadLine();
        if  (number.Length == 2)           // ВОПРОС: ПОЧЕМУ ОНО ЖАЛУЕТСЯ ЕСЛИ ПИСАТЬ ЧЕРЕЗ and ???????????????
        {
            Console.WriteLine("dvuhznacnoe");
        }
        else
        {
            Console.WriteLine("Ne dvuhznacnoe");
        }
        if (number[number.Length-1]==LastChar)
        {
            Console.WriteLine("3 at end");
        }
        else
        {
            Console.WriteLine("not 3 at end");
        }

    }
}