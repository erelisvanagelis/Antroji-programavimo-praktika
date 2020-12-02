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
    public partial class DestytojoPazymiai : Form
    {
        private readonly DestytojoRepo repoD;
        private readonly Asmuo gautas;
        private readonly int dalykoId;

        public DestytojoPazymiai(Asmuo gautas, int dalykoId)
        {
            InitializeComponent();
            TipaiComboBox.SelectedIndex = 0;
            balaiComboBox.SelectedIndex = 0;

            // priskiriami reikiami objektai ir užpildoma pazymiaiFlowLayoutPanel DestytojoPazimysControls
            // Jie gauna reikiama informacija iš gauto objektų sąrašo Vertinimas
            // Su kiekviena iteracija yra pridedamas DestytojoPazimysControls kuris gauna atitinkama vertinima
            try
            {
                this.gautas = gautas;
                this.dalykoId = dalykoId;
                repoD = new DestytojoRepo();
                List<Vertinimas> vertinimai = repoD.GetVertinimai(gautas.GetId(), dalykoId);

                pazymiaiFlowLayoutPanel.Controls.Clear();
                int width = pazymiaiFlowLayoutPanel.Width - 5;
                foreach (Vertinimas v in vertinimai)
                {
                    DestytojoPazimysControl pazimys = new DestytojoPazimysControl(v)
                    {
                        Width = width
                    };
                    pazymiaiFlowLayoutPanel.Controls.Add(pazimys);
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        //Paspaudus mygtuką užpildyta informacija yra priskiriama objektui Vertinimas, kur yra tikrinama ar gauta informacija atitinka reikalavimus
        //Jei atitinka, Vertinimas yra įterpiamas į DB lentelę vertinimas naudojant DestytojoRepo metodą InsertVertinimas
        //Tuomet įterptas vertinimas yra pavaizduojamas pridedant naują elementą į pazymiaiFlowLayoutPanel
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                DestytojoRepo destytojoRepo = new DestytojoRepo();
                string data = dateTimePicker1.Value.ToString();
                int balas = Convert.ToInt32(balaiComboBox.SelectedItem);
                string tipas = TipaiComboBox.SelectedItem.ToString();
                Vertinimas laikinas = new Vertinimas(0, gautas.GetId(), dalykoId, data, balas, tipas);

                destytojoRepo.InsertVertinimas(laikinas);

                DestytojoPazimysControl pazimys = new DestytojoPazimysControl(laikinas)
                {
                    Width = pazymiaiFlowLayoutPanel.Width - 5
                };

                pazymiaiFlowLayoutPanel.SuspendLayout();
                pazymiaiFlowLayoutPanel.Controls.Add(pazimys);
                pazymiaiFlowLayoutPanel.Controls.SetChildIndex(pazimys, 0);
                pazymiaiFlowLayoutPanel.ResumeLayout();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
