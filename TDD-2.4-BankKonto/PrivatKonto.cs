using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_2._4_BankKonto
{
    public class PrivatKonto : Bankkonto
    {

        public PrivatKonto(int kontoNummer, double guthaben) : base(kontoNummer, guthaben) {
            MaximalBetrag = -1000;


        }
    }
}
