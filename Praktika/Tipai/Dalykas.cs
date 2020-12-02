using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika.Tipai
{
    public class Dalykas
    {
        public int Id { get; private set; }
        public int Destytojas { get; private set; }
        public string Pavadinimas { get; private set; }
        public string Aprasymas { get; private set; }
        public List<Grupe> Grupes { get; private set; }

        public Dalykas(int id, int destytojas, string pavadinimas, string aprasymas)
        {
            if (String.IsNullOrWhiteSpace(id.ToString()))
                throw new Exception("Netinkamas Id");
            if (String.IsNullOrWhiteSpace(destytojas.ToString()))
                throw new Exception("Netinkamas destytojo Id");
            if (String.IsNullOrWhiteSpace(pavadinimas))
                throw new Exception("Netinkamas pavadinimas");
            if (aprasymas == null)
                throw new Exception("Netinkamas aprasymas");

            Id = id;
            Destytojas = destytojas;
            Pavadinimas = pavadinimas;
            Aprasymas = aprasymas;
        }

        public void SetGrupes(List<Grupe> grupes)
        {
            Grupes = grupes;
        }
    }
}
