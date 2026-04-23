using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using AxWMPLib;
using WMPLib;

namespace Jovenes_Debutantes
{
    public partial class Inicio : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();

       


        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            player.URL = Application.StartupPath + @"\Resources\cancion.mp3";
            player.settings.setMode("loop", true);
            player.controls.play();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registrarte rg = new Registrarte(); 
            rg.Show();
            this.Hide();
            player.controls.stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == Sesion.Usuario && textBox2.Text == Sesion.Password)
            {
                MessageBox.Show("Bienvenido","Ha iniciado Sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Menu menu = new Menu();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Datos incorrectos","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
