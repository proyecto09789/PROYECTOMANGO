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
        // Estado del personaje
        private int vida = 100;
        private int comida = 100;
        private int energia = 100; // representa 'agua'
        private int experiencia = 0;
        private int nivel = 0;

        // Timer para decrementar barras con el tiempo
        private System.Windows.Forms.Timer decayTimer;
        // Contador de ticks para controlar la velocidad de decremento de vida
        private int decayTick = 0;
        // Disminuir vida cada N segundos (ticks). Incrementar para hacer más lento.
        private int vidaDecayInterval = 5; // cada 5 segundos
        // Intervalos para comida y agua (pueden ajustarse independientemente)
        private int comidaDecayInterval = 4; // cada 5 segundos
        private int energiaDecayInterval = 3; // cada 5 segundos


        public Mangomacomaykel()
        {
            InitializeComponent();
            // Configuración inicial
            // Inicializar timer que decrece las barras con el tiempo
            decayTimer = new System.Windows.Forms.Timer();
            decayTimer.Interval = 1000; // cada segundo
            decayTimer.Tick += DecayTimer_Tick;
            decayTimer.Start();


            UpdateUI();
        }

        private void Mangomacomaykel_Load(object sender, EventArgs e)
        {

            

        }

      
        private async void btnRegar01_Click(object sender, EventArgs e)
        {

            btnAlimentar01.Enabled = false;
            manf2.Visible = true;
            // Aumenta 'agua' (energia) y experiencia
            energia = Math.Min(100, energia + 10);
            experiencia += 5;
            UpdateUI();
            await Task.Delay(2000);
            btnAlimentar01.Enabled = true;

            manf2.Visible = false;
        }

        private async void btnAlimentar01_Click(object sender, EventArgs e)
        {
            manf1.Visible = true;
            btnRegar01.Enabled = false;
            // Aumenta comida y experiencia
            comida = Math.Min(100, comida + 10);
            vida = Math.Min(100,vida + 10);
            experiencia += 5;
            UpdateUI();

            await Task.Delay(9000);
            manf1.Visible = false;
            btnRegar01.Enabled = true;
        }

        private void lblNivel_Click(object sender, EventArgs e)
        {

        }

        private void DecayTimer_Tick(object sender, EventArgs e)
        {
            // Disminuir con el tiempo
            decayTick++;

            // Disminuir vida sólo cada vidaDecayInterval ticks para que no baje tan rápido
            if (decayTick % vidaDecayInterval == 0)
            {
                vida = Math.Max(0, vida - 1);

            }

            // Comida y agua disminuyen según sus intervalos (para no bajar muy rápido)
            if (decayTick % comidaDecayInterval == 0)
            {
                comida = Math.Max(0, comida - 1);
            }
            if (decayTick % energiaDecayInterval == 0)
            {
                energia = Math.Max(0, energia - 1);
            }

            // Ganar algo de experiencia si se mantiene vivo (opcional)
            // experiencia += 0;

            UpdateUI();
        }

        private async void UpdateUI()
        {
            // Actualizar barras y labels usando los nombres reales del diseñador
            try
            {
                if (progresspbVida != null)
                {
                    progresspbVida.Value = Math.Max(0, Math.Min(100, vida));
                }
                if (lblVidaValor != null)
                {
                    lblVidaValor.Text = vida.ToString();
                }

                if (pbComida != null)
                {
                    pbComida.Value = Math.Max(0, Math.Min(100, comida));
                }
                if (lblComidaValor != null)
                {
                    lblComidaValor.Text = comida.ToString();
                }

                if (pbAgua != null)
                {
                    pbAgua.Value = Math.Max(0, Math.Min(100, energia));
                }
                if (lblEnergiaValor != null)
                {
                    lblEnergiaValor.Text = energia.ToString();
                }

                if (lblexpr != null)
                {
                    lblexpr.Text = "Experiencia " + experiencia + "/100".ToString();
                }

                if (lblNivel != null)
                {
                    lblNivel.Text = "Nivel: " + nivel.ToString();
                }
                //Etapa 2
                // Si la experiencia alcanza 10, ocultar el panel de acciones
                if (panelmaymas1 != null && experiencia >= 10)
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
                //Etapa 3
                if (paneletapacrecimiento2 != null && experiencia >= 20)
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
            energia = Math.Min(100, energia + 10);
            experiencia += 5;
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
            comida = Math.Min(100, comida + 10);
            vida = Math.Min(100, vida + 10);
            experiencia += 5;
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
    }
}
