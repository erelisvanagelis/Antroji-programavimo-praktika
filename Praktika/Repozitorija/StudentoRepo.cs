using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Praktika.Tipai;

namespace Praktika.Repozitorija
{
    class StudentoRepo : Repozitorija
    {
        protected List<grupesDalykas> grupesDalykai = new List<grupesDalykas>();

        public StudentoRepo() : base() { }

        //Yra gaunama string komanda, kurią naudojant bus gaunami grupesDalykai iš DB lententelės grupesDalykas, kurie bus pasirenkami arba pagal foreign key grupe arba dalykas
        //Tuomet gauti įrašai yra priskiriami objektas grupesDalykas, o patys objektai sąrašui kuris bus grąžinamas
        protected List<grupesDalykas> GetGrupesDalykai(string komanda, string grupe, int dalykas)
        {
            grupesDalykai = new List<grupesDalykas>();
            string sql = "SELECT * FROM grupesDalykas " + komanda;
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@grupe", grupe);
            cmd.Parameters.AddWithValue("@dalykas", dalykas);

            conn.Open();
            try
            {
                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["id"]);
                        int dalykasId = Convert.ToInt32(reader["dalykas"]);
                        string Grupe = reader["grupe"].ToString();
                        grupesDalykai.Add(new grupesDalykas(id, dalykasId, Grupe));
                    }
                }

                if (grupesDalykai.Count() < 1)
                {
                    throw new Exception("Nepavyko gauti grupiu");
                }
            }
            catch(Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
            conn.Close();

            return grupesDalykai;
        }

        //Yra gaunamas objektas Asmuo, kurio atributas grupes yra naudojamas gauti, su jo grupe susijusius dalykus, naudojant metodą GetGrupesDalykai
        //Tuomet yra iteruojama per visus gautus grupesDalykus, iteraciju metu yra naudojamas metodas GetDalykas, kuris naudojant grupesDalykas atributą dalykas
        //sugražina sugražiną objektą iš DB lentelės dalykas.
        //tuomet gauto dalyko atributai pavdinimas ir destytojas(jo id)(Šis id yra naudojamas gauti dėstytojo vardą ir pavardę naudojant metoda GetDestytojoVardas iš DB
        //yra naudojami gauti naujam objektui Dalyko vertinimas pavadinimui
        //Tuomet jau per sukurtą dalykuVertinimas sąrašą yra iteruojama ir su kiekviena iteracija yra priskiriami susiję su dalyku ir studentu pažymiai iš DB lentelės vertinimas
        public List<DalykoVertinimai> GetDalykai(Asmuo gautas)
        {
            List<DalykoVertinimai> dalykuVertinimai = new List<DalykoVertinimai>();

            try
            {
                List<int> dalykuId = GetDalykuId(gautas.GetId());
                for (int i = 0; i < dalykuId.Count; i++)
                {
                    Dalykas temp = GetDalykas(dalykuId[i]);
                    dalykuVertinimai.Add(new DalykoVertinimai($"{temp.Pavadinimas} ({GetDestytojoVardas(temp.Destytojas)})"));
                    dalykuVertinimai[i].SetVertinimai(GetVertinimai(gautas.GetId(), temp.Id));
                }
            }
            catch(Exception exc)
            {
                Console.WriteLine(exc.Message);
            }

            if (dalykuVertinimai.Count < 1)
                throw new Exception("Nepavyko gauti destomu dalyku");

            return dalykuVertinimai;
        }

        //gaunamas objekto Dalykas atributas id, jis yra naudojamas ieškant ir gaunant likusia objekto informacija iš DB lentelės dalykas
        //tuomet gautas įrašas yra priskiriamas objektui Dalykas ir grąžinamas iškviestai funkcijai
        protected Dalykas GetDalykas(int dalykas)
        {
            string sql = "SELECT * FROM dalykas WHERE id=@dalykas";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@dalykas", dalykas);
            Dalykas rezultatas = null;

            conn.Open();
            try
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["id"]);
                        int destytojas = Convert.ToInt32(reader["destytojas"]);
                        string pavadinimas = reader["pavadinimas"].ToString();
                        string aprasymas = reader["aprasymas"].ToString();
                        rezultatas = new Dalykas(id, destytojas, pavadinimas, aprasymas);
                    }
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
            conn.Close();

            if(rezultatas == null)
                throw new Exception("Nepavyko gauti destomo dalyko");

            return rezultatas;
        }

        //Yra gaunamas objekto Asmuo atributas id, pagal tai Yra gaunamas reikiamas įrašas iš DB lentelės asmuo
        //Gauto įrašo vertė vardas ir pavarde yra priskiriami string objektui, kuris grąžina šią informacija ten kur buvo iškviesta
        public string GetDestytojoVardas(int id)
        {
            string rezultatas = null;
            string sql = "SELECT vardas, pavarde FROM asmuo WHERE id=@id";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", id);

            conn.Open();
            try
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if(reader.Read())
                    {
                        rezultatas = reader["vardas"].ToString();
                        rezultatas += " " + reader["pavarde"].ToString();
                    }
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
            conn.Close();

            if (rezultatas == null)
                throw new Exception("Nepavyko gauti destytojo");

            return rezultatas;
        }

        //Gaunamas grupesDalykas atributas id, ir Asmuo objekto atributas id, šie atributai yra naudojami norint gauti reikiamus įrašus, pagal jų mažėjimo eile
        //pagal jų datos verte iš DB lentelės vertinimas
        //Gauti įrašai yra priskiriami Vertinimas sąrašui, ir vėliau visas sąrašas yra grąžinamas
        public List<Vertinimas> GetVertinimai(int asmuoId, int dalykasId)
        {
            List<Vertinimas> pazymiai = new List<Vertinimas>();
            string sql = "SELECT * FROM vertinimas " +
                "WHERE studentas=@asmuoId and dalykas=@dalykasId " +
                "ORDER BY data DESC";
            SqlCommand cmd = new SqlCommand(sql , conn);
            cmd.Parameters.AddWithValue("@asmuoId", asmuoId);
            cmd.Parameters.AddWithValue("@dalykasId", dalykasId);

            conn.Open();
            try
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        int id = Convert.ToInt32(reader["id"]);
                        int studentas = Convert.ToInt32(reader["studentas"]);
                        int dalykas = Convert.ToInt32(reader["dalykas"]);
                        string data = reader["data"].ToString();
                        int balas = Convert.ToInt32(reader["balas"]);
                        string tipas = reader["tipas"].ToString();
                        pazymiai.Add(new Vertinimas(id, studentas, dalykas, data, balas, tipas));
                    }
                }
            }
            catch(Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
            conn.Close();
            if (pazymiai.Count < 1)
                Console.WriteLine("Nepavyko gauti pazymiu arba ju nera");

            return pazymiai;
        }

        protected List<int> GetDalykuId(int asmensId)
        {
            List<int> rezultatas = new List<int>();
            string sql = "SELECT DISTINCT dalykas FROM vertinimas WHERE studentas=@asmensId";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@asmensId", asmensId);

            conn.Open();
            try
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        rezultatas.Add(Convert.ToInt32(reader["dalykas"]));
                    }
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
            conn.Close();

            return rezultatas;
        }
    }
}
