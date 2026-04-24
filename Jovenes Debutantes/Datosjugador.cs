using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jovenes_Debutantes
{
    public partial class Datosjugador : Form
    {
        public Datosjugador()
        {
            InitializeComponent();
        }

        private void Datosjugador_Load(object sender, EventArgs e)
        {
            textBox1.Text = "REQUISITOS DEL PDF:\r\n\r\n" +
"• Datos personales\r\n" +
"• Datos deportivos\r\n" +
"• Datos físicos\r\n" +
"• Información médica\r\n" +
"• Signos vitales\r\n" +
"• Dictamen médico firmado";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            JovenPromesa jovenPromesa = new JovenPromesa();
            jovenPromesa.Show();
            this.Hide();
        }
    }
}
