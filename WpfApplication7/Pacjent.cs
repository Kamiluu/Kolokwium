using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication7
{
    class Pacjent : Osoba
    {
        private int wiek;
        private string choroba;

       
        protected  Pacjent(string imieNazwisko, int wiek, string choroba ) : base (imieNazwisko)
        {
            this.imieNazwisko = imieNazwisko;
            this.wiek = wiek;
            this.choroba = choroba;

        }
        public override string ToString()
        {
            return "Pacjent: imieNazwisko: " + imieNazwisko + "wiek: " + wiek +  "choroba: " + choroba ;

        }

    }
}
