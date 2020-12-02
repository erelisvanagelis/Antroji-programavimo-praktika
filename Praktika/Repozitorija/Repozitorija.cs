using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Praktika.Tipai;

namespace Praktika.Repozitorija
{
    //Abstrakti klasė nes ji pati nebus kuriama, bet paveldima visų kitų repozitorijų
    abstract class Repozitorija
    {
        protected SqlConnection conn;

        //Yra sukuriamas ryšys su duomenų baze, to nepavykus atlikti yra išmetama klaida
        public Repozitorija()
        {
            try
            {
                conn = new SqlConnection("Server=.;Database = praktika;Integrated Security = SSPI;");
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                throw new Exception("Nepavyko prisijungti prie serverio");
            }
        }
    }
}
