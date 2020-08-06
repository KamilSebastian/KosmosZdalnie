using System;
using System.Collections.Generic;
using System.Text;

namespace KosmosZadanie.Data
{
   public class Galaktyka
    {
        public string Nazwa { get; }
        public string Typ { get; }
        public IList<Gwiazda> Gwiazdy {get;}

        private Galaktyka(string nazwa, string typ, IList<Gwiazda> gwiazdy) {
            Nazwa = nazwa;
            Typ = typ;
            Gwiazdy = gwiazdy;
        }
        public Galaktyka() { }
        public static Galaktyka Create(string nazwa, string typ, List<Gwiazda> gwiazdy) {
            if (string.IsNullOrEmpty(nazwa)) throw new ArgumentNullException();
            if (string.IsNullOrEmpty(typ)) throw new ArgumentNullException();
            if (gwiazdy == null) throw new ArgumentNullException(); 
            return new  Galaktyka(nazwa, typ, gwiazdy);
        }
    }
}
