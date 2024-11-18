using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_2._4_BankKonto
{
    public class JugendKonto : Bankkonto
    {
        public JugendKonto(int kontoNummer, double guthaben) : base(kontoNummer, guthaben) 
        { 
            
        }
    }
}
