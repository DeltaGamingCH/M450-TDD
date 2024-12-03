using MoqedCalculator;

namespace TestMoqedCalculator

{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DivideTest()
        {
            //Arrange
            double left = 500;
            double right = 100;

            //Act
            double result = left / right;

            //Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]

        public void ConvertChfToUsdStubTest()
        {
            // Arrange
            ExchangeRateStub exchangeRateProvider = new ExchangeRateStub();
            Calculator calculator = new Calculator(exchangeRateProvider);

            // Act
            double result = calculator.ConvertChfToUsd(10.0);

            //Assert
            Assert.Equals(9, result);
        }
    }
}