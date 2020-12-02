using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika.Tipai
{
    class grupesDalykas
    {
        public int Id { get; private set; }
        public int Dalykas { get; private set; }
        public string Grupe { get; private set; }

        public grupesDalykas (int id, int dalykas, string grupe)
        {
            Id = id;
            Dalykas = dalykas;
            Grupe = grupe;
        }
    }
}
