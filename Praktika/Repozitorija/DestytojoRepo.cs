using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Praktika.Tipai;

namespace Praktika.Repozitorija
{
    class DestytojoRepo : StudentoRepo
    {

        public DestytojoRepo() : base() { }

        //Yra gaunamas Asmuo objektas, pagal jo atributą id yra gaunami usije dalykai, besikreipiant į metodą GetDalykai, tuomet gautų dalykų sąrašas yra 
        //užpildomas grupėmis, kurios yra susietos su šiuo dalyku DB lentelėje grupesDalykai
        public List<Dalykas> GetUzpildytiDalykai(Asmuo gautas)
        {
            List<Dalykas> dalykai = GetDalykai(gautas);
            foreach (Dalykas d in dalykai)
            {
                d.SetGrupes(GetGrupes(d.Id));
            }
            return dalykai;
        }

        //Yra gaunamas objektas Asmuo, o pagal jo atributą Id yra gaunami susiję įrašai iš DB lentelės dalykas (pagal foreign key destytojas)
        //Tuomet gauta informacija Dalykas objektų sąrašui, kuris baigus gautos informacijos skaitymą ir priskyrimą yra grąžinamas
        public new List<Dalykas> GetDalykai(Asmuo gautas)
        {
            List<Dalykas> dalykai = new List<Dalykas>();
            string sql = "SELECT * FROM dalykas WHERE destytojas=@id";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", gautas.GetId());

            conn.Open();
            try
            {
                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int Id = Convert.ToInt32(reader["id"]);
                        int destytojas = Convert.ToInt32(reader["destytojas"]);
                        string pavadinimas = reader["pavadinimas"].ToString();
                        string aprasymas = reader["aprasymas"].ToString();
                        dalykai.Add(new Dalykas(Id, destytojas, pavadinimas, aprasymas));
                    }
                }
                if (dalykai.Count < 1)
                    throw new Exception("Nepavyko gauti mokomu dalyku");
            }
            catch(Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
            conn.Close();

            return dalykai;
        }

        //Yra gaunamas dalyko atributas Id, ir pagal jį yra gaunami visi susiję įrašai iš DB lentelės grupesDalykas (pagal foreign key dalykas)
        //Tuomet yra iteruojama per gautų grupėsDalykų sąrašą, ir jų saugomas atributas grupe(pavadinimas) yra priskiriamas objektu sąrašui grupe
        //Taip yra priskiriamas ir grupėsDalykas atributas Id (tam kad lengviau būtu galima atnaujinti pažimį? (gal))
        //Naujos grupės inicializavime taip pat yra priskiriami ir studentai, naudojant funkcija GetStudentai, pateikiant grupesDalyką, nes jo reikia norint gauti studentų vertinimus
        public List<Grupe> GetGrupes(int id)
        {
            List<Grupe> grupes = new List<Grupe>();

            try
            {
                GetGrupesDalykai("WHERE dalykas=@dalykas", "", id);
                for (int i = 0; i < grupesDalykai.Count(); i++)
                {
                    Console.WriteLine($"{grupesDalykai[i].Grupe}");
                    grupes.Add(new Grupe(grupesDalykai[i].Grupe));
                    grupes[i].SetStudentai(GetStudentai(grupesDalykai[i]));
                }

                if(grupes.Count < 1)
                    throw new Exception("Nepavyko gauti grupiu");
            }
            catch(Exception exc)
            {
                Console.WriteLine(exc.Message);
            }

            return grupes;
        }

