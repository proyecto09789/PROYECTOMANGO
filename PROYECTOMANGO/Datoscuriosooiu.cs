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
         "Botánicamente, el mango es una drupa. Tiene una piel fina, pulpa carnosa y un hueso grande en el centro.",

         "El mango es una fruta tropical rica en vitamina A y C, esenciales para la vista y el sistema inmune.",

         "Existen más de 100 variedades de mango en el mundo, con distintos colores, sabores y tamaños.",

         "El mango ayuda a la digestión y aporta antioxidantes beneficiosos para la salud."
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


    }
}
