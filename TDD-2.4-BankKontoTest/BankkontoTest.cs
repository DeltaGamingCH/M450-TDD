using TDD_2._4_BankKonto;

namespace TDD_2._4_BankKontoTest
{
    [TestClass]
    public class BankkontoTest
    {
        [TestMethod]
        public void KontoErstellungGuthabenIst0()
        {
            // Arrange
            int testKontoNummer = 12345678;

            // Act
            Bankkonto bankkonto = new Bankkonto(testKontoNummer);

            // Assert
            Assert.AreEqual(0, bankkonto.Guthaben);
        }

        /* 
         * Spaeter initialisieren
        [TestMethod]
        public void KontoErstellungNummerIstNicht0()
        {
            // Arrange


            // Act
            Bankkonto bankkonto = new Bankkonto();

            // Assert
            Assert.AreNotEqual(0, bankkonto.KontoNummer, "Kontonummer ist nicht 0");
        }*/

        [TestMethod]
        public void Einzahlen() {
            // Arrange 
            int testKontoNummer = 12345678;

            Bankkonto bankkonto = new Bankkonto(testKontoNummer);

            // Act
            bankkonto.ZahleEin(1000);

            // Assert
            Assert.AreEqual(1000, bankkonto.Guthaben);
        }

        [TestMethod]
        public void Beziehen()
        {
            // Arrange
            int testKontoNummber = 123455678;

            Bankkonto bankkonto = new Bankkonto(testKontoNummber);

            double testBetrag = 1000;

            // Act
            bankkonto.Beziehe(testBetrag);

            // Assert
            Assert.AreEqual(-testBetrag, bankkonto.Guthaben);
        }
    }
}