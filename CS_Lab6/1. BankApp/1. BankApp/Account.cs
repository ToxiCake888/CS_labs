using System;
using System.Collections.Generic;


namespace _1._BankApp
{
    internal class Account
    {

        public string Owner{ get; set; }
        public long Number { get;}

        private long NumberSeed = 2003123400;
        public decimal Balance { get 
                { decimal balance = 0;
                foreach (var item in persontransactions) { balance += item.Value; }
                return balance;} 
            }
        List<transaction> persontransactions = new List<transaction>();
        public Account(string Name, decimal FirstBalance)
        {
            this.Owner = Name;
            NumberSeed += 1;
            this.Number = NumberSeed;
            AddMoney(FirstBalance , DateTime.Now , "start balance");
        }

        public void AddMoney(decimal addvalue , DateTime date , string note)
        {
            if(addvalue > 0)
            {
                transaction deposit = new transaction(addvalue , date , note);
                persontransactions.Add(deposit);
            }
            else
            {
                Console.WriteLine("add cant be less then 0");
            }
        }
        public void WithdrawingMoney(decimal widthvalue , DateTime date, string note)
        {
            if(Balance-widthvalue < 0)
            {
                Console.WriteLine("balance cant go less 0");
            }
            else
            {
                transaction width = new transaction(-widthvalue , date , note);
                persontransactions.Add(width);
            }
        }
        public void TransferMoney() 
        {

        }

        public void ShowHistory()
        {
            foreach(var item in persontransactions)                                                 // b t
            {
                Console.WriteLine("value: " + item.Value + "\t" + "date: " + item.Date +"\t"+"balance: " + "note: " + item.Note + "\t");
            }
        }
    }

    class transaction
    {
        public decimal Value { get; }
        public DateTime Date { get; }
        public string Note { get; }

        public transaction(decimal addvalue, DateTime transactiondate, string note)
        {
            this.Value += addvalue;
            this.Date = transactiondate;
            this.Note = note;
        }

    }
}


