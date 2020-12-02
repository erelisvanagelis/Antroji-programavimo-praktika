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
    public partial class AsmuoControl : UserControl
    {
        private readonly Studentas studentas;
        private readonly AdminoRepo repoA;

        //reikiami objektai yra priskiriami, o AsmuoControl controleris yra užpildomas gautomis objekto Studentas vertėmis
        public AsmuoControl(Studentas studentas)
        {
            InitializeComponent();
            this.studentas = studentas;
            repoA = new AdminoRepo();

            idLabel.Text = studentas.GetId().ToString();
            vardasLabel.Text = studentas.GetVardas();
            pavardeLabel.Text = studentas.GetPavarde();
            grupeLabel.Text = studentas.GetGrupe();
            prisijungimoVLabel.Text = studentas.GetPrisijungimoV();
            slaptazodisLabel.Text = studentas.GetSlaptazodis();

            if (studentas.GetId() == 1)
                salintiButton.Enabled = false;
        }

        //Paspaudus mygtuką iššoką patvirtinimo langas, paspaudus yes įrašas yra pašalinamas kreipiantis į AdminoRepo metodą salinti naudotoją pašalinant inicializacijoje
        //gautą studentą iš DB lentelės asmuo
        private void SalintiButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ar tikrai norite išrinti įrašą?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                repoA.SalintiNaudotoja(studentas);
                salintiButton.Enabled = false;
            }

        }
    }
}
