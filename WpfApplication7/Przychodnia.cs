using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication7
{
    class Przychodnia : IPrzychodnia
    {
        private Lekarz lekarz;
        private Stack<Pacjent> pacjenci = new Stack<Pacjent>();

        public void UstawLekarza(string imieN, string specjalnosc)
        {
            
        }
        public void ZapiszDoLekarza(string imieN, int wiek, string choroba)
        {
            
        }
        public string WykonajPorade()
        {
            return "WykonanaPorada" + pacjenci.Pop().ToString();
        }

        public string WykonajBadanie()
        {
            return pacjenci.Peek().ToString();
        }
        public int CzasOczekiwania()
        {
            return Convert.ToInt16(Math.Round((decimal) pacjenci.Count / 3 ));
        }
      
        
    }
}
