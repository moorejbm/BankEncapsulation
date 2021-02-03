using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount ba = new BankAccount();

            Console.WriteLine("How much $$ do you want to deposit?");
            double amountTODeposit = double.Parse(Console.ReadLine());

            ba.Deposit(amountTODeposit);
            double userBalance = ba.GetBalance();

            Console.WriteLine($"Your current balance is: {userBalance, 0:c}");

        }
    }
}
