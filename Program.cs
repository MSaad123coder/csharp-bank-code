
using System;
using System.Diagnostics.CodeAnalysis;
using System;
using System.Collections.Generic;
using ConsoleApp1;
namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            var account=new Bankaccount("Kendra",10000);
            Console.WriteLine($"ACCOUNT {account.Number} WAS CREATED FOR{account.Owner} WITH {account.Balance}");
            account.withdrawl(120,DateTime.Now,"Hammock");
            Console.WriteLine(account.Balance);
            Console.WriteLine(account.GetAccountHistory());
           


        }
    }
}


    



