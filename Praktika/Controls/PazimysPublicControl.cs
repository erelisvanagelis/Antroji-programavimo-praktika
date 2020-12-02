using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Praktika.Tipai;

namespace Praktika
{
    public partial class PazimysPublicControl : UserControl
    {
        //Priskiriam gauto Vertinimo atributai
        public PazimysPublicControl(Vertinimas gautas)
        {
            InitializeComponent();

            tipaslabel.Text = gautas.Tipas;
            pazimysLabel.Text = gautas.Balas.ToString();
            dataLabel.Text = gautas.Data;
            
        }
    }
}
