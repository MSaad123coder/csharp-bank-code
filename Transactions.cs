using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Transactions
    {
        private DateTime date;
        private string note;

        public decimal Amount { get; }
        public decimal Datetime { get; }
        public string Notes { get; }

        public Transactions(decimal amount,decimal date,string note) {
            Amount = amount;
            Datetime = date;
            Notes = note;
        }

        public Transactions(decimal amount, DateTime date, string note)
        {
            Amount = amount;
            this.date = date;
            this.note = note;
        }
    }
}
