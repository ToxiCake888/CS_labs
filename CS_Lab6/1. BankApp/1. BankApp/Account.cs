using System;
using System.Collections.Generic;


namespace _1._BankApp
{
    internal class Account
    {
        string Name{ get; }
        string Number { get;}
        int Balance { get; set; }
        public void AddMoney()
        {
            Console.Write("User Name:");
            string name = Console.ReadLine();
            Console.Write("Number:");
            string number = Console.ReadLine();

        }
        public void WithdrawingMoney()
        {

        }
        public void TransferMoney() 
        {

        }
    }
}
