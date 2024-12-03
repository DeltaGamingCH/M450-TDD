namespace MoqedCalculator
{
    public class Calculator : ICalculator
    {
        public IExchangeRateProvider exchangeRateProvider;

        public Calculator(IExchangeRateProvider exchangeRateProvider)
        {
            this.exchangeRateProvider = exchangeRateProvider;
        }

        public double Add(double left, double right)
        {
            throw new NotImplementedException();
        }

        public double ConvertChfToUsd(double chf)
        {
            return chf * exchangeRateProvider.GetRate(Currency.CHF, Currency.USD);
        }

        public double ConvertUsdToChf(double usd)
        {
            return exchangeRateProvider.GetRate(Currency.USD, Currency.CHF) * usd;
        }

        public double Divide(double left, double right)
        {
            if (right == 0) throw new DivideByZeroException();

            return left / right;
        }

        public double Multiply(double left, double right)
        {
            throw new NotImplementedException();
        }

        public double Subtract(double left, double right)
        {
            throw new NotImplementedException();
        }
    }
}