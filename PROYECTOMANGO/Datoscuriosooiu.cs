using PROYECTOMANGO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTOBETA001
{
        public partial class Datoscuriosooi : Form
    {
        int indice = 0;

        string[] datos = new string[]
        {
            "El mango es una drupa: tiene pulpa, piel y una semilla grande.",
            "El mango se cultiva desde hace más de 5,000 años en India.",
            "La forma del mango inspiró el patrón paisley en la India.",
            "Regalar mangos en India es un gesto de amistad.",
            "Existe una leyenda que dice que Buda meditaba bajo un mango.",
            "El mango está relacionado con el anacardo y el pistacho.",
            "Partes del mango se han usado en remedios tradicionales.",
            "El nombre científico del mango es Mangifera indica.",
            "Una porción de mango aporta mucha vitamina C.",
            "El mango es una de las frutas más consumidas del mundo."
        };
        public Datoscuriosooi()
        {
            InitializeComponent();
            MostrarDato();
        }
        void MostrarDato()
        {
            txtTexto.Text = datos[indice];
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (indice < datos.Length - 1)
            {
                indice++;
                MostrarDato();
            }
            else
            {
                FormPreguntas quiz = new FormPreguntas();
                quiz.Show();
                this.Hide();
            }
        }

        private void bntAnterio_Click(object sender, EventArgs e)
        {
            if (indice > 0)
            {
                indice--;
                MostrarDato();
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Interfazprinc frme2 = new Interfazprinc(); 
            frme2.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.mango.org/");
        }
    }
}
