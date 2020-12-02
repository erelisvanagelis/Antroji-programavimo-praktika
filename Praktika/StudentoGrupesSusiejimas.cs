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
    public partial class StudentoGrupesSusiejimas : Form
    {
        private AdminoRepo repoA;
        private List<Studentas> studentai;

        //Atnaujinti metodas turi viską ko reikia inicializavimui
        public StudentoGrupesSusiejimas()
        {
            InitializeComponent();
            Atnaujinti();
        }

        //Pasikeitus GrupeComboBox vertei pasikeičia ir StudentasComboBox vertės atinkačios GrupeComboBox verte
        //Šiu atvėju į grupei priklausančius narius
        private void AtskirtiGrupeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            atskirtiStudentasComboBox.Items.Clear();
            if (atskirtiGrupeComboBox.SelectedItem != null)
            {
                atskirtiStudentasComboBox.Text = null;
                string pasirinkta = atskirtiGrupeComboBox.SelectedItem.ToString();
                List<Studentas> laikini = studentai.FindAll(x => x.GetGrupe() == pasirinkta);

                foreach (Studentas s in laikini)
                {
                    atskirtiStudentasComboBox.Items.Add($"{s.GetVardas()} {s.GetPavarde()} Id. {s.GetId()}");
                }
            }
        }

        //Jei vertės yra tinkamos atskiria studentą nuo esamos grupės ir priskiria "nepriskirti", naudojant AdminRepo metodą UpadateAsmensGrupe
        private void AtskirtiButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (atskirtiStudentasComboBox.SelectedItem == null || atskirtiGrupeComboBox.SelectedItem == null)
                    throw new Exception("Nepasirinkote grupės arba studento");

                string pasirinktasStudentas = atskirtiStudentasComboBox.SelectedItem.ToString();
                int id = Convert.ToInt32(pasirinktasStudentas.Split(new[] { "Id. " }, StringSplitOptions.None)[1]);
                repoA.UpdateAsmensGrupe(id);

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        //Jei vertės yra tinkamos priskiria studentą prie pasirinktos grupės , naudojant AdminRepo metodą UpadateAsmensGrupe
        private void PriskirtiButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (priskirtiStudentasComboBox.SelectedItem == null || priskirtiGrupeComboBox.SelectedItem == null)
                    throw new Exception("Nepasirinkot grupės arba studento");

                string pasirinktasStudentas = priskirtiStudentasComboBox.SelectedItem.ToString();
                int StudentoId = Convert.ToInt32(pasirinktasStudentas.Split(new[] { "Id. " }, StringSplitOptions.None)[1]);
                string pasirinktaGrupe = priskirtiGrupeComboBox.SelectedItem.ToString();

                repoA.UpdateAsmensGrupe(StudentoId, pasirinktaGrupe);
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

        //Formos reikiamų verčių priskyrimas
        private void Atnaujinti()
        {
            try
            {
                atskirtiGrupeComboBox.Items.Clear();
                atskirtiStudentasComboBox.Items.Clear();
                priskirtiStudentasComboBox.Items.Clear();
                priskirtiGrupeComboBox.Items.Clear();
                atskirtiGrupeComboBox.Text = null;
                atskirtiStudentasComboBox.Text = null;
                priskirtiStudentasComboBox.Text = null;
                priskirtiGrupeComboBox.Text = null;

                repoA = new AdminoRepo();

                studentai = repoA.GetVisiNaudotojai().Studentai; 
                List<Grupe> grupes = repoA.GetGrupes();

                foreach (Grupe g in grupes)
                {
                    priskirtiGrupeComboBox.Items.Add(g.Pavadinimas);
                    atskirtiGrupeComboBox.Items.Add(g.Pavadinimas);
                }

                List<Studentas> laikini = studentai.FindAll(x => x.GetGrupe() == "nepriskirti");

                foreach (Studentas s in laikini)
                {
                    priskirtiStudentasComboBox.Items.Add($"{s.GetVardas()} {s.GetPavarde()} Id. {s.GetId()}");
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

    }
}


