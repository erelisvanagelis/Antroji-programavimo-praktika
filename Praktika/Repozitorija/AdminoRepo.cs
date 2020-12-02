using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Praktika.Tipai;

namespace Praktika.Repozitorija
{
    class AdminoRepo : DestytojoRepo
    {

        public AdminoRepo() : base() { }

        //Gaunami visi "destytojai" grupės nariai, besikreipiant į GetAsmenys metodą ir jie yra grąžinami List<Studentas> pavidalu
        public List<Studentas> GetDestytojai()
        {
            List<Studentas> destytojai = GetAsmenys("destytojai");
            return destytojai;
        }

        //Kreipiamasi į DB lentelę grupes ir iš ten pameamamos visos lentelės išskyrus administratoriaus, gavus ir priskyrus grupes jos yra 
        //užpildomos nariais besikreipiant į metodą GetAsmenys(), kuri grąžina duotos grupės naudotojų sąrašą, besikreipiant į DB lentele asmuo 
        public List<Grupe> GetGrupes()
        {
            List<Grupe> grupes = new List<Grupe>();
            string sql = "SELECT * FROM grupe WHERE pavadinimas!='adminai'";
            SqlCommand cmd = new SqlCommand(sql, conn);

            conn.Open();
            try
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        grupes.Add(new Grupe(reader["pavadinimas"].ToString()));
                    }
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
            conn.Close();

            foreach (Grupe g in grupes)
            {
                g.SetStudentai(GetAsmenys(g.Pavadinimas));
            }

            return grupes;
        }

        //Sukuriama grupe visi naudotojai ir jai yra priskiriami visi nariai kurie nėra adminai grupės nariai, naudojant funkcija GetAsmenys()
        public Grupe GetVisiNaudotojai()
        {
            Grupe visi = new Grupe("Visi naudotojai");
            List<Studentas> studentai = new List<Studentas>();
            List<Grupe> grupes = GetGrupes();
            
            foreach (Grupe g in grupes)
            {
                studentai.AddRange(g.Studentai);
            }
            visi.SetStudentai(studentai);
            return visi;
        }

        //Funkcija priema asmuo objektą ir prideda jo vertes į duomenų bazę. Jei dėl įterpimo komandos niekas nepakito DB apie tai yra pranešama klaidos pranešimu.
        public void InsertAsmuo(Asmuo gautas)
        {
            string sql = "INSERT INTO asmuo (vardas, pavarde, grupe, slaptazodis, prisijungimoV) " + 
                "VALUES (@vardas, @pavarde, @grupe, @slaptazodis, @prisijungimoV)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@vardas", gautas.GetVardas());
            cmd.Parameters.AddWithValue("@pavarde", gautas.GetPavarde());
            cmd.Parameters.AddWithValue("@grupe", gautas.GetGrupe());
            cmd.Parameters.AddWithValue("@slaptazodis", gautas.GetSlaptazodis());
            cmd.Parameters.AddWithValue("@prisijungimoV", gautas.GetPrisijungimoV());

            conn.Open();
            int kiek = cmd.ExecuteNonQuery();
            conn.Close();

            if (kiek < 1)
                throw new Exception("Nepavyko pridėti naujo naudotojo");
        }

        //pašalina Asmeni, jei tas asmuo yra dėstytojas nuo jo pirmiau atskiria mokomuosius dalykus, jei studentas su juo susijusius vertinimus
        public void SalintiNaudotoja(Asmuo gautas)
        {
            if (gautas.GetGrupe() == "destytojai")
                AtskirtiDalykus(gautas);
            else
                SalintiVertinimus(gautas);

            SalintiAsmeni(gautas);
        }

        //Gauna asmuo objektą ir pagal jo id ištrina susijusį asmenį
        private int SalintiVertinimus(Asmuo gautas)
        {
            string sql = "DELETE FROM vertinimas WHERE studentas=@studentas";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@studentas", gautas.GetId());
            int kiek;

            conn.Open();
            kiek = cmd.ExecuteNonQuery();
            conn.Close();

            return kiek;
        }

        //Gauna asmuo objektą, ir naudojant objekto id atributą suranda visus jam priskirtus DB lenteles dalykas įrašus ir juose dėstytoja (jo id) pakeičia
        //į 1 "Nepriskiti Dalykai" dėstytojui
        private int AtskirtiDalykus(Asmuo gautas)
        {
            string sql = "UPDATE dalykas SET destytojas=1 WHERE destytojas=@destytojas";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@destytojas", gautas.GetId());
            int kiek;

            conn.Open();
            kiek = cmd.ExecuteNonQuery();
            conn.Close();

            return kiek;
        }

        //Gauna dalyko id ir būsimo dėstytojo, kuris bus jam priskirtas id. Ir pagal dalyko id randa reikiamą įrašą, ir jo dėstytojo vertę pakeičia, į gautą būsimo dėstytojo vertę
        public void UpdateDalykas(int dalykas, int busimas = 1)
        {
            string sql = "UPDATE dalykas SET destytojas=@busimas WHERE id=@id";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@busimas", busimas);
            cmd.Parameters.AddWithValue("@id", dalykas);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //Gauna asmens objektą ir pagal jo id išrina įrašą iš DB lentelės asmuo
        private int SalintiAsmeni(Asmuo gautas)
        {
            string sql = "DELETE FROM asmuo WHERE id=@id";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", gautas.GetId());
            int kiek;

            conn.Open();
            kiek = cmd.ExecuteNonQuery();
            conn.Close();

            return kiek;
        }

        //Grupės iterpimas susideda iš trijų žinsnių, patikrinimo ar pavadinimas yra tinkmas, ar tokia grupė jau egzistuoja ir įterpimo į DB lentelę grupe
        public void IterptiGrupe(string pavadinimas)
        {
            if (String.IsNullOrWhiteSpace(pavadinimas))
                throw new Exception("Netinkamas grupes pavadinimas");

            if (RastiGrupe(pavadinimas) == true)
                throw new Exception("Tokia grupe jau egzistuoja");

            if (InsertGrupe(pavadinimas) < 1)
                throw new Exception("Nepavyko iterpti naujos grupes");
        }

        //gaunamas grupes pavadinimas ir šis pavadinimas yra ieškomas DB lentelėje grupe, jei įrašas yra gražinas, yra gražinama vertė true, priešingu atvėju false 
        private bool RastiGrupe(string pavadinimas)
        {
            string sql = "SELECT * FROM grupe WHERE pavadinimas=@pavadinimas";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@pavadinimas", pavadinimas);

            bool rado = false;
            conn.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    rado = true;
                }
            }
            conn.Close();

            return rado;
        }

        //Gaunamas grupės pavadinimas yra įterpiamas į DB lentele grupes ir gražinama int reikšme paveiktu eilučių skaičiu
        //Jei pavyko įterpti turėtu būti grąžinamas vienetas
        private int InsertGrupe(string pavadinimas)
        {
            string sql = "INSERT INTO grupe (pavadinimas) VALUES(@pavadinimas)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@pavadinimas", pavadinimas);

            conn.Open();
            int kiek = cmd.ExecuteNonQuery();
            conn.Close();

            return kiek;
        }

        //Yra gaunama grupes ir visi jos nariai yra priskiriami grupei nepriskirti , narių pažymiai yra išrinami, o pati grupe yra ištrinama.
        //Nevisos grupes yra trinamos. nepriskirti, destytojai, adminai ir Visi naudotojai negali būti ištrinti
        public void SalintiGrupe(Grupe grupe)
        {
            if (grupe.Pavadinimas == "nepriskirti" || grupe.Pavadinimas == "destytojai" || grupe.Pavadinimas == "adminai" || grupe.Pavadinimas == "Visi naudotojai")
                throw new Exception("Šios grupės ištrinti negalima");

            foreach (Studentas s in grupe.Studentai)
            {
                UpdateAsmensGrupe(s.GetId());
            }

            GetGrupesDalykai("WHERE grupe=@grupe", grupe.Pavadinimas, 0);
            foreach (grupesDalykas gD in grupesDalykai)
            {
                DeleteGrupesDalykas(gD);
            }
            DeleteGrupe(grupe.Pavadinimas);
        }

        //Yra gaunama grupe ir visi jos nariai yra ištrinami, kartu su jų pažymiais, o pati grupe yra ištrinama.
        //Nevisos grupes yra trinamos. nepriskirti, destytojai, adminai ir Visi naudotojai negali būti ištrinti
        public void SalintiGrupeSuStudentais(Grupe grupe)
        {
            if (grupe.Pavadinimas == "nepriskirti" || grupe.Pavadinimas == "destytojai" || grupe.Pavadinimas == "adminai" || grupe.Pavadinimas == "Visi naudotojai")
                throw new Exception("Šios grupės ištrinti negalima");

            foreach (Studentas s in grupe.Studentai)
            {
                SalintiNaudotoja(s);
            }

            GetGrupesDalykai("WHERE grupe=@grupe", grupe.Pavadinimas, 0);
            foreach (grupesDalykas gD in grupesDalykai)
            {
                DeleteGrupesDalykas(gD);
            }

            DeleteGrupe(grupe.Pavadinimas);
        }

        //Gaunamas grupes pavadinimas ir ju yra ištrinama iš DB lentelės grupe. Yra gražinama int vertė kuri parodo kiek eilučių buvo paveikta
        private int DeleteGrupe(string pavadinimas)
        {
            string sql = "DELETE FROM grupe WHERE pavadinimas=@pavadinimas";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@pavadinimas", pavadinimas);

            conn.Open();
            int kiek = cmd.ExecuteNonQuery();
            conn.Close();

            return kiek;
        }

        // yra gaunamas asmens Id ir grupes pavadinimas kuriai jis bus priskirtas. Tuomet DB lenteleje asmuo, įrašas rastas pagal asmens id yra atnaujinamas pakeičiant
        //Jo grupe gauta.
        public void UpdateAsmensGrupe(int id, string atskirti = "nepriskirti")
        {
            string sql = "UPDATE asmuo SET grupe=@atskirti WHERE id=@id";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@atskirti", atskirti);
            cmd.Parameters.AddWithValue("@id", id);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //Yra pateikiamas dėstytojų sąrašas ir su sąrašo objektais yra kreipiamasi į metodą GetDalykai, kuris priema vieną Asmuo objektą ir gražiną objektų dalykas sąrašą
        //Gautas sąrašas yra priskiriamas bendram
        //Gavus visų destytoju dalykus, bendras sąrašas yra surikiuojamas pagal dalyko id
        public List<Dalykas> GetVisiDalykai(List<Studentas> destytojai)
        {
            List<Dalykas> dalykai = new List<Dalykas>();
            foreach(Asmuo a in destytojai)
            {
                dalykai.AddRange(GetDalykai(a));
            }

            dalykai.Sort((a, b) => a.Id.CompareTo(b.Id));
            return dalykai;
        }

        //Gaunamas objektas dalykas, jo verte id yra naudojama rasti susijusius grupesDalykus, besikreipiant į metodą GetGrupesDalykai
        //Tuomet yra einama per visus grupesDalykus, ir kreipiamasi į funkcija DeleteVertinimas, kur su jais susiję DB lenteles vertinimas įrašai yra trinami pagal raktą grupesDalykas
        //Ištrynus susijusius vertinimus yra ištrinamas pats grupėsDalykas iš DB lentelės grupesDalykas pagal objekto id atributą, besikreipiant į metodą DeleteGrupesDalykas
        //Atlikus tai yra kreipiamasi į metodą DeleteDalykas, kuriam yra perduodamas gautas objektas dalykas ir pagal jo id yra ištrinamas iš DB lenteles dalykas
        public void SalintiDalyka(Dalykas dalykas)
        {
            grupesDalykai = GetGrupesDalykai("WHERE dalykas=@dalykas", "", dalykas.Id);

            foreach(grupesDalykas g in grupesDalykai)
            {
                DeleteVertinimai(g);
                DeleteGrupesDalykas(g);
            }

            DeleteDalykas(dalykas);
        }

        //Yra gaunamas objektas grupesDalykas ir pagal jo atributą id, yra ištrinamas įrašas iš DB lentelės grupesDalykas
        public void DeleteGrupesDalykas(grupesDalykas gautas)
        {
            string sql = "DELETE FROM grupesDalykas WHERE id=@id";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", gautas.Id);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //Yra gaunamas objektas grupesDalykas ir pagal jo atributą id, kuris yra naudojamas kaip foreign key DB lentelėje vertinimas yra ištrinami visi susije įrašai
        public void DeleteVertinimai(grupesDalykas gautas)
        {
            string sql = "DELETE FROM vertinimas WHERE grupesDalykas=@grupesDalykas";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@grupesDalykas", gautas.Id);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //yra gaunamas objektas dalykas ir pagal jo atributą id yra ištrinmai visi suisiję įrašai iš DB lentelės dalykas
        public void DeleteDalykas(Dalykas dalykas)
        {
            string sql = "DELETE FROM dalykas WHERE id=@id";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", dalykas.Id);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //Yra gaunamas objektas dalykas, ir jo atributai pavadinimas ir destytojas yra įterpiami į DB lentelę dalykas
        public void InsertDalykas(Dalykas dalykas)
        {
            Console.WriteLine(dalykas.Destytojas);
            string sql = "INSERT INTO dalykas (destytojas, pavadinimas) VALUES (@destytojas, @pavadinimas)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@destytojas", dalykas.Destytojas);
            cmd.Parameters.AddWithValue("@pavadinimas", dalykas.Pavadinimas);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //Yra kreipiamasi į DB lentele grupesDalykas ir iš jos gražina visus yrašus kurie yra priskiriami objektų sąrašui grupesDalykas, tuomet tas sąrašas yra grąžinamas
        public List<grupesDalykas> GetVisusGrupesDalykus()
        {
            List<grupesDalykas> grupesDalykai = new List<grupesDalykas>();
            string sql = "SELECT * FROM grupesDalykas";
            SqlCommand cmd = new SqlCommand(sql, conn);

            conn.Open();
            using(SqlDataReader reader = cmd.ExecuteReader())
            {
                while(reader.Read())
                {
                    int id = Convert.ToInt32(reader["id"]);
                    int dalykas = Convert.ToInt32(reader["dalykas"]);
                    string grupe = reader["grupe"].ToString();
                    grupesDalykai.Add(new grupesDalykas(id, dalykas, grupe));
                }
            }
            conn.Close();
            return grupesDalykai;
        }

        //Yra gaunamas objektas grupes dalykas ir jo atributai yra įterpiami į DB lentelę grupesDalykas
        public void InsertGrupesDalytas(grupesDalykas gautas)
        {
            string sql = "INSERT INTO grupesDalykas (dalykas, grupe) VALUES (@dalykas, @grupe)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@dalykas", gautas.Dalykas);
            cmd.Parameters.AddWithValue("@grupe", gautas.Grupe);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
