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
            "¿Qué vitamina es abundante en el mango?",
            "¿Cuántas variedades de mango existen aproximadamente?"
        };

        string[,] opciones =
        {
            { "Una baya", "Una drupa", "Un cítrico" },
            { "Vitamina C", "Vitamina D", "Vitamina B12" },
            { "10", "Más de 100", "Solo 5" }
        };

        int[] respuestasCorrectas = { 1, 0, 1 };
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

                // Volver al inicio
                Interfazprinc inicio = new Interfazprinc();
                inicio.Show();
                this.Close();
            }
        }
    }
}

