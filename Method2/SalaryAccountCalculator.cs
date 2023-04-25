using Module._17.Patterns.Practice;
using Module._17.Patterns.Practice.Accounts;

namespace Method2
{
    /// <summary>
    /// Калькулятор зарплатного аккаунта
    /// </summary>
    class SalaryAccountCalculator : ICalculator
    {
        public void CalculateInterest(Account account)
        {
            // расчет процентной ставка зарплатного аккаунта по правилам банка
            account.Interest = account.Balance * 0.5;
        }
    }
}
