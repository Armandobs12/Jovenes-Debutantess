using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Jovenes_Debutantes
{

    public partial class JovenPromesa : Form
    {
            private string rutaPDF;
        public JovenPromesa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();

            abrir.Title = "Selecciona Examen Médico";
            abrir.Filter = "Archivos PDF (*.pdf)|*.pdf";

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                rutaPDF = abrir.FileName;
                textBox1.Text = Path.GetFileName(rutaPDF);

                MessageBox.Show(
                    "El archivo PDF fue cargado exitosamente.",
                    "✔ Archivo Subido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(
                    "No se seleccionó ningún archivo.",
                    "⚠ Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TipoUsuario tp = new TipoUsuario();
            tp.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rutaPDF))
            {
                MessageBox.Show(
                    "Debes subir un archivo PDF antes de continuar.",
                    "⚠ Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            RegistrarPromesa rp = new RegistrarPromesa();
            rp.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           Datosjugador dt  = new Datosjugador();
            dt.Show();
            this.Hide();
        }
    }
}
