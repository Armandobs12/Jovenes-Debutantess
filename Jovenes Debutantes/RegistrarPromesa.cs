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
    public partial class RegistrarPromesa : Form
    {
        public RegistrarPromesa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sesion.Usuario = textBox1.Text;
            Sesion.Password = textBox2.Text;

            MessageBox.Show("Usuario registrado");
            Inicio ic = new Inicio();
            ic.Show();

            this.Close(); // regresa al login
        }
    }
}
