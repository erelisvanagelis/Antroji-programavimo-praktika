using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Praktika.Repozitorija;
using Praktika.Tipai;

namespace Praktika
{
    public partial class Prisijungimas : Form
    {
        readonly AsmuoRepo repo = new AsmuoRepo();
        public Prisijungimas()
        {
            InitializeComponent();
        }

        //Teksto laukuose gauta informacija yra siunčiama objektui AsmuoRepo metodui Prisijungti, jei prisijungti pavyks, objektas Asmuo prisijunges gaus tinkamą vertę
        //Ir pateks į jo grupei tinkamą langą
        private void Prisijungti_Click(object sender, EventArgs e)
        {
            try
            {
                repo.Prisijungti(prisijungimoBox.Text, slaptBox.Text);
                Asmuo prisijunges = repo.GetPrisijunges();
                Form ff = new Studento();

                if (prisijunges.GetGrupe() == "adminai")
                    ff = new Admino();


                if (prisijunges.GetGrupe() == "destytojai")
                    ff = new Destytojo();

                ff.ShowDialog();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
