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

 /* No vayan a tocar ni mover nada, por que despues lo pueden dañar y me costo mucho en hacerlo */

namespace PROYECTOMANGO
{
    public partial class Mangomacomaykel : Form
    {
        public Mangomacomaykel()
        {
            InitializeComponent();
            // Suscribirse a cambios de estado global
            GameState.Instance.StateChanged += GameState_StateChanged;

            UpdateUI();
        }

        private void Mangomacomaykel_Load(object sender, EventArgs e)
        {
        }

        private async void btnRegar01_Click(object sender, EventArgs e)
        {
            btnAlimentar01.Enabled = false;
            manf2.Visible = true;
            // Aumenta 'agua' (energia) y experiencia vía GameState
            GameState.Instance.AddEnergia(10);
            GameState.Instance.AddExperiencia(5);
            UpdateUI();
            await Task.Delay(2000);
            btnAlimentar01.Enabled = true;
            manf2.Visible = false;
        }

        private async void btnAlimentar01_Click(object sender, EventArgs e)
        {
            manf1.Visible = true;
            btnRegar01.Enabled = false;
            // Aumenta comida y vida y experiencia vía GameState
            GameState.Instance.AddComida(10);
            GameState.Instance.AddVida(10);
            GameState.Instance.AddExperiencia(5);
            UpdateUI();

            await Task.Delay(9000);
            manf1.Visible = false;
            btnRegar01.Enabled = true;
        }

        private void lblNivel_Click(object sender, EventArgs e)
        {
        }

        // Evento llamado desde GameState (puede venir desde hilo de threadpool)
        private void GameState_StateChanged(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)(() => UpdateUI()));
            }
            else
            {
                UpdateUI();
            }
        }

        private async void UpdateUI()
        {
            // Actualizar barras y labels usando los nombres reales del diseñador leyendo desde GameState
            try
            {
                var gs = GameState.Instance;

                if (progresspbVida != null)
                {
                    progresspbVida.Value = Math.Max(0, Math.Min(100, gs.Vida));
                }
                if (lblVidaValor != null)
                {
                    lblVidaValor.Text = gs.Vida.ToString();
                }

                if (pbComida != null)
                {
                    pbComida.Value = Math.Max(0, Math.Min(100, gs.Comida));
                }
                if (lblComidaValor != null)
                {
                    lblComidaValor.Text = gs.Comida.ToString();
                }

                if (pbAgua != null)
                {
                    pbAgua.Value = Math.Max(0, Math.Min(100, gs.Energia));
                }
                if (lblEnergiaValor != null)
                {
                    lblEnergiaValor.Text = gs.Energia.ToString();
                }

                if (lblexpr != null)
                {
                    lblexpr.Text = "Experiencia " + gs.Experiencia + "/100";
                }

                if (lblNivel != null)
                {
                    lblNivel.Text = "Nivel: " + gs.Nivel.ToString();
                }

                // Etapa 2
                if (panelmaymas1 != null && gs.Experiencia >= 10)
                {
                    labdefelicitar.Text = "¡Felicidades! Tu planta de mango va a crecer a la Etapa 2 a continuación";
                    btnAlimentar01.Enabled = false;
                    btnRegar01.Enabled = false;

                    await Task.Delay(11500);
                    etapa2manf1.Visible = true;

                    panelmaymas1.Visible = false;
                    paneletapacrecimiento2.Visible = true;

                    await Task.Delay(5500);

                    etapa2manf1.Visible = false;
                    etapa2manf0.Visible = true;
                }

                // Etapa 3
                if (paneletapacrecimiento2 != null && gs.Experiencia >= 20)
                {
                    btnAlimentar02.Enabled = false;
                    btnRegar02.Enabled = false;

                    await Task.Delay(11500);
                    paneletapacrecimiento2.Location = new Point(1000, 1150);
                    Plantitacreceetapa3.Visible = true;

                    paneletapacrecimiento2.Visible = false;
                    paneletapacrecimiento3.Visible = true;
                    regaretapa2.Visible = true;

                    await Task.Delay(5500);
                    Plantitacreceetapa3.Visible = false;
                    regaretapa2.Visible = false;

                    await Task.Delay(300);
                    plantitacreceetapa3p0.Visible = true;
                }
            }
            catch
            {
                // ignorar errores de UI durante diseño
            }
        }

        private async void btnRegar02_Click(object sender, EventArgs e)
        {
            btnAlimentar02.Enabled = false;
            regaretapa2.Visible = true;
            // Aumenta 'agua' (energia) y experiencia
            GameState.Instance.AddEnergia(10);
            GameState.Instance.AddExperiencia(5);
            UpdateUI();
            await Task.Delay(7000);
            btnAlimentar02.Enabled = true;
            regaretapa2.Visible = false;
        }

        private async void btnAlimentar02_Click(object sender, EventArgs e)
        {
            etapa2nutri2.Visible = true;
            btnRegar02.Enabled = false;
            etapa2manf0.Visible = false;
            etapa2manf1.Visible = false;
            // Aumenta comida y experiencia
            GameState.Instance.AddComida(10);
            GameState.Instance.AddVida(10);
            GameState.Instance.AddExperiencia(5);
            UpdateUI();

            await Task.Delay(11000);
            etapa2nutri2.Visible = false;

            etapa2manf0.Visible = true;

            btnRegar02.Enabled = true;
            etapa2manf1.Visible = true;
        }

        private void etapa2nutri2_Click(object sender, EventArgs e)
        {
        }

        private void manf1_Click(object sender, EventArgs e)
        {
        }

        private void paneletapacrecimiento3_Paint(object sender, PaintEventArgs e)
        {
        }

        private async void btnnMenu12_Click(object sender, EventArgs e)
        {
            Interfazprinc pag10 = new Interfazprinc();
            pag10.Show();
            this.Hide();

            await Task.Delay(2000);
        }
    }
}
