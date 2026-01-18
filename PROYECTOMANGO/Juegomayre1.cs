using PROYECTOBETA001;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PROYECTOMANGO
{
    public partial class Juegomayre1 : Form

    {
     
           
        

        private int puntuacion = 0;
        private int preguntaActual = 0;
        private int Repuestacorrecta = 0;

        public Juegomayre1()
        {
            InitializeComponent();
           
           
        }

        private void Juegomayre1_Load(object sender, EventArgs e)


        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                panelmay1.Dock = DockStyle.Fill;
            }
           

            panelmay1.Visible = true;
            panelmay2.Visible = false;
            panelmay3.Visible = false;
            panelmay4.Visible = false;
            panelmay5.Visible = false;
            panelmay9.Visible = false;
            lblnumpre.Text = $" {preguntaActual + 1}";
        }

        private async void btnopm2_Click(object sender, EventArgs e)

        {
            /*Esto lo pongo para desactivar el boton por 3 segundos si quieres hacer lo mismo en otro boton solo copia y pega este codigo*/
            btnopm2.Enabled = false;
            
     

            labelcorrect2.Text = "Incorrecto! 🥭";
            labelcorrect2.ForeColor = Color.Red;

            preguntaActual++;
       

            await Task.Delay(1500);   // Espera 2 segundos (1500 ms)
            labelcorrect2.Text = "";

            // Habilita el botón nuevamente después de la espera
            btnopm2.Enabled = true;

            panelmay2.Location = new Point(38, 98);
            panelmay2.Visible = true;    // Vuelve a mostrar el panel
            lblnumpre.Text = $"{preguntaActual + 1}";


        }

        private async void btnopm1_Click(object sender, EventArgs e)
        {
            btnopm1.Enabled = false;

            puntuacion += 20;
            labelcorrect2.Text = "¡Correcto! 🥭";
            labelcorrect2.ForeColor = Color.Green;

            labelpuntuación.Text = $"Puntuación: {puntuacion}";
            preguntaActual++;

            Repuestacorrecta += 1;

            await Task.Delay(1500);   // Espera 2 segundos (1500 ms)
            labelcorrect2.Text = "";

            btnopm1.Enabled = true;

            panelmay2.Location = new Point(38, 98);
            panelmay2.Visible = true;    // Vuelve a mostrar el panel
            lblnumpre.Text = $"{preguntaActual + 1}";




        }

        private async void btnopm6_Click(object sender, EventArgs e)
        {
            btnopm6.Enabled = false;
            puntuacion += 20;
            labelcorrect2.Text = "¡Correcto! 🥭";
            labelcorrect2.ForeColor = Color.Green;

            labelpuntuación.Text = $"Puntuación: {puntuacion}";
            preguntaActual++;

            Repuestacorrecta += 1;

            await Task.Delay(1500);   // Espera 2 segundos (1500 ms)
            labelcorrect2.Text = "";
            btnopm6.Enabled = true;
            panelmay2.Visible = false;    // Oculta el panel
            panelmay3.Location = new Point(38, 98);
            panelmay3.Visible = true;    // Vuelve a mostrar el panel
            lblnumpre.Text = $"{preguntaActual + 1}";
        }

        private async void btnopm10_Click(object sender, EventArgs e)
        {
            btnopm10.Enabled = false;
            puntuacion += 20;
            labelcorrect2.Text = "¡Correcto! 🥭";
            labelcorrect2.ForeColor = Color.Green;

            labelpuntuación.Text = $"Puntuación: {puntuacion}";
            preguntaActual++;

            Repuestacorrecta += 1;

            await Task.Delay(1500);   // Espera 2 segundos (1500 ms)
            labelcorrect2.Text = "";
            btnopm10.Enabled = true;
            panelmay3.Visible = false;    // Oculta el panel
            panelmay4.Location = new Point(38, 98);
            panelmay4.Visible = true;    // Oculta el panel
            lblnumpre.Text = $"{preguntaActual + 1}";

        }

        private async void btnopm17_Click(object sender, EventArgs e)
        {
            btnopm17.Enabled = false;
            puntuacion += 20;
            labelcorrect2.Text = "¡Correcto! 🥭";
            labelcorrect2.ForeColor = Color.Green;

            labelpuntuación.Text = $"Puntuación: {puntuacion}";
            preguntaActual++;

            Repuestacorrecta += 1;

            await Task.Delay(1500);   // Espera 2 segundos (1500 ms)
            labelcorrect2.Text = "";
            btnopm17.Enabled = true;
            panelmay1.Visible = false;    // Oculta el panel
            panelmay3.Visible = false;    // Oculta el panel
            panelmay4.Visible = false;    // Oculta el panel
            panelmay5.Visible = false;    // Vuelve a mostrar el panel
            panelmay9.Visible = true;
            panelmay9.Location = new Point(38, 98);
            lblnumpre.Text = $"{preguntaActual + 1}";

        }

        private async void btnopm14_Click(object sender, EventArgs e)
        {
            btnopm14.Enabled = false;
            puntuacion += 20;
            labelcorrect2.Text = "¡Correcto! 🥭";
            labelcorrect2.ForeColor = Color.Green;

            labelpuntuación.Text = $"Puntuación: {puntuacion}";
            preguntaActual++;

            Repuestacorrecta += 1;

            await Task.Delay(1500);   // Espera 2 segundos (1500 ms)
            labelcorrect2.Text = "";
            btnopm14.Enabled = true;
            panelmay3.Visible = false;    // Oculta el panel
            panelmay4.Visible = false;    // Oculta el panel
            panelmay5.Location = new Point(38, 98);
            panelmay5.Visible = true;    // Vuelve a mostrar el panel
            lblnumpre.Text = $"{preguntaActual + 1}";
        }

        private async void btnopm3_Click(object sender, EventArgs e)
        {
            btnopm3.Enabled = false;
            labelcorrect2.Text = "Incorrecto! 🥭";
            labelcorrect2.ForeColor = Color.Red;

            preguntaActual++;

            await Task.Delay(1500);   // Espera 2 segundos (1500 ms)
            labelcorrect2.Text = "";
            btnopm3.Enabled = true;

            panelmay2.Location = new Point(38, 98);
            panelmay2.Visible = true;    // Vuelve a mostrar el panel
            lblnumpre.Text = $"{preguntaActual + 1}";
        }

        private async void btnopm4_Click(object sender, EventArgs e)
        {
            btnopm4.Enabled = false;
            labelcorrect2.Text = "Incorrecto! 🥭";
            labelcorrect2.ForeColor = Color.Red;

            preguntaActual++;
  

            await Task.Delay(1500);   // Espera 2 segundos (1500 ms)
            labelcorrect2.Text = "";
            btnopm4.Enabled = true;

            panelmay2.Location = new Point(38, 98);
            panelmay2.Visible = true;    // Vuelve a mostrar el panel
            lblnumpre.Text = $"{preguntaActual + 1}";
        }

        private async void btnopm9_Click(object sender, EventArgs e)
        {
            btnopm9.Enabled = false;
            labelcorrect2.Text = "¡Incorrecta! 🥭";
            labelcorrect2.ForeColor = Color.Red;

            preguntaActual++;


            await Task.Delay(1500);   // Espera 2 segundos (1500 ms)
            labelcorrect2.Text = "";
            btnopm9.Enabled = true;
            panelmay3.Visible = false;    // Oculta el panel
            panelmay4.Location = new Point(38, 98);
            panelmay4.Visible = true;    // Oculta el panel
            lblnumpre.Text = $"{preguntaActual + 1}";
        }

        private async void btnopm11_Click(object sender, EventArgs e)
        {
            btnopm11.Enabled = false;
            labelcorrect2.Text = "¡Incorrecta! 🥭";
            labelcorrect2.ForeColor = Color.Red;

            preguntaActual++;


            await Task.Delay(1500);   // Espera 2 segundos (1500 ms)
            labelcorrect2.Text = "";
            btnopm11.Enabled = true;
            panelmay3.Visible = false;    // Oculta el panel
            panelmay4.Location = new Point(38, 98);
            panelmay4.Visible = true;    // Oculta el panel
            lblnumpre.Text = $"{preguntaActual + 1}";
        }

        private async void btnopm12_Click(object sender, EventArgs e)
        {
            btnopm12.Enabled = false;
            labelcorrect2.Text = "¡Incorrecta! 🥭";
            labelcorrect2.ForeColor = Color.Red;

            preguntaActual++;


            await Task.Delay(1500);   // Espera 2 segundos (1500 ms)
            labelcorrect2.Text = "";
            btnopm12.Enabled = true;
            panelmay3.Visible = false;    // Oculta el panel
            panelmay4.Location = new Point(38, 98);
            panelmay4.Visible = true;    // Oculta el panel
            lblnumpre.Text = $"{preguntaActual + 1}";
        }

        private async void btnopm13_Click(object sender, EventArgs e)
        {
            btnopm13.Enabled = false;   
            labelcorrect2.Text = "¡Incorrecta! 🥭";
            labelcorrect2.ForeColor = Color.Red;

            preguntaActual++;


            await Task.Delay(1500);   // Espera 2 segundos (1500 ms)
            labelcorrect2.Text = "";
            btnopm13.Enabled = true;    
            panelmay3.Visible = false;    // Oculta el panel
            panelmay4.Visible = false;    // Oculta el panel
            panelmay5.Location = new Point(38, 98);
            panelmay5.Visible = true;    // Vuelve a mostrar el panel
            lblnumpre.Text = $"{preguntaActual + 1}";
        }

        private async void btnopm15_Click(object sender, EventArgs e)
        {
            btnopm15.Enabled = false;

            labelcorrect2.Text = "¡Incorrecta! 🥭";
            labelcorrect2.ForeColor = Color.Red;

            preguntaActual++;


            await Task.Delay(1500);   // Espera 2 segundos (1500 ms)
            labelcorrect2.Text = "";
            btnopm15.Enabled = true;
            panelmay3.Visible = false;    // Oculta el panel
            panelmay4.Visible = false;    // Oculta el panel
            panelmay5.Location = new Point(38, 98);
            panelmay5.Visible = true;    // Vuelve a mostrar el panel
            lblnumpre.Text = $"{preguntaActual + 1}";
        }

        private async void btnopm16_Click(object sender, EventArgs e)
        {
            btnopm16.Enabled = false;
            labelcorrect2.Text = "¡Incorrecta! 🥭";
            labelcorrect2.ForeColor = Color.Red;

            preguntaActual++;


            await Task.Delay(1500);   // Espera 2 segundos (1500 ms)
            labelcorrect2.Text = "";
            btnopm16.Enabled = true;
            panelmay3.Visible = false;    // Oculta el panel
            panelmay4.Visible = false;    // Oculta el panel
            panelmay5.Location = new Point(38, 98);
            panelmay5.Visible = true;    // Vuelve a mostrar el panel
            lblnumpre.Text = $"{preguntaActual + 1}";
        }

        private async void btnopm18_Click(object sender, EventArgs e)
        {
            btnopm18.Enabled = false;
            labelcorrect2.Text = "¡Incorrecto! 🥭";
            labelcorrect2.ForeColor = Color.Red;

            preguntaActual++;


            await Task.Delay(1500);   // Espera 2 segundos (1500 ms)
            labelcorrect2.Text = "";
            btnopm18.Enabled = true;
            panelmay1.Visible = false;    // Oculta el panel
            panelmay3.Visible = false;    // Oculta el panel
            panelmay4.Visible = false;    // Oculta el panel
            panelmay5.Visible = false;    // Vuelve a mostrar el panel
            panelmay9.Visible = true;
            panelmay9.Location = new Point(38, 98);
            lblnumpre.Text = $"{preguntaActual + 1}";

        }

        private async void btnopm19_Click(object sender, EventArgs e)
        {
            btnopm19.Enabled = false;
            labelcorrect2.Text = "¡Incorrecto! 🥭";
            labelcorrect2.ForeColor = Color.Red;

            preguntaActual++;

            await Task.Delay(1500);   // Espera 2 segundos (1500 ms)
            labelcorrect2.Text = "";
            btnopm19.Enabled = true;
            panelmay1.Visible = false;    // Oculta el panel
            panelmay3.Visible = false;    // Oculta el panel
            panelmay4.Visible = false;    // Oculta el panel
            panelmay5.Visible = false;    // Vuelve a mostrar el panel
            panelmay9.Visible = true;
            panelmay9.Location = new Point(38, 98);
            lblnumpre.Text = $"{preguntaActual + 1}";
        }

        private async void btnopm20_Click(object sender, EventArgs e)
        {
            btnopm20.Enabled = false;
            labelcorrect2.Text = "¡Incorrecto! 🥭";
            labelcorrect2.ForeColor = Color.Red;

            preguntaActual++;
  

            await Task.Delay(1500);   // Espera 2 segundos (1500 ms)
            labelcorrect2.Text = "";
            btnopm20.Enabled = true;
            panelmay1.Visible = false;    // Oculta el panel
            panelmay3.Visible = false;    // Oculta el panel
            panelmay4.Visible = false;    // Oculta el panel
            panelmay5.Visible = false;    // Vuelve a mostrar el panel
            panelmay9.Visible = true;
            panelmay9.Location = new Point(38, 98);
            lblnumpre.Text = $"{preguntaActual + 1}";
        }
        private async void btnopm5_Click(object sender, EventArgs e)
        {
            btnopm5.Enabled = false;
            labelcorrect2.Text = "¡Incorrecto! 🥭";
            labelcorrect2.ForeColor = Color.Red;

            preguntaActual++;

            await Task.Delay(1500);   // Espera 2 segundos (1500 ms)
            labelcorrect2.Text = "";
            btnopm4.Enabled = true;
            panelmay2.Visible = false;    // Oculta el panel
            panelmay3.Location = new Point(38, 98);
            panelmay3.Visible = true;    // Vuelve a mostrar el panel
            lblnumpre.Text = $"{preguntaActual + 1}";
        }

        private async void btnopm7_Click(object sender, EventArgs e)
        {
            btnopm7.Enabled = false;
            labelcorrect2.Text = "¡Incorrecto! 🥭";
            labelcorrect2.ForeColor = Color.Red;

            preguntaActual++;

            await Task.Delay(1500);   // Espera 2 segundos (1500 ms)
            labelcorrect2.Text = "";
            btnopm4.Enabled = true;
            panelmay2.Visible = false;    // Oculta el panel
            panelmay3.Location = new Point(38, 98);
            panelmay3.Visible = true;    // Vuelve a mostrar el panel
            lblnumpre.Text = $"{preguntaActual + 1}";
        }

        private async void btnopm8_Click(object sender, EventArgs e)
        {
            btnopm8.Enabled = false;
            labelcorrect2.Text = "¡Incorrecto! 🥭";
            labelcorrect2.ForeColor = Color.Red;

            preguntaActual++;

            await Task.Delay(1500);   // Espera 2 segundos (1500 ms)
            labelcorrect2.Text = "";
            btnopm4.Enabled = true;
            panelmay2.Visible = false;    // Oculta el panel
            panelmay3.Location = new Point(38, 98);
            panelmay3.Visible = true;    // Vuelve a mostrar el panel
            lblnumpre.Text = $"{preguntaActual + 1}";
        }

       

        private void btnmayReiniciar_Click(object sender, EventArgs e)
        {
            puntuacion = 0;
            preguntaActual = 0;
           panelmay9.Visible = false;
            panelmay1.Location = new Point(38, 98);
            panelmay1.Visible = true;
            labelpuntuación.Text = "Puntuación: 0";
            lblnumpre.Text = "1";


        }

        private void panelmay9_Paint(object sender, PaintEventArgs e)
        {
            lblResultadoFinal1.Text = $" ¡Juego Terminado!\n\nTu puntuación: {puntuacion}/100";

            repuestacorrctmay1.Text = $"{Repuestacorrecta}";

            if (puntuacion >= 80)
                lblNivel.Text = "¡Eres un Experto en Mangos! 🏆";
            else if (puntuacion >= 60)
                lblNivel.Text = "¡Buen Conocimiento! 👍";
            else
                lblNivel.Text = "Sigue aprendiendo sobre mangos 📚";
        }

        private void btnmenujuego_Click(object sender, EventArgs e)
        {
            mangomayinterf ventm2 = new mangomayinterf();
            ventm2.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void JUGARDNUEV0_Click(object sender, EventArgs e)
        {
            puntuacion = 0;
            preguntaActual = 0;
            panelmay9.Visible = false;
            panelmay1.Location = new Point(38, 98);
            panelmay1.Visible = true;
            labelpuntuación.Text = "Puntuación: 0";
            lblnumpre.Text = "1";
        }

        private void REGRESARME23_Click(object sender, EventArgs e)
        {
            mangomayinterf ventm2 = new mangomayinterf();
            ventm2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelmay1.Location = new Point(38, 98);
            panelcomenzar1.Visible = false;

        }
    }
}
