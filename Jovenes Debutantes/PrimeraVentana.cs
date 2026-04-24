using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxWMPLib;

namespace Jovenes_Debutantes
{
    

    public partial class PrimeraVentana : Form
    {
        public PrimeraVentana()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Video vd = new Video(); 
            vd.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inicio ini = new Inicio();  
            ini.Show();
            this.Hide();
        }
    }
}
