using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika.Tipai
{
    public class Grupe
    {
        public string Pavadinimas { get; private set; }
        public List<Studentas> Studentai { get; private set; }

        public Grupe(string pavadinimas, List<Studentas> studentai)
        {
            Pavadinimas = pavadinimas;
            Studentai = studentai;
        }

        public Grupe(string pavadinimas)
        {
            Pavadinimas = pavadinimas;
        }

        public void SetStudentai(List<Studentas> studentai)
        {
            Studentai = studentai;
        }
    }
}
