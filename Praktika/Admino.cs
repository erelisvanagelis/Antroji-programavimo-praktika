using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktika
{
    public partial class Admino : Form
    {
        public Admino()
        {
            InitializeComponent();
        }

        private void NaudotojaiButton_Click(object sender, EventArgs e)
        {
            Form ff = new AdminoNaudotojai();
            ff.Show();
        }

        private void DalykuButton_Click(object sender, EventArgs e)
        {
            Form ff = new MokomiejiDalykai();
            ff.Show();
        }

        private void DestytojasDalykasButton_Click(object sender, EventArgs e)
        {
            Form ff = new DestyojoDalykoSusiejimas();
            ff.Show();
        }

        private void DalykoGrupesButton_Click(object sender, EventArgs e)
        {
            Form ff = new DalykoGrupesSusiejimas();
            ff.Show();
        }

        private void StudentoGrupesButton_Click(object sender, EventArgs e)
        {
            Form ff = new StudentoGrupesSusiejimas();
            ff.Show();
        }
    }
}
