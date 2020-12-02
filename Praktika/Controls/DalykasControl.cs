using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Praktika.Repozitorija;
using Praktika.Tipai;

namespace Praktika
{
    public partial class DalykasControl : UserControl
    {
        private readonly Dalykas dalykas;
        private readonly AdminoRepo repoA;

        //reikiami objektai yra priskiriami, o DalykasControl controleris yra užpildomas gautomis objekto Dalykas ir Asmuo vertėmis
        public DalykasControl(Dalykas dalykas, Asmuo asmuo)
        {
            InitializeComponent();
            this.dalykas = dalykas;
            repoA = new AdminoRepo();

            idLabel.Text = dalykas.Id.ToString();
            pavadinimasLabel.Text = dalykas.Pavadinimas;
            destytojoIdLabel.Text = asmuo.GetId().ToString();
            vardasLabel.Text = asmuo.GetVardas();
            pavardeLabel.Text = asmuo.GetPavarde();
        }

        //Paspaudus mygtuką iššoką patvirtinimo langas, paspaudus yes įrašas yra pašalinamas kreipiantis į AdminoRepo metodą SalintiDalyka pašalinant inicializacijoje
        //gautą dalyka iš DB lentelės dalykas
        private void PasalantiButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ar tikrai norite išrinti įrašą?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                pasalantiButton.Enabled = false;
                repoA.SalintiDalyka(dalykas);
            }
        }
    }
}
