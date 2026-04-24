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
            TipoUsuario tipoUsuario = new TipoUsuario();
            tipoUsuario.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == Sesion.Usuario && textBox2.Text == Sesion.Password)
            {
                MessageBox.Show("Bienvenido", "Ha iniciado Sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 🔥 AQUÍ decides a dónde mandarlo
                if (SesionGlobal.TipoUsuario == "normal")
                {
                    Menu menu = new Menu();
                    menu.Show();
                }
                else if (SesionGlobal.TipoUsuario == "promesa")
                {
                    MenuPromesa promesa = new MenuPromesa();
                    promesa.Show();
                }
                else
                {
                    MessageBox.Show("Debes seleccionar tipo de usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Datos incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
