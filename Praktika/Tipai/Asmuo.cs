using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika.Tipai
{
    public class Asmuo
    {
        protected int id;
        protected string grupe;
        protected string vardas;
        protected string pavarde;
        protected string slaptazodis;
        protected string prisijungimoV;

        public Asmuo (string id, string vardas, string pavarde, string grupe, string slaptazodis, string prisijungimoV)
        {
            if (String.IsNullOrWhiteSpace(id))
                throw new Exception("netinkamas prisijungimo kodas");

            if (String.IsNullOrWhiteSpace(grupe))
                throw new Exception("netinkama grupe");

            if (String.IsNullOrWhiteSpace(vardas))
                throw new Exception("netinkamas vardas");

            if (String.IsNullOrWhiteSpace(pavarde))
                throw new Exception("netinkama pavarde");

            if (String.IsNullOrWhiteSpace(slaptazodis))
                throw new Exception("netinkamas slaptazodis");

            if (String.IsNullOrWhiteSpace(prisijungimoV))
                throw new Exception("netinkamas prisijungimo vardas");

            this.id = Convert.ToInt32(id);
            this.grupe = grupe;
            this.vardas = vardas;
            this.pavarde = pavarde;
            this.slaptazodis = slaptazodis;
            this.prisijungimoV = prisijungimoV;
        }

        public int GetId() => id;
        public string GetVardas() => vardas;
        public string GetPavarde() => pavarde;
        public string GetGrupe() => grupe;
        public string GetSlaptazodis() => slaptazodis;
        public string GetPrisijungimoV() => prisijungimoV;
        public override string ToString() => $"Grupe: {grupe}, id: {id}, vardas: {vardas}, pavarde: {pavarde}, slaptazodis: {slaptazodis}, prisijungimo vardas: {prisijungimoV}";
    }
}
