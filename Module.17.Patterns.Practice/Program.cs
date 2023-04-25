using Module._17.Patterns.Practice.Accounts;

namespace Module._17.Patterns.Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            calculator.CalculateInterest(new SalaryAccount(balance: 1000));
            calculator.CalculateInterest(new RegularAccount(balance: 504500));

        }
    }
}
