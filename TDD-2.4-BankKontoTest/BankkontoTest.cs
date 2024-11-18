using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;
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
            JugendKonto jugendKonto = new(testKontoNummer, 0);

            // Assert
            Assert.AreEqual(0, jugendKonto.Guthaben);
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

            JugendKonto jugendKonto = new(testKontoNummer, 0);

            double testBetrag = 1000;

            // Act
            jugendKonto.ZahleEin(testBetrag);

            // Assert
            Assert.AreEqual(testBetrag, jugendKonto.Guthaben);
        }

        [TestMethod]
        public void Beziehen()
        {
            // Arrange
            int testKontoNummer = 123455678;

            JugendKonto jugendKonto = new(testKontoNummer, 0);

            double testBetrag = 1000;

            // Act
            jugendKonto.Beziehe(testBetrag);

            // Assert
            Assert.AreEqual(-testBetrag, jugendKonto.Guthaben);
        }

        [TestMethod]
        public void Zahlungen()
        {
            // Arrange
            int testKontoNummer = 12345678;

            double testErwarteterBetrag = 1000 + 1000 - 3000 + 2000;

            JugendKonto jugendKonto = new(testKontoNummer, 0);

            // Act
            jugendKonto.ZahleEin(1000);
            jugendKonto.ZahleEin(1000);
            jugendKonto.Beziehe(3000);
            jugendKonto.ZahleEin(2000);

            // Assert
            Assert.AreEqual(testErwarteterBetrag, jugendKonto.Guthaben);
        }

        [TestMethod]
        public void AktivZins()
        {
            // Arrange
            int testKontoNummer = 12345678; 

            double testGuthaben = 1000;

            double testZinsBetrag = 0;

            JugendKonto jugendKonto = new(testKontoNummer, testGuthaben);

            // Act

            if (testGuthaben >= 0)
            {
                testZinsBetrag = testGuthaben * jugendKonto.aktivZins / 100;
            } else
            {
                testZinsBetrag = testGuthaben * jugendKonto.passivZins / 100;
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

            JugendKonto testjugendKonto = new(testKontoNummer, testGuthaben);

            // Act
            if (testGuthaben >= 0)
            {
                testZinsBetrag = testGuthaben * testjugendKonto.aktivZins / 100;
            }
            else
            {
                testZinsBetrag = testGuthaben * testjugendKonto.passivZins / 100;
            }

            // Assert
            Assert.AreEqual(-5.0, testZinsBetrag);
        }

        [TestMethod]
        public void KontoAbschlussZinsHinzufuegen()
        {
            // Arrange
            int testKontoNummer = 12345678;

            double testGuthaben = 1000;

            double testZinsBetrag = 2.5;

            JugendKonto testjugendKonto = new(testKontoNummer, testGuthaben);

            // Act
            if (testZinsBetrag >= 0)
            {
                testGuthaben = testGuthaben + testZinsBetrag;
            }

            // Assert
            Assert.AreEqual(1002.5, testGuthaben);
        }

        [TestMethod]
        public void ZinsUndAbschluss()
        {
            // Arrange
            int testKontoNummer = 1488;

            double testGuthaben = 1000;

            double testZinsBetrag = 0;

            JugendKonto jugendKonto = new(testKontoNummer, testGuthaben);

            int anzahlTage = 180;

            // Act
            testZinsBetrag = jugendKonto.SchreibeZinsGut(anzahlTage);

            if (jugendKonto.SchreibeZinsGut(anzahlTage) >= 0)
            {
                testGuthaben = testGuthaben + testZinsBetrag;
            }
            else
            {
                testGuthaben = testGuthaben - testZinsBetrag;
            }

            // Assert
            Assert.AreEqual(1450, testGuthaben);
        }

        [TestMethod]
        public void jugendKonto()
        {
            // Arrange
            JugendKonto jugendKonto = new(12345678, -2000);

            // Act
            ...

            // Assert
            ...
        }
    }
}