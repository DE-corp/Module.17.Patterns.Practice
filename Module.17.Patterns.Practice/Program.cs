using System;

namespace Module._17.Patterns.Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var myAccount = new Account { Balance = 1000, Type = "Зарплатный" };
            Calculator.CalculateInterest(myAccount);

            Console.WriteLine("Процентная ставка составляет: " + myAccount.Interest);
        }
    }
}
