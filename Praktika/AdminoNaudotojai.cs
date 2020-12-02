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
    public partial class AdminoNaudotojai : Form
    {
        private AdminoRepo repoA;
        public AdminoNaudotojai()
        {
            InitializeComponent();
            Atnaujinti();
        }

        //Kad numatytuoju būdu Vardas taptu prisijungimoVardu, o pavarde slaptažodžiu
        private void VardasTextBox_TextChanged(object sender, EventArgs e) => prisijungimasTextBox.Text = ((TextBox)sender).Text;
        private void PavardeTextBox_TextChanged(object sender, EventArgs e) => slaptazodisTextBox.Text = ((TextBox)sender).Text;

        //sukuriamas naujas objektas Asmuo, jei informacija yra tinkama, jis yra įterpimas į DB lentelę asmuo naudojant AdminoRepo metodą InsertAsmuo 
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                repoA.InsertAsmuo(new Asmuo("0", vardasTextBox.Text, pavardeTextBox.Text,
                    grupeComboBox.SelectedItem.ToString(), slaptazodisTextBox.Text, prisijungimasTextBox.Text));
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        //Iterpiama nauja grupė, jeigu tokia grupė dar neegzistuoja DB lenteleje grupe
        private void GrupeButton_Click(object sender, EventArgs e)
        {
            try
            {
                repoA.IterptiGrupe(grupeTextBox.Text);
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Atnaujinti();
        }

        //Inicializuoja formą ir ją atnaujina paspaudus mygtuką
        //Gauna visų grupių sąrašą, jį iteruoja ir užpildo grupeFlowLayouPanel grupeControl kontroleriais, tie kontroleriai turi grupei priskirtą studentų sąrašą, kuris 
        //bus naudojamas priskirti AsmuoControls 
        private void Atnaujinti()
        {
            repoA = new AdminoRepo();
            List<Grupe> grupes = repoA.GetGrupes();
            grupeComboBox.Items.Clear();
            vardasTextBox.Text = "";
            pavardeTextBox.Text = "";
            grupeFlowLayoutPanel.Controls.Clear();
            asmuoLayoutPanel.Controls.Clear();

            try
            {
                foreach (Grupe g in grupes)
                {
                    grupeComboBox.Items.Add(g.Pavadinimas);
                }
                grupeComboBox.SelectedItem = "nepriskirti";

                grupes.Insert(0, repoA.GetVisiNaudotojai());
                int width = grupeFlowLayoutPanel.Width - 5;
                foreach (Grupe g in grupes)
                {
                    grupeFlowLayoutPanel.Controls.Add(new GrupeControl(g, asmuoLayoutPanel));
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
