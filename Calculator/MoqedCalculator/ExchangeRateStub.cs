using MoqedCalculator;

namespace TestMoqedCalculator
{
    public class ExchangeRateStub : MoqedCalculator.IExchangeRateProvider
    {
        public double GetRate(Currency dst, Currency per)
        {
            if (dst == Currency.CHF && per == Currency.USD)
                return 2.0;
            return 1.0;

        }
    }
}