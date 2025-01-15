using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Bankaccount
    {
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {

                    balance += item.Amount;
                }
                return balance;
            }
        }

        private static int Bankaccountseed = 2334;
        private List<Transactions> allTransactions = new List<Transactions>();
        public Bankaccount(String name, decimal initialbalance)
        {
            this.Owner = name;
            MakeDeposit(initialbalance, DateTime.Now, "initialbalance");


            this.Number = Bankaccountseed.ToString();
            Bankaccountseed++;
        }
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of Withdrael not available");
            }
            var deposit = new Transactions(amount, date, note);
            allTransactions.Add(deposit);
        }
        public void withdrawl(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of Withdrawal must be positive");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            var withdrawal = new Transactions(-amount, date, note);
            allTransactions.Add(withdrawal);
        }
        public String  GetAccountHistory()
        {
            var report=new StringBuilder();
            foreach(var items in allTransactions)
            {
                report.AppendLine("$ { items.Date}, { items.Amount},{ items.Notes}");
            }
            return report.ToString();
        }
    }
}
