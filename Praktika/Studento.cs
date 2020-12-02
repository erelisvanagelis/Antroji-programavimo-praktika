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
    public partial class Studento : Form
    {
        //deklaruojamos asmens ir studento repozitorijos
        private readonly AsmuoRepo repoA;
        private readonly StudentoRepo repoS;

        public Studento()
        {
            InitializeComponent();

            try
            {
                repoA = new AsmuoRepo();
                repoS = new StudentoRepo();
                
                //Yra gaunami su studentu (jo grupe) susieti dalykai ir tuose dalykuose saugomi pažymiai
                List<DalykoVertinimai> dalykuVertinimai = repoS.GetDalykai(repoA.GetPrisijunges());
                int width = dalykaiFlowLayoutPanel.Width - 5;
                
                //Kiekvienas gautas DalykoVertinimas prideda papildomą mygtuką į dalykaiFlowLayoutPanel, kuris parodys su šiu dalyku susijusius vertinimus
                foreach (DalykoVertinimai d in dalykuVertinimai)
                {
                    Button dalykasButton = new Button
                    {
                        Text = d.Pavadinimas,
                        Width = width,
                        Height = 40,
                        Tag = d
                    };
                    dalykasButton.Click += DalykasButton_Click;
                    dalykaiFlowLayoutPanel.Controls.Add(dalykasButton);
                }
                
            }
            catch(Exception exc)
            {

                Console.WriteLine(exc.Message);
            }
        }

        //Yra gaunama paspausto mygtuko tag informacija t. y. objektas DalykoVertinimas. Tuomet yra iteruojama per visus DalykoVertinimas atributo Vertinimų sąrašas objektus
        //ši informacija yra naudojama užpildant pazymiaiFlowLayoutPanel, PazimysPublicControl controleriais  
        private void DalykasButton_Click(object sender, EventArgs e)
        {
            pazymiaiFlowLayoutPanel.Controls.Clear();
            Button button = (Button)sender;
            DalykoVertinimai d = (DalykoVertinimai)button.Tag;
            int width = pazymiaiFlowLayoutPanel.Width - 5;
            foreach (Vertinimas v in d.Vertinimai)
            {
                PazimysPublicControl pazimys = new PazimysPublicControl(v)
                {
                    Width = width
                };
                pazymiaiFlowLayoutPanel.Controls.Add(pazimys);
            }
        }
    }
}
