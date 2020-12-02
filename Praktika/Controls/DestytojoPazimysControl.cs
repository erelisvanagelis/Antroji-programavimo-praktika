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
    public partial class DestytojoPazimysControl : UserControl
    {
        readonly Vertinimas gautas;

        //Gautas Vertinimo objektas yra priskiriamas DestytojoPazimysControl
        public DestytojoPazimysControl(Vertinimas gautas)
        {
            this.gautas = gautas;
            InitializeComponent();
            tipasComboBox.SelectedItem = gautas.Tipas;
            balasComboBox.SelectedIndex = 10 - gautas.Balas;
            dateTimePicker1.Value = DateTime.Parse(gautas.Data);
        }

        //Paspaudus patvirtinimo mygtuką gautas vertinimas yra atnaujinamas DB lentelėje vertinimas, naudojant DestytojoRepo metodą UpdateVertinimas  
        private void PatvirtintiButton_Click(object sender, EventArgs e)
        {
            DestytojoRepo destytojoRepo = new DestytojoRepo();

            string data = dateTimePicker1.Value.ToString();
            int balas = Convert.ToInt32(balasComboBox.SelectedItem);
            string tipas = tipasComboBox.SelectedItem.ToString();
            Vertinimas laikinas = new Vertinimas(gautas.Id, gautas.Studentas, gautas.Dalykas, data, balas, tipas);
            destytojoRepo.UpdateVertinimas(laikinas);
        }

        //Paspaudus trynimo mygtuką iššoką patvirtinimo langas, paspaudus yes gautas vertinimas yra ištrinamas iš DB lentelės vertinimas
        //Naudojant DestytojoRepo metodą DeleteVertinimas
        private void Trinti_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Ar tikrai norite išrinti įrašą?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DestytojoRepo destytojoRepo = new DestytojoRepo();
                destytojoRepo.DeleteVertinimas(gautas);
            }
        }
    }
}
