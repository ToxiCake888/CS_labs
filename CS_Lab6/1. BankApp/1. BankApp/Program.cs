using _1._BankApp;

class prog
{
    static void Main()
    {
        int command = 0;

        Console.WriteLine("Creating account...");
        Console.WriteLine("Owner name:");
        string AccName = Console.ReadLine();
        Console.WriteLine("start balance: ");
        decimal StartBalance = Convert.ToDecimal(Console.ReadLine());
        Account acc = new Account(AccName , StartBalance);

        Console.WriteLine("Creating account ended");
        Console.WriteLine("Owner: " + acc.Owner);
        Console.WriteLine("Balance: " + acc.Balance);
        Console.WriteLine("Number: " + acc.Number);

        do
        {
            Console.WriteLine("0. end programm");
            Console.WriteLine("1. widthdraw money");
            Console.WriteLine("2. add money");
            Console.WriteLine("3. history");
            Console.WriteLine("option: ");
            command = Convert.ToInt16(Console.ReadLine());
            switch (command)
            {
                case 0:
                    {
                        command = 0;
                        break;
                    }
                case 1:
                    {
                        Console.Write("How much widthdraw? ");
                        decimal WidthdrawValue = Convert.ToDecimal(Console.ReadLine());
                        Console.Write("Note: ");
                        string transactionnote = Console.ReadLine();
                        acc.WithdrawingMoney(WidthdrawValue,DateTime.Now ,transactionnote);
                        break;
                    }
                case 2:
                    {
                        Console.Write("How much add? ");
                        decimal addValue = Convert.ToDecimal(Console.ReadLine());
                        Console.Write("Note: ");
                        string transactionnote = Console.ReadLine();
                        acc.AddMoney(addValue, DateTime.Now, transactionnote);
                        break;
                    }
                case 3:
                    {
                        acc.ShowHistory();
                        break;
                    }


            }
        } while (command != 0);


    }
}