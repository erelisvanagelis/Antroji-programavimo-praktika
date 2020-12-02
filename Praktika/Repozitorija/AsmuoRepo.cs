using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Praktika.Tipai;

namespace Praktika.Repozitorija 
{
    class AsmuoRepo : Repozitorija
    {
        static Asmuo prisijunges;

        public AsmuoRepo() : base() { }

        //Yra gaunami du string objektai, jie patikrinami ar nėra tušti, ir tuomet DB lentelėje yra ieškomas įrašas atitinkantis šias vertes
        //jį radus įrašo vertes yra priskiriamos objektui Asmuo
        public void Prisijungti(string prisijungimoV, string slaptazodis)
        {
            prisijunges = null;

            if (String.IsNullOrWhiteSpace(slaptazodis))
                throw new Exception("netinkamas slaptazodis");

            if (String.IsNullOrWhiteSpace(prisijungimoV))
                throw new Exception("netinkamas prisijungimo vardas");

            string sql = "SELECT * FROM asmuo WHERE prisijungimoV=@prisijungimoV and slaptazodis=@slaptazodis"; 

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@prisijungimoV", prisijungimoV);
            cmd.Parameters.AddWithValue("@slaptazodis", slaptazodis);
            conn.Open();

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    string id = reader["id"].ToString();
                    string vardas = reader["vardas"].ToString();
                    string pavarde = reader["pavarde"].ToString();
                    string grupe = reader["grupe"].ToString();
                    string password = reader["slaptazodis"].ToString();
                    string nickname = reader["PrisijungimoV"].ToString();
                    prisijunges = new Asmuo(id, vardas, pavarde, grupe, password, nickname);
                }
            }
            conn.Close();

            if (prisijunges == null)
            {
                throw new Exception("Netinkami Prisijungimo duomenys");
            }
        }

        public Asmuo GetPrisijunges() => prisijunges;
    }
}