        //Yra gaunamas grupėsDalykas objektas, perduodant šio objekto atributą Grupe metodui GetAsmenys yra gaunami reikiamos grupes studentai
        //Tuomet yra iteruojama per gautų studentų sąrašą, ir kiekvieno studento atributas Vertinimai yra užpilomas reikiamo dalyko pažymiais besikreipiant
        //į metodą GetPazymius(), kuris gauną pažymius iš DB lentelės vertinimas naudojant abu foreign keys studentas(jo id) ir grupesDalykas(jo id)
        private  List<Studentas> GetStudentai(grupesDalykas grupesDalykas)
        {
            List<Studentas> studentai = GetAsmenys(grupesDalykas.Grupe);

            foreach (Studentas s in studentai)
            {
                Console.WriteLine($"{s.GetGrupe()} {s.GetVardas()} {s.GetPavarde()}");
                s.SetVertinimas(GetVertinimai(s.GetId(), grupesDalykas.Dalykas)); //asdasdasdasasdasdasd
            }

            return studentai;
        }

        //Yra gaunama reikiama sql žinutė ir grupės, kurios foreig key turės reikiami asmenys
        //Tuomet sąrašas bus užpildytas rezultatais gautais iš DB lentelės asmuo (jei yra priskirti objektui Asmuo, kurie patalpinami į sąrašą)
        protected List<Studentas> GetAsmenys(string grupe)
        {
            string sql = "SELECT * FROM asmuo WHERE grupe=@grupe ORDER BY pavarde, vardas DESC";
            List<Studentas> studentai = new List<Studentas>();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@grupe", grupe);

            conn.Open();
            try
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string id = reader["id"].ToString();
                        string vardas = reader["vardas"].ToString();
                        string pavarde = reader["pavarde"].ToString();
                        string Grupe = reader["grupe"].ToString();
                        string password = reader["slaptazodis"].ToString();
                        string nickname = reader["PrisijungimoV"].ToString();
                        studentai.Add(new Studentas(id, vardas, pavarde, Grupe, password, nickname));
                    }
                }
                if (studentai.Count < 1)
                    throw new Exception("Nepavyko gauti studentu");
            }
            catch(Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
            conn.Close();
            return studentai;
        }

        //Yra gaunamas objektas Vertinimas, šis vertinimas yra perduodamas metodui SqlVetinimas su reikiama sql žinute įrašo įterpimui DB lentelėje vertinimas 
        public void InsertVertinimas(Vertinimas gautas)
        {
            string sql = "INSERT INTO vertinimas (studentas, dalykas, data, balas, tipas) " +
                    "VALUES (@studentas, @dalykas, @data, @balas, @tipas)";
            SqlVertinimas(gautas, sql);
        }

        //Yra gaunamas objektas Vertinimas, šis vertinimas yra perduodamas metodui SqlVetinimas su reikiama sql žinute įrašo atnaujinimui DB lentelėje vertinimas 
        public void UpdateVertinimas(Vertinimas gautas)
        {
            string sql = "UPDATE vertinimas SET data=@data, balas=@balas, tipas=@tipas WHERE id=@id";
            SqlVertinimas(gautas, sql);
        }

        //Yra gaunamas objektas Vertinimas, šis vertinimas yra perduodamas metodui SqlVetinimas su reikiama sql žinute įrašo pašalinimui iš DB lentelės vertinimas 
        public void DeleteVertinimas(Vertinimas gautas)
        {
            string sql = "DELETE FROM vertinimas WHERE id=@id";
            SqlVertinimas(gautas, sql);
        }

        //Gaunamas objektas Vertinimas, jo atributai yra priskiriami SqlCommand objektui cmd, ir tuomet yra atliekama komanda kuri buvo gauta string objektu sql  
        public void SqlVertinimas(Vertinimas gautas, string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", gautas.Id);
            cmd.Parameters.AddWithValue("@studentas", gautas.Studentas);
            cmd.Parameters.AddWithValue("@dalykas", gautas.Dalykas);
            cmd.Parameters.AddWithValue("@data", gautas.Data);
            cmd.Parameters.AddWithValue("@balas", gautas.Balas);
            cmd.Parameters.AddWithValue("@tipas", gautas.Tipas);

            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
            conn.Close();
        }
    }
}
