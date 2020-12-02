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
    public partial class DalykoGrupesSusiejimas : Form
    {
        AdminoRepo repoA;
        List<Dalykas> dalykai;
        List<grupesDalykas> grupesDalykai;
        public DalykoGrupesSusiejimas()
        {
            InitializeComponent();
            Atnaujinti();
        }

        //Pasikeitus parinktai grupei pasikeičia ir ką rodys atitinkamoje DalykasComboBox
        //Šiuo atvėju visus su grupe susijusius mokomuosius dalykus
        private void AtskirtiGrupeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            atskirtiDalykasComboBox.Items.Clear();
            if (atskirtiGrupeComboBox.SelectedItem != null)
            {
                atskirtiDalykasComboBox.Text = null;
                string pasirinkta = atskirtiGrupeComboBox.SelectedItem.ToString();
                List<grupesDalykas> laikini = grupesDalykai.FindAll(x => x.Grupe == pasirinkta);

                foreach (Dalykas d in dalykai)
                {
                    if(laikini.Exists(x => x.Dalykas == d.Id))
                        atskirtiDalykasComboBox.Items.Add($"{d.Pavadinimas} Id. {d.Id}");
                }
            }
        }

        //Pasikeitus parinktai grupei pasikeičia ir ką rodys atitinkamoje DalykasComboBox
        //Šiuo atvėju rodys visus su grupe nesusijusius mokomuosius dalykus
        private void PriskirtiGrupeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            priskirtiDalykasComboBox.Items.Clear();
            if (priskirtiGrupeComboBox.SelectedItem != null)
            {
                priskirtiDalykasComboBox.Text = null;
                string pasirinkta = priskirtiGrupeComboBox.SelectedItem.ToString();
                List<grupesDalykas> laikini = grupesDalykai.FindAll(x => x.Grupe == pasirinkta);

                foreach (Dalykas d in dalykai)
                {
                    if (!laikini.Exists(x => x.Dalykas == d.Id))
                        priskirtiDalykasComboBox.Items.Add($"{d.Pavadinimas} Id. {d.Id}");
                }
            }
        }

        //Jei duotos vertes yra tinkamos su grupe ir dalyku susije vertinimai bus pašalint, o poto ir juos siejantis įrašas iš DB
        private void AtskirtiButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (atskirtiDalykasComboBox.SelectedItem == null || atskirtiGrupeComboBox.SelectedItem == null)
                    throw new Exception("Nepasirinkote grupės arba dalyko");

                string pasirinktaGrupe = atskirtiGrupeComboBox.SelectedItem.ToString();
                string pasirinktasDalykas = atskirtiDalykasComboBox.SelectedItem.ToString();
                int id = Convert.ToInt32(pasirinktasDalykas.Split(new[] { "Id. " }, StringSplitOptions.None)[1]);

                grupesDalykas g = grupesDalykai.Find(x => x.Grupe == pasirinktaGrupe && x.Dalykas == id);
                repoA.DeleteVertinimai(g);
                repoA.DeleteGrupesDalykas(g);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        //Jei duotos vertes yra tinkamos su grupe ir dalykas yra susiejami naudojant AdminoRepo metodą InsertGrupesDalykas, į DB lentelę grupesDalykas pateks naujas įrašas
        //pasirinktas dalykas bus pašalinamas ir iš dalykuComboBox ir iš sąrašo, kad nebūtu bandoma susieti kelis, kart tų pačių grupių su tais pačiais dalykais
        private void PriskirtiButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (priskirtiDalykasComboBox.SelectedItem == null || priskirtiGrupeComboBox.SelectedItem == null)
                    throw new Exception("Nepasirinkot grupės arba dalyko");

                string pasirinktasDalykas = priskirtiDalykasComboBox.SelectedItem.ToString();
                int dalykoId = Convert.ToInt32(pasirinktasDalykas.Split(new[] { "Id. " }, StringSplitOptions.None)[1]);
                string pasirinktaGrupe = priskirtiGrupeComboBox.SelectedItem.ToString();
                repoA.InsertGrupesDalytas(new grupesDalykas(0, dalykoId, pasirinktaGrupe));

                grupesDalykai.RemoveAll(x => x.Dalykas == dalykoId && x.Grupe == pasirinktaGrupe);
                priskirtiDalykasComboBox.Items.Remove(priskirtiDalykasComboBox.SelectedItem);
                priskirtiDalykasComboBox.SelectedItem = null;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void AtnaujintiButton_Click(object sender, EventArgs e)
        {
            Atnaujinti();
        }

        //Viskas išvaloma ir tuomet priskiriam objektus ir užpildom forma reikiama informacija
        private void Atnaujinti()
        {
            try
            {
                atskirtiGrupeComboBox.Items.Clear();
                atskirtiDalykasComboBox.Items.Clear();
                priskirtiDalykasComboBox.Items.Clear();
                priskirtiGrupeComboBox.Items.Clear();
                atskirtiGrupeComboBox.Text = null;
                atskirtiDalykasComboBox.Text = null;
                priskirtiDalykasComboBox.Text = null;
                priskirtiGrupeComboBox.Text = null;

                repoA = new AdminoRepo();
                List<Studentas> destytojai = repoA.GetDestytojai();
                dalykai = repoA.GetVisiDalykai(destytojai);
                grupesDalykai = repoA.GetVisusGrupesDalykus();
                List<Grupe> grupes = repoA.GetGrupes();

                foreach (Grupe g in grupes)
                {
                    priskirtiGrupeComboBox.Items.Add(g.Pavadinimas);
                    atskirtiGrupeComboBox.Items.Add(g.Pavadinimas);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

    }
}
