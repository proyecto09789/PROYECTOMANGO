using PROYECTOBETA001;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PROYECTOMANGO
{
    public partial class FormPreguntas : Form
    {
        int indice = 0;
        int puntos = 0;

        string[] preguntas =
        {
            "¿Qué tipo de fruta es el mango?",
            "¿Dónde se cultivó por primera vez el mango?",
            "¿Hace cuánto se cultiva el mango?",
            "¿Qué símbolo está inspirado en la forma del mango?",
            "En India, regalar mangos significa:",
            "¿Quién meditaba bajo un árbol de mango según la leyenda?",
            "¿Con qué está relacionado el mango?",
            "¿Qué partes del mango se usan en remedios populares?",
            "¿Cuál es el nombre científico del mango?",
            "¿Cuánta vitamina C aporta una porción de mango?"
        };

        string[,] opciones =
        {
            { "Una baya", "Una drupa", "Un cítrico" },
            { "Brasil", "India", "México" },
            { "500 años", "1,000 años", "Más de 5,000 años" },
            { "El sol", "El patrón paisley", "El infinito" },
            { "Amor", "Tristeza", "Amistad" },
            { "Un rey", "Buda", "Un guerrero" },
            { "Uvas y manzanas", "Anacardos y pistachos", "Fresas y arándanos" },
            { "Solo la pulpa", "Solo la semilla", "Piel, pulpa, hojas y corteza" },
            { "Mangifera indica", "Musa acuminata", "Citrus sinensis" },
            { "10%", "25%", "50%" }
        };

        int[] respuestasCorrectas = { 1, 1, 2, 1, 2, 1, 1, 2, 0, 2 };
        public FormPreguntas()
        {
            InitializeComponent();
            MostrarPregunta();
        }

        void MostrarPregunta()
        {
            lblPreguntas.Text = preguntas[indice];
            rbOpcion1.Text = opciones[indice, 0];
            rbOpcion2.Text = opciones[indice, 1];
            rbOpcion3.Text = opciones[indice, 2];

            rbOpcion1.Checked = rbOpcion2.Checked = rbOpcion3.Checked = false;
            lblContador.Text = $"Pregunta {indice + 1} de {preguntas.Length}";
        }

        private void FormPreguntas_Load(object sender, EventArgs e)
        {

        }

        private void btnResponder_Click(object sender, EventArgs e)
        {
            int seleccion = -1;

            if (rbOpcion1.Checked) seleccion = 0;
            if (rbOpcion2.Checked) seleccion = 1;
            if (rbOpcion3.Checked) seleccion = 2;

            if (seleccion == -1)
            {
                MessageBox.Show("Selecciona una opción");
                return;
            }

            if (seleccion == respuestasCorrectas[indice])
            {
                puntos++;
                MessageBox.Show("¡Correcto! ");
            }
            else
            {
                MessageBox.Show("Incorrecto ");
            }

            indice++;

            if (indice < preguntas.Length)
            {
                MostrarPregunta();
            }
            else
            {
                MessageBox.Show(
                    $"Quiz terminado \nPuntaje: {puntos} de {preguntas.Length}",
                    "Resultado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                Interfazprinc inicio = new Interfazprinc();
                inicio.Show();
                this.Close();
            }
        }
    }
}

