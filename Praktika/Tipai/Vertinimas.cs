using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika.Tipai
{
    public class Vertinimas
    {
        public int Id { get; private set; }
        public int Studentas { get; private set; }
        public int Dalykas { get; private set; }
        public string Data { get; private set; }
        public int Balas { get; private set; }
        public string Tipas { get; private set; }

        public Vertinimas (int id, int studentas, int dalykas, string data, int balas, string tipas)
        {
            Id = id;
            Studentas = studentas;
            Dalykas = dalykas;
            Data = data.Split(' ')[0];
            Balas = balas;
            Tipas = tipas;
        }
    }
}
