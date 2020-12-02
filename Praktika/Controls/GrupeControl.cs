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
    public partial class GrupeControl : UserControl
    {
        private readonly AdminoRepo repoA;
        private readonly Grupe grupe;
        private readonly FlowLayoutPanel panele;
        //Controleriui yra priskiriamas gautos grupes objekto atributas pavadinimas, jei vienas gautų atributų yra netrinamas trynimo galimybės yra išjungtos
        public GrupeControl(Grupe grupe, FlowLayoutPanel panele)
        {
            InitializeComponent();
            repoA = new AdminoRepo();

            this.grupe = grupe;
            this.panele = panele;

            grupeButton.Text = grupe.Pavadinimas;

            if (grupe.Pavadinimas == "nepriskirti" || grupe.Pavadinimas == "destytojai" || grupe.Pavadinimas == "adminai" || grupe.Pavadinimas == "Visi naudotojai")
            {
                salintButton.Enabled = false;
                suNariaisButton.Enabled = false;
            }
        }

        //Paspaudos grupes pavadinimo mygtuką grupes atributo studentų sąrašas yra naudojamas užpildant gautą FlowLayoutPanel AsmuoControl controleriais, kurie naudoja
        //studentą reikiamiems atributams gauti
        private void GrupeButton_Click(object sender, EventArgs e)
        {
            panele.Controls.Clear();
            foreach (Studentas s in grupe.Studentai)
            {
                panele.Controls.Add(new AsmuoControl(s));
            }
        }

        //Atskiria naudotojus nuo grupės ir ištrina grupę naudojant AdminRepo metodą SalintiGrupe, kuri pašalina duotą grupę iš DB lentelės grupe
        private void SalintButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ar tikrai norite išrinti įrašą?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DisableButtons();
                repoA.SalintiGrupe(grupe);
            }
        }

        //Pašaline grupę, kartu su jos naudotojais naudojant AdminRepo metodą SalintiGrupeSuStudentais, kuri pašalina duotą grupę iš DB lentelės grupe
        //Ir studentus iš lentelės asmuo
        private void SuNariaisButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ar tikrai norite išrinti įrašą?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DisableButtons();
                repoA.SalintiGrupeSuStudentais(grupe);

            }
        }

        //Nebeleižia naudoti kontrolerio mygtukų
        private void DisableButtons()
        {
            grupeButton.Enabled = false;
            salintButton.Enabled = false;
            suNariaisButton.Enabled = false;
        }
    }
}
