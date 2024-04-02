using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationEx
{
    public class BankAccount
    {
        private decimal balance;

        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= balance)
                balance -= amount;
            else
                Console.WriteLine("Insufficient funds.");
        }

        public decimal GetBalance()
        {
            return balance;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
          //creating object
        BankAccount bankAccount = new BankAccount(); //Encapsulation: Binding into one object

            bankAccount.Deposit(1000);
            bankAccount.Withdraw(5000);

            decimal balance=bankAccount.GetBalance();
            Console.WriteLine("Available Balance :"+balance);
        }
    }
}
