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
    public partial class MokomiejiDalykai : Form
    {
        private readonly AdminoRepo repoA;
        private readonly List<Studentas> destytojai;

        //Priskiriami objektai, ComboBox užpildomas destytojais, o dalykaiFlowLayoutPanel užpildoma DalykasControl kontroleriais
        public MokomiejiDalykai()
        {
            InitializeComponent();
            repoA = new AdminoRepo();
            destytojai = repoA.GetDestytojai();
            
            foreach (Studentas s in destytojai)
            {
                destytojasComboBox.Items.Add($"{s.GetVardas()} {s.GetPavarde()}, Id. {s.GetId()}");
            }

            List<Dalykas> dalykai = repoA.GetVisiDalykai(destytojai);
            foreach (Dalykas d in dalykai)
            {
                if (destytojai.Exists(x => x.GetId() == d.Destytojas))
                    dalykaiFlowLayoutPanel.Controls.Add(new DalykasControl(d, destytojai.Find(x => x.GetId() == d.Destytojas)));
            }

            destytojasComboBox.SelectedIndex = 0;
        }

        //Jei pasirinkt verte yra tinkama yra įterpiamas naujas dalykas į DB lentele dalykas, naudojant AdminRepo metodą InsertDalykas
        private void PridėtiButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (destytojasComboBox.SelectedItem == null)
                    throw new Exception("Toks destytojas neegzistuoja");

                string pasirinktas = destytojasComboBox.SelectedItem.ToString();
                int id = Convert.ToInt32(pasirinktas.Split(new[] { "Id. " }, StringSplitOptions.None)[1]);
                    repoA.InsertDalykas(new Dalykas(0, id, pavadinimasTextBox.Text.ToString(), ""));
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
