using PROYECTOMANGO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PROYECTOBETA001
{
    public partial class Interfazprinc : Form


    {
        public Interfazprinc()
        {
            InitializeComponent();

            // Suscribirse al estado global para mostrar la vida de la mascota
            GameState.Instance.StateChanged += GameState_StateChanged;
            this.FormClosed += Interfazprinc_FormClosed;

            UpdateVidaUI();
        }

        private void Interfazprinc_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Desuscribir para evitar fugas de memoria
            GameState.Instance.StateChanged -= GameState_StateChanged;
        }

        // Handler invocado desde GameState (puede venir desde un hilo no-UI)
        private void GameState_StateChanged(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)UpdateVidaUI);
            }
            else
            {
                UpdateVidaUI();
            }
        }

        // Actualiza la barra y la etiqueta con la vida actual
        private void UpdateVidaUI()
        {
            try
            {
                var vida = GameState.Instance.Vida;
                if (progressVidaMascota != null)
                {
                    progressVidaMascota.Value = Math.Max(0, Math.Min(100, vida));
                }

                if (lblVidaMascota != null)
                {
                    lblVidaMascota.Text = "Vida de tu Mangito: " + vida;
                }
            }
            catch
            {
                // Ignorar errores durante diseño o si los controles no existen aún
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            ProcProductivo f23s = new ProcProductivo();
            f23s.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mangomayinterf hg46 = new mangomayinterf();
            hg46.Show();
            this.Hide();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            Datoscuriosooi frme2f = new Datoscuriosooi();
            frme2f.Show();
            this.Hide();

           
        }

        private void mascotMango_Click(object sender, EventArgs e)
        {
            Mangomacomaykel VENT10 = new Mangomacomaykel();
            VENT10.Show();
            this.Hide();
        }

        private void transpvent_Click(object sender, EventArgs e)
        {

        }

        private void fotousoculinario1_Click(object sender, EventArgs e)
        {
            mangomayinterf hg46 = new mangomayinterf();
            hg46.Show();
            this.Hide();
        }

        private void titelprdu2_Click(object sender, EventArgs e)
        {
            mangomayinterf hg46 = new mangomayinterf();
            hg46.Show();
            this.Hide();
        }

        private void fotodatocuriso1_Click(object sender, EventArgs e)
        {
            Datoscuriosooi frme2f = new Datoscuriosooi();
            frme2f.Show();
            this.Hide();
        }

        private void titelprdu_Click(object sender, EventArgs e)
        {
            Datoscuriosooi frme2f = new Datoscuriosooi();
            frme2f.Show();
            this.Hide();
        }

        private void fotoprocesoproductivo_Click(object sender, EventArgs e)
        {
            ProcProductivo f23s = new ProcProductivo();
            f23s.Show();
            this.Hide();
        }

        private void titelprdu3_Click(object sender, EventArgs e)
        {
            ProcProductivo f23s = new ProcProductivo();
            f23s.Show();
            this.Hide();
        }

        private void fotocuidatumango1_Click(object sender, EventArgs e)
        {
            Mangomacomaykel VENT10 = new Mangomacomaykel();
            VENT10.Show();
            this.Hide();
        }

        private void titelprdu4_Click(object sender, EventArgs e)
        {
            Mangomacomaykel VENT10 = new Mangomacomaykel();
            VENT10.Show();
            this.Hide();
        }
    }
}
