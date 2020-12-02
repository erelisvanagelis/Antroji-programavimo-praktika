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
    public partial class Destytojo : Form
    {
        private readonly AsmuoRepo repoA;
        private readonly DestytojoRepo repoD;
        int dalykoId;

        public Destytojo()
        {
            InitializeComponent();

            // priskiriami reikiami objektai ir užpildoma dalykoFlowLayoutPanel mygtukais kurie turi turi dalyko pavadinimą ir su šituo dalyku susietas grupes
            try
            {
                repoA = new AsmuoRepo();
                repoD = new DestytojoRepo();
                List<Dalykas> dalykai = repoD.GetUzpildytiDalykai(repoA.GetPrisijunges());

                int width = dalykoFlowLayoutPanel.Width - 5;

                foreach (Dalykas d in dalykai)
                {
                    Button dalykasButton = new Button
                    {
                        Text = d.Pavadinimas,
                        Width = width,
                        Height = 40,
                        Tag = d,
                    };
                    dalykasButton.Click += DalykasButton_Click;
                    dalykoFlowLayoutPanel.Controls.Add(dalykasButton);
                }
            }
            catch (Exception exc)
            {

                Console.WriteLine(exc.Message);
            }
        }

        // priskiriami reikiami objektai ir užpildoma grupesFlowLayoutPanel mygtukais kurie turi turi grupes pavadinimą ir su šita grupe susietus studentus
        private void DalykasButton_Click(object sender, EventArgs e)
        {
            grupesFlowLayoutPanel.Controls.Clear();
            studentoFlowLayoutPanel.Controls.Clear();
            Button button = (Button)sender;
            Dalykas d = (Dalykas)button.Tag;
            dalykoId = d.Id;
            int width = grupesFlowLayoutPanel.Width - 5;
            foreach (Grupe g in d.Grupes)
            {
                Button grupeButton = new Button
                {
                    Text = g.Pavadinimas,
                    Width = width,
                    Height = 40,
                    Tag = g
                };
                grupeButton.Click += GrupeButton_Click;
                grupesFlowLayoutPanel.Controls.Add(grupeButton);
            }
        }

        // priskiriami reikiami objektai ir užpildoma studentoFlowLayoutPanel mygtukais kurie turi turi studento vardą ir pavardę, ir turi su juo susietus vertinimus
        private void GrupeButton_Click(object sender, EventArgs e)
        {
            studentoFlowLayoutPanel.Controls.Clear();
            Button button = (Button)sender;
            Grupe g = (Grupe)button.Tag;
            int width = studentoFlowLayoutPanel.Width - 5;
            foreach (Studentas s in g.Studentai)
            {
                Button studentasButton = new Button
                {
                    Text = $"{s.GetVardas()} {s.GetPavarde()}",
                    Width = width,
                    Height = 40,
                    Tag = s,
                };
                studentasButton.Click += StudentasButton_Click;
                studentoFlowLayoutPanel.Controls.Add(studentasButton);
            }
        }

        //Paspaudus ant studento mygtuko yra atidaromas naujas langas (kuris gaus informacija apie studentą ant kurio buvo paspaustą ir kurio grupės dalyko pažymiai tai turėtu būti
        private void StudentasButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Studentas s = (Studentas)button.Tag;
            Form ff = new DestytojoPazymiai(s, dalykoId);
            ff.ShowDialog();
        }
    }
}
