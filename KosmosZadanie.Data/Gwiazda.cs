using System;
using System.Collections.Generic;
using System.Text;

namespace KosmosZadanie.Data
{
    public class Gwiazda
    {
        public string Nazwa { get; }
        public int Wiek { get; }

        private Gwiazda(string nazwa, int wiek) {
            Nazwa = nazwa;
            Wiek = wiek;
        }

        public static Gwiazda Create(string nazwa, int wiek) {
            if (string.IsNullOrEmpty(nazwa)) throw new ArgumentNullException();
            return new Gwiazda(nazwa, wiek);
        }
    }
}
