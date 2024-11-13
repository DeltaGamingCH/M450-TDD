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
         * Spaeter initialisieren - Random Kontonummer
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

            double testBetrag = 1000;

            // Act
            bankkonto.ZahleEin(testBetrag);

            // Assert
            Assert.AreEqual(testBetrag, bankkonto.Guthaben);
        }

        [TestMethod]
        public void Beziehen()
        {
            // Arrange
            int testKontoNummer = 123455678;

            Bankkonto testBankkonto = new Bankkonto(testKontoNummer);

            double testBetrag = 1000;

            // Act
            testBankkonto.Beziehe(testBetrag);

            // Assert
            Assert.AreEqual(-testBetrag, testBankkonto.Guthaben);
        }

        [TestMethod]
        public void Zahlungen()
        {
            // Arrange
            int testKontoNummer = 12345678;

            double testErwarteterBetrag = 1000 + 1000 - 3000 + 2000;

            Bankkonto testBankkonto = new Bankkonto(testKontoNummer);

            // Act
            testBankkonto.ZahleEin(1000);
            testBankkonto.ZahleEin(1000);
            testBankkonto.Beziehe(3000);
            testBankkonto.ZahleEin(2000);

            // Assert
            Assert.AreEqual(testErwarteterBetrag, testBankkonto.Guthaben);
        }

        [TestMethod]
        public void AktivZins()
        {
            // Arrange
            int testKontoNummer = 12345678; 

            double testGuthaben = 1000;

            double testZinsBetrag = 0;

            Bankkonto testBankKonto = new Bankkonto(testKontoNummer);

            // Act

            if (testGuthaben >= 0)
            {
                testZinsBetrag = testGuthaben * testBankKonto.aktivZins / 100;
            } else
            {
                testZinsBetrag = testGuthaben * testBankKonto.passivZins / 100;
            }

            // Assert
            Assert.AreEqual(2.5, testZinsBetrag);
        }

        [TestMethod]
        public void PassivZins()
        {
            // Arrange
            int testKontoNummer = 12345678;

            double testGuthaben = -1000;

            double testZinsBetrag = 0;

            Bankkonto testBankKonto = new Bankkonto(testKontoNummer);

            // Act

            if (testGuthaben >= 0)
            {
                testZinsBetrag = testGuthaben * testBankKonto.aktivZins / 100;
            }
            else
            {
                testZinsBetrag = testGuthaben * testBankKonto.passivZins / 100;
            }

            Console.WriteLine(testZinsBetrag);

            // Assert
            Assert.AreEqual(-5.0, testZinsBetrag);
        }
    }
}