using System;

namespace BankAccount2
{
    class Program
    {
        static void Main(string[] args)
        {
            var bankAcc = new BankAccount();
            bankAcc.Balance = 255.65;
            bankAcc.Id = 35;

            Console.WriteLine($@"BancAccount ID: {bankAcc.Id}
Balance: {Math.Abs(bankAcc.Balance)}" );
        }
    }
}
