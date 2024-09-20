namespace BankAccount
{   // Vithunan Inthiranathan
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instansiera bankAccount klassen och testa den
            //upp1();
            upp2();
        }

        static void upp1()
        {
            Employee employee = new Employee("Jane", "Smith");
            employee.Sal = 3000;
            Console.WriteLine($"Annual Salary: {employee.GetAnnualSalary()}");
            employee.GiveRaise(10);
            Console.WriteLine($"New Monthly Salary: {employee.Sal}");
            Console.WriteLine($"New Annual Salary: {employee.GetAnnualSalary()}");

        }
        static void upp2()
        {
            BankAccount account = new BankAccount("123456789", "John Doe", 1000);
            account.Deposit(500);
            account.Withdraw(2000);
            account.DisplayBalance();

        }
    }
}
