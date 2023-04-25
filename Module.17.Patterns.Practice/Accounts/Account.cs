using System;

namespace Module._17.Patterns.Practice
{
    /// <summary>
    /// Базовый класс аккаунта
    /// </summary>
    public abstract class Account
    {
        // тип учетной записи
        protected string Type;

        // баланс учетной записи
        protected double Balance;

        // процентная ставка
        protected double Interest;

        public Account(double balance)
        {
            Balance = balance;
        }

        public void ShowInterest()
        {
            Console.WriteLine($"Тип вашего аккаунта: {Type}\nПроцентная ставка: {Interest}\n");
        }
    }
}
