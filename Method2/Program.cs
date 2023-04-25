using Module._17.Patterns.Practice;
using System;

namespace Method2
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account() { Balance = 288134, Type = "Regular" };
            var regularCalculator = new RegularAccountCalculator();
            regularCalculator.CalculateInterest(account);
            Console.WriteLine(account.Interest);

            Console.WriteLine();

            Account account2 = new Account() { Balance = 1000, Type = "Salary" };
            var salaryCalculator = new SalaryAccountCalculator();
            salaryCalculator.CalculateInterest(account2);
            Console.WriteLine(account2.Interest);
        }
    }
}
