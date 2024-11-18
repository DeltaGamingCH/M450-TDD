using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_2._4_BankKonto
{
    public class SparKonto : Bankkonto
    {
        public SparKonto(int kontoNummer, double guthaben) : base(kontoNummer, guthaben)
        {
            MaximalBetrag = 0;
        }
    }
}
