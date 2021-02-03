using System;

namespace BankUnitTests
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount ba = new BankAccount("Mr. Bryan Walton", 11.99);
            Console.WriteLine("Initial balance is ${0}", ba.Balance);
            Console.WriteLine("Credit: 5.77");
            Console.WriteLine("Debit: 11.22");
            ba.Credit(5.77);
            ba.Debit(11.22);
            Console.WriteLine("Current balance is ${0}", ba.Balance);
        }
    }
}
