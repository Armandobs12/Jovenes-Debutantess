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
    public partial class Terminos_y_condiciones : Form
    {
        public Terminos_y_condiciones()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = checkBox1.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido al sistema", "Acceso permitido",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Aquí puedes abrir tu menú principal
            PrimeraVentana pv = new PrimeraVentana();
            pv.Show();
            this.Hide();
        }

        private void Terminos_y_condiciones_Load(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text = "© 2026 Jóvenes Debutantes\r\n\r\n" +
            "Todos los derechos reservados.\r\n\r\n" +

            "El presente sistema ha sido desarrollado con fines educativos y administrativos.\r\n" +
            "Al acceder a este software, el usuario acepta cumplir con las normas básicas de uso, evitando cualquier acción que comprometa la integridad del sistema.\r\n\r\n" +

            "Queda estrictamente prohibida la copia, distribución o modificación del programa sin autorización previa. El uso indebido puede resultar en la suspensión del acceso.\r\n\r\n" +

            "El sistema se proporciona \"tal cual\", sin garantías de funcionamiento continuo o libre de errores. El desarrollador no se hace responsable por pérdidas de información o daños derivados del uso incorrecto del software.\r\n\r\n" +

            "El usuario acepta utilizar este sistema de manera responsable, ética y conforme a los principios básicos del uso de tecnología.\r\n\r\n" +

            "---------------------------------------------------------------------\r\n\r\n" +

            "Ahora que ya aceptaste (o fingiste aceptar 👀), aquí va algo que no tiene nada que ver:\r\n\r\n" +

            "¿Has escuchado de Five Nights at Freddy's?\r\n" +
            "Ese juego donde dices \"nah, no da miedo\" y terminas brincando de la silla a las 3 AM.\r\n\r\n" +

            "Todo empieza con una pizzería \"tranquila\" (claro, cómo no 🙄), donde unos animatrónicos como Freddy Fazbear y sus compas deciden que caminar en la noche es buena idea… totalmente normal, ¿no?\r\n\r\n" +

             "Luego aparece un tipo nada sospechoso llamado William Afton, también conocido como \"el que definitivamente NO debería estar cerca de niños\" 💀.\r\n\r\n" +

             "Entre teorías, almas, robots poseídos y jumpscares que te quitan años de vida, la historia se vuelve más enredada que cables de audífonos en tu bolsillo.\r\n\r\n" +

             "Y tú ahí, vigilando cámaras como:\r\n" +
             "\"todo está tranquilo…\"\r\n" +
             "*se apaga la luz*\r\n" +
             "\"ya valí.\"\r\n\r\n" +

             "Pero bueno, regresando a lo importante (según este documento serio que claramente ya dejó de ser serio):\r\n\r\n" +

             "Al continuar utilizando este sistema, usted confirma que leyó, entendió y aceptó todos los términos aquí descritos, incluso la parte donde probablemente dejaste de leer.\r\n\r\n" +

             "---------------------------------------------------------------------\r\n\r\n" +

             "Desarrollado por: Ingeebrios\r\n" +
             "Versión: 1.0\r\n" +
             "Año: 2026\r\n\r\n" +

             "enserio alguien lee esto?";


        }
    }
}
