using Module._17.Patterns.Practice.Accounts;

namespace Module._17.Patterns.Practice
{
    public class Calculator
    {
        public void CalculateInterest(ICalculateInterest account)
        {
            account.CalculateInterest();

        }
    }
}
