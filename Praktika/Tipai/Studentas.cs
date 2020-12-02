using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika.Tipai
{
    public class Studentas : Asmuo
    {
        public List<Vertinimas> Vertinimas { get; private set; }

        public Studentas(string id, string vardas, string pavarde, string grupe, string slaptazodis, string prisijungimoV)
            : base(id, vardas, pavarde, grupe, slaptazodis, prisijungimoV){}

        public void SetVertinimas (List<Vertinimas> vertinimas)
        {
            Vertinimas = vertinimas;
        }

        public void SetId(int id)
        {
            this.id = id;
        }
    }
}
