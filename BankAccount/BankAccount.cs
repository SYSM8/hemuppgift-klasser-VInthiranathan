using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Vithunan Inthiranathan
namespace BankAccount
{
    public class BankAccount
    {
        public string AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        public double Balance { get; set; }

        
        public BankAccount(string accNum, string accName, double amount)
        {
            AccountNumber = accNum;
            AccountHolder = accName;
            Balance = amount;

        }
        public double Deposit (double deposit)
        {
            Balance += deposit;
            Console.WriteLine($"Deposited: {deposit}, New balance: {Balance}");
            return Balance;
        }
        public double Withdraw (double withdraw)
        {
            if (withdraw <= Balance)
            {
                Balance -= withdraw;
                Console.WriteLine($"Withdrew: {withdraw}, New balance: {Balance}");
            }
            else
            {
                Console.WriteLine($"Your balance is not enough, Balance: {Balance}");
                Console.WriteLine("Try again with lesser amount");
            }
            return Balance;
        }
        public double DisplayBalance()
        {
            Console.WriteLine($"Balance: {Balance}");
            return Balance;
        }
    }
}
