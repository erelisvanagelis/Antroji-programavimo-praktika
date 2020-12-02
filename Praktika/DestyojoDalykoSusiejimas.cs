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
    public partial class DestyojoDalykoSusiejimas : Form
    {
        AdminoRepo repoA;
        List<Dalykas> dalykai;
        public DestyojoDalykoSusiejimas()
        {
            InitializeComponent();
            Atnaujinti();
        }

        //Pasikeitus parinktai vertei pasikeis ir atitinkamą vertės DalykasComboBox
        //DalykasComboBox yra priskiriami su dėstytoju susije dalykai
        private void AtskirtiDestytojasComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            atskirtiDalykasComboBox.Items.Clear();
            if (atskirtiDestytojasComboBox.SelectedItem != null)
            {
                atskirtiDalykasComboBox.Text = null;
                string pasirinktas = atskirtiDestytojasComboBox.SelectedItem.ToString();
                int id = Convert.ToInt32(pasirinktas.Split(new[] { "Id. " }, StringSplitOptions.None)[1]);
                List<Dalykas> laikini = dalykai.FindAll(x => x.Destytojas == id);

                foreach(Dalykas d in laikini)
                {
                    atskirtiDalykasComboBox.Items.Add($"{d.Pavadinimas} Id. {d.Id}");
                }
            }
        }

        //Jei pasirinktos vertės yra tinkamos dalykas yra atskiriamas nuo dėstytojo pagal pasirinkto dalyko id.
        //Šią vertę perduodant AdminoRepo metodui UpdateDalykas, kuris atnaujins įrašą DB lentelėje dalykas
        private void AtskirtiButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (atskirtiDalykasComboBox.SelectedItem == null || atskirtiDestytojasComboBox.SelectedItem == null)
                    throw new Exception("Nepasirinkot dėstytojo ir grupės");

                string pasirinktas = atskirtiDalykasComboBox.SelectedItem.ToString();
                int id = Convert.ToInt32(pasirinktas.Split(new[] { "Id. " }, StringSplitOptions.None)[1]);
                repoA.UpdateDalykas(id);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        //Jei pasirinktos vertės yra tinkamos dalykas yra atskiriamas nuo dėstytojo pagal pasirinkto dalyko id.
        //pasirinktam destytojui yra priskiriamas pasirinktas dalykas naudojant gautas jų id vertes, naudojant AdminRepo metodą UpdateDalykas
        //atnaujina DB lentelės dalykas įrašo, dėstytojo raktą į gautą
        private void PriskirtiButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (priskirtiDalykasComboBox.SelectedItem == null || priskirtiDestytojasComboBox.SelectedItem == null)
                    throw new Exception("Nepasirinkot dėstytojo ir grupės");

                string pasirinktasDalykas = priskirtiDalykasComboBox.SelectedItem.ToString();
                int dalykoId = Convert.ToInt32(pasirinktasDalykas.Split(new[] { "Id. " }, StringSplitOptions.None)[1]);

                string pasirinktasDestytojas = priskirtiDestytojasComboBox.SelectedItem.ToString();
                int destyojoId = Convert.ToInt32(pasirinktasDestytojas.Split(new[] { "Id. " }, StringSplitOptions.None)[1]);

                repoA.UpdateDalykas(dalykoId, destyojoId);
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

        //priskiriami objektai, ir užpildoma forma
        private void Atnaujinti()
        {
            try
            {
                repoA = new AdminoRepo();
                List<Studentas> destytojai = repoA.GetDestytojai();

                atskirtiDestytojasComboBox.Items.Clear();
                atskirtiDalykasComboBox.Items.Clear();
                priskirtiDalykasComboBox.Items.Clear();
                priskirtiDestytojasComboBox.Items.Clear();

                atskirtiDestytojasComboBox.Text = null;
                atskirtiDalykasComboBox.Text = null;
                priskirtiDalykasComboBox.Text = null;
                priskirtiDestytojasComboBox.Text = null;

                foreach (Studentas s in destytojai)
                {
                    atskirtiDestytojasComboBox.Items.Add($"{s.GetVardas()} {s.GetPavarde()} Id. {s.GetId()}");
                    priskirtiDestytojasComboBox.Items.Add($"{s.GetVardas()} {s.GetPavarde()} Id. {s.GetId()}");
                }
                atskirtiDestytojasComboBox.Items.RemoveAt(0);
                priskirtiDestytojasComboBox.Items.RemoveAt(0);
                dalykai = repoA.GetVisiDalykai(destytojai);

                List<Dalykas> laikini = dalykai.FindAll(x => x.Destytojas == 1);
                foreach (Dalykas d in laikini)
                {
                    priskirtiDalykasComboBox.Items.Add($"{d.Pavadinimas} Id. {d.Id}");
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
