namespace Module._17.Patterns.Practice.Accounts
{
    /// <summary>
    /// Класс обычного аккаунта 
    /// </summary>
    public class RegularAccount : Account, ICalculateInterest
    {
        public RegularAccount(double balance) : base(balance)
        {
            Type = "Обычный";
        }

        public void CalculateInterest()
        {
            // расчет процентной ставки обычного аккаунта по правилам банка
            Interest = Balance * 0.4;

            if (Balance < 1000)
                Interest -= Balance * 0.2;

            if (Balance < 50000)
                Interest -= Balance * 0.4;

            // Выводим информацию 
            ShowInterest();
        }
    }
}
