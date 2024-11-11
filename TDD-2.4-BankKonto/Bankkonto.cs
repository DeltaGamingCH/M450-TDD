using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_2._4_BankKonto
{
    public class Bankkonto
    {
        public int KontoNummer { get; private set; }
        public double Guthaben { get; private set; }
        public double aktivZins;
        public double passivZins;

        public Bankkonto(int kontoNummer)
        { 
            KontoNummer = kontoNummer;

            /*
            if (kontoNummer != null && kontoNummer != 0)
            {
                Random random = new Random();
                kontoNummer = random.Next(10000000, 99999999);
            }*/

            Guthaben = 0;
        }

        public void ZahleEin(double betrag)
        {
            Guthaben += betrag;
        }

        public void Beziehe(double betrag)
        {
            Guthaben -= betrag;
        }

        public void Transferiere(int konto, double betrag)
        {

        }

        public void SchreibeZinsGut(int anzahlTage)
        {

        }

        public void SchlisseKontoAb()
        {

        }
    }
}