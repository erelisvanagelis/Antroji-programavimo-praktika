using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika.Tipai
{
    class DalykoVertinimai
    {
        public string Pavadinimas { get; private set; }
        public List<Vertinimas> Vertinimai{ get; private set; }

        public DalykoVertinimai(string pavadinimas)
        {
            Pavadinimas = pavadinimas;
        }

        public void SetPavadinimas(string pavadinimas)
        {
            Pavadinimas += pavadinimas;
        }

        public void SetVertinimai(List<Vertinimas> vertinimai)
        {
            Vertinimai = vertinimai;
        }
    }
}
