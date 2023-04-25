namespace Module._17.Patterns.Practice.Accounts
{
    /// <summary>
    /// Класс зарплатного аккаунта 
    /// </summary>
    public class SalaryAccount : Account, ICalculateInterest
    {
        public SalaryAccount(double balance) : base(balance)
        {
            Type = "Зарплатный";
        }

        public void CalculateInterest()
        {
            // расчет процентной ставка зарплатного аккаунта по правилам банка
            Interest = Balance * 0.5;

            // Выводим информацию 
            ShowInterest();
        }
    }
}
