using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gartor
{
    public class Garagentor
    {
        private IZustand _aktuellerZustand;

        public Garagentor()
        {
            _aktuellerZustand = new Unbekannt();
        }

        public void SetZustand(IZustand newZustand)
        {
            _aktuellerZustand = newZustand;
        }

        public void TasteDruecken()
        {
            Console.WriteLine("Taste Gedrueckt");
            _aktuellerZustand.TasteDruecken(this);
        }

        public void EndschalterOben()
        {
            Console.WriteLine("Endschalter Oben betaetigt");
            _aktuellerZustand.EndschalterOben(this);
        }

        public void EndschalterUnten()
        {
            _aktuellerZustand.EndschalterUnten(this);
        }
        public void MotorAuf()
        {
            Console.WriteLine("Motor Auf");
        }
        public void MotorAb()
        {
            Console.WriteLine("Motor Runter");
        }
    }   

    public class Oeffnend : IZustand
    {
        public void EndschalterUnten(Garagentor garagentor)
        {
            garagentor.SetZustand(this);
        }
    }

    public class Schliessend : IZustand
    {

    }

    public class StopOeffnend : IZustand
    {

    }

    public class StopSchliessend : IZustand
    {

    }

    public class Offen : IZustand
    {

    }

    public class Geschlossen : IZustand
    {

    }

    public class Unbekannt : IZustand
    {
        void TasteDruecken()
        {

        }
    }

}
