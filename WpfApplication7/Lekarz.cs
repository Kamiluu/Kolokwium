using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication7
{
    class Lekarz : Osoba
    {
        
       private string specjalnosc;



        protected Lekarz(string imieNazwisko, string specjalnosc) : base(imieNazwisko)
        {
            this.imieNazwisko = imieNazwisko;
            this.specjalnosc = specjalnosc;
        }

        public override string ToString()
        {
            return "Lekarz: imieNazwisko: " + imieNazwisko + "specjalnosc: " + specjalnosc ;

        }
    }
}
