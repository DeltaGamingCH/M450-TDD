using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_2._4_BankKonto
{
    public abstract class Bankkonto
    {
        public int KontoNummer { get; private set; }
        public double Guthaben { get; private set; }
        public double aktivZins = 0.25;
        public double passivZins = 0.5;
        //int anzahlTage = 360;

        public double MaximalBetrag { get; set; }

        public Bankkonto(int kontoNummer, double guthaben)
        { 
            KontoNummer = kontoNummer;

            Guthaben = guthaben;
        }

        public void ZahleEin(double betrag)
        {
            if (betrag > 0)
            {
                Guthaben += betrag;
            }
        }

        public void Beziehe(double betrag)
        {
            Guthaben -= betrag;
        }

        public void Transferiere(int konto, double betrag)
        {

        }

        public double SchreibeZinsGut(int anzahlTage)
        {
            double zinsBetrag = 0;

            for (int i = 0; i < anzahlTage; i++)
            {
                if (Guthaben >= 0)
                {
                    zinsBetrag = zinsBetrag + (Guthaben * aktivZins / 100);
                }
                else
                {
                    zinsBetrag = zinsBetrag + (Guthaben * passivZins / 100);
                }
            }

            return zinsBetrag;
        }

        public void SchlisseKontoAb()
        {

        }

        public void maximalBetragUeberschritten()
        {
        }
    }
}