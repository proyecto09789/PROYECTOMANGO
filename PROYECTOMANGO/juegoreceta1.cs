using PROYECTOBETA001;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PROYECTOMANGO
{
    public partial class juegoreceta1 : Form
    {
        private int pasoActual = 0;
        private int puntos = 0;
        private int tiempoTranscurrido = 0;
        private int velocidadLicuadora = 0;
        private int temperaturaHorno = 0;
        private Random random = new Random();

        private List<IngredienteControl> ingredientesArrastrar = new List<IngredienteControl>();
        private int ingredientesAgregados = 0;
        private int ingredientesRequeridos = 6;

        private Dictionary<string, string> imagenesIngredientes = new Dictionary<string, string>
        {
            {"Mango", "🥭"},
            {"Vinagre", "🍶"},
            {"Miel", "🍯"},
            {"Mostaza", "🟨"},
            {"Ajo", "🧄"},
            {"Jengibre", "🫚"},
            {"Jamón", "🍖"}
        };

        public juegoreceta1()
        {
            InitializeComponent();
            ConfigurarEventos();
            IniciarJuego();
        }

        private void ConfigurarEventos()
        {
            picLicuadora.AllowDrop = true;
            picLicuadora.DragEnter += PicLicuadora_DragEnter;
            picLicuadora.DragDrop += PicLicuadora_DragDrop;
            picLicuadora.Paint += PicLicuadora_Paint;
            picHorno.Paint += PicHorno_Paint;
        }

        private void IniciarJuego()
        {
            pasoActual = 0;
            puntos = 0;
            tiempoTranscurrido = 0;
            ingredientesAgregados = 0;
            velocidadLicuadora = 0;
            temperaturaHorno = 0;
            progressBar.Value = 0;
            MostrarPaso();
        }

        private void MostrarPaso()
        {
            LimpiarPaneles();

            switch (pasoActual)
            {
                case 0:
                    MostrarPantallaInicio();
                    break;
                case 1:
                    MostrarPasoAgregarIngredientes();
                    break;
                case 2:
                    MostrarPasoLicuar();
                    break;
                case 3:
                    MostrarPasoPrepararJamon();
                    break;
                case 4:
                    MostrarPasoGlasear();
                    break;
                case 5:
                    MostrarPasoHornear();
                    break;
                case 6:
                    MostrarPantallaFinal();
                    break;
            }

            progressBar.Value = (pasoActual * 100) / 6;
        }

        private void MostrarPantallaInicio()
        {
            lblPaso.Text = "🎮 ¡Bienvenido al Juego de Cocina! 🎮";
            lblInstrucciones.Text = "Prepararemos un delicioso Glaseado con Mango y Jengibre.\r\nArrastra ingredientes, controla la licuadora y hornea para ganar puntos.";
            btnContinuar.Text = "▶ COMENZAR JUEGO";
            btnContinuar.Visible = true;

            picLicuadora.Visible = false;
            panelIngredientes.Visible = false;
        }

        private void MostrarPasoAgregarIngredientes()
        {
            lblPaso.Text = "Paso 1: Agregar Ingredientes a la Licuadora 🥭";
            lblInstrucciones.Text = "ARRASTRA cada ingrediente a la licuadora. Necesitas agregar:\r\nMango, Vinagre, Miel, Mostaza, Ajo y Jengibre";
            btnContinuar.Visible = false;

            picLicuadora.Visible = true;
            picLicuadora.BackColor = Color.White;
            panelIngredientes.Visible = true;

            CrearIngredientesArrastrables();
            timerJuego.Start();
        }

        private void CrearIngredientesArrastrables()
        {
            panelIngredientes.Controls.Clear();
            ingredientesArrastrar.Clear();

            string[] nombres = { "Mango", "Vinagre", "Miel", "Mostaza", "Ajo", "Jengibre" };
            int y = 10;

            foreach (string nombre in nombres)
            {
                var ing = new IngredienteControl(nombre, imagenesIngredientes[nombre])
                {
                    Location = new Point(10, y)
                };
                panelIngredientes.Controls.Add(ing);
                ingredientesArrastrar.Add(ing);
                y += 65;
            }
        }

        private void PicLicuadora_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(string)))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void PicLicuadora_DragDrop(object sender, DragEventArgs e)
        {
            if (pasoActual != 1) return;

            string ingrediente = (string)e.Data.GetData(typeof(string));
            ingredientesAgregados++;

            int colorValue = 255 - (ingredientesAgregados * 30);
            picLicuadora.BackColor = Color.FromArgb(255, Math.Max(colorValue, 150), 100);
            picLicuadora.Invalidate();

            puntos += 20;
            ActualizarPuntos();

            var ctrl = ingredientesArrastrar.FirstOrDefault(i => i.Nombre == ingrediente);
            if (ctrl != null)
            {
                panelIngredientes.Controls.Remove(ctrl);
            }

            if (ingredientesAgregados >= ingredientesRequeridos)
            {
                timerJuego.Stop();
                MessageBox.Show($"¡Excelente! Todos los ingredientes agregados.\n+50 puntos de bonus\nTiempo: {tiempoTranscurrido}s",
                              "¡Bien hecho! 🎉", MessageBoxButtons.OK, MessageBoxIcon.Information);
                puntos += 50;
                ActualizarPuntos();
                btnContinuar.Visible = true;
                btnContinuar.Text = "▶ CONTINUAR";
            }
        }

        private void MostrarPasoLicuar()
        {
            lblPaso.Text = "Paso 2: Licuar hasta Mezcla Homogénea 🌀";
            lblInstrucciones.Text = "USA LAS FLECHAS ↑↓ del teclado para controlar la velocidad de la licuadora.\r\nMantén la velocidad entre 50-80 durante 5 segundos.";

            panelIngredientes.Visible = false;
            btnContinuar.Visible = false;
            velocidadLicuadora = 0;
            tiempoTranscurrido = 0;

            var panelControl = new Panel
            {
                Location = new Point(690, 180),
                Size = new Size(250, 220),
                BackColor = Color.FromArgb(240, 240, 220),
                BorderStyle = BorderStyle.FixedSingle
            };
            panelJuego.Controls.Add(panelControl);

            var trackBar = new TrackBar
            {
                Location = new Point(20, 20),
                Size = new Size(50, 180),
                Orientation = Orientation.Vertical,
                Minimum = 0,
                Maximum = 100,
                TickFrequency = 10,
                Value = 0
            };
            trackBar.ValueChanged += (s, e) => { velocidadLicuadora = trackBar.Value; };
            panelControl.Controls.Add(trackBar);

            var lblVelocidad = new Label
            {
                Location = new Point(80, 60),
                Size = new Size(150, 100),
                Font = new Font("Arial", 11, FontStyle.Bold),
                Text = "Velocidad:\n0%\n\nObjetivo:\n50-80%",
                BackColor = Color.Transparent
            };
            panelControl.Controls.Add(lblVelocidad);

            timerAnimacion.Start();
            timerJuego.Start();

            this.KeyPreview = true;
            this.KeyDown += (s, e) =>
            {
                if (pasoActual == 2)
                {
                    if (e.KeyCode == Keys.Up && trackBar.Value < 100)
                        trackBar.Value += 5;
                    else if (e.KeyCode == Keys.Down && trackBar.Value > 0)
                        trackBar.Value -= 5;

                    lblVelocidad.Text = $"Velocidad:\n{velocidadLicuadora}%\n\nObjetivo:\n50-80%";
                }
            };
        }

        private void MostrarPasoPrepararJamon()
        {

            picLicuadora.Visible = false;
            picHorno.Visible = false;
            panelRecipiente.Visible = false;

            lblPaso.Text = "Paso 3: Preparar el Jamón 🍖";
            lblInstrucciones.Text = "HAZ CLIC en el jamón repetidamente para cocinarlo.\r\n¡Necesitas 30 clics para cocinarlo perfectamente!";

            picLicuadora.Visible = false;
            btnContinuar.Visible = false;
            tiempoTranscurrido = 0;

            var panelJamon = new Panel
            {
                Location = new Point(350, 140),
                Size = new Size(260, 260),
                BackColor = Color.Transparent,
                BorderStyle = BorderStyle.None
            };
            panelJuego.Controls.Add(panelJamon);

            var picJamon = new PictureBox
            {
                Location = new Point(10, 10),
                Size = new Size(240, 200),
                BackColor = Color.Pink,
                BorderStyle = BorderStyle.Fixed3D,
                Cursor = Cursors.Hand,
                Tag = 0
            };
            panelJamon.Controls.Add(picJamon);

            var lblClics = new Label
            {
                Location = new Point(10, 220),
                Size = new Size(240, 30),
                Font = new Font("Arial", 12, FontStyle.Bold),
                Text = "Clics: 0 / 30",
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.Transparent
            };
            panelJamon.Controls.Add(lblClics);

            picJamon.Click += (s, e) =>
            {
                int clics = (int)picJamon.Tag + 1;
                picJamon.Tag = clics;
                lblClics.Text = $"Clics: {clics} / 30";

                int colorR = Math.Max(255 - (clics * 5), 139);
                int colorG = Math.Max(192 - (clics * 4), 69);
                int colorB = Math.Max(203 - (clics * 5), 19);
                picJamon.BackColor = Color.FromArgb(colorR, colorG, colorB);

                puntos += 2;
                ActualizarPuntos();

                if (clics >= 30)
                {
                    MessageBox.Show("¡Jamón perfectamente cocinado!\n+80 puntos de bonus",
                                  "¡Excelente! 👨‍🍳", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    puntos += 80;
                    ActualizarPuntos();
                    btnContinuar.Visible = true;
                    btnContinuar.Text = "▶ CONTINUAR";
                }
            };

            timerJuego.Start();
        }

        private void MostrarPasoGlasear()
        {
            lblPaso.Text = "Paso 4: Aplicar el Glaseado 🎨";
            lblInstrucciones.Text = "MUEVE EL MOUSE sobre el jamón para aplicar el glaseado.\r\nCubre toda la superficie pintando sobre ella.";

            btnContinuar.Visible = false;
            tiempoTranscurrido = 0;

            var panelGlasear = new Panel
            {
                Location = new Point(310, 120),
                Size = new Size(360, 320),
                BackColor = Color.Transparent,
                BorderStyle = BorderStyle.None
            };
            panelJuego.Controls.Add(panelGlasear);

            var picJamonGlasear = new PictureBox
            {
                Location = new Point(10, 10),
                Size = new Size(340, 280),
                BackColor = Color.SaddleBrown,
                BorderStyle = BorderStyle.Fixed3D
            };

            var bitmap = new Bitmap(340, 280);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.SaddleBrown);
            }
            picJamonGlasear.Image = bitmap;
            panelGlasear.Controls.Add(picJamonGlasear);

            int pixelesGlaseados = 0;
            int pixelesRequeridos = 200;

            var lblProgreso = new Label
            {
                Location = new Point(10, 295),
                Size = new Size(340, 20),
                Font = new Font("Arial", 10, FontStyle.Bold),
                Text = $"Progreso: 0%",
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.Transparent
            };
            panelGlasear.Controls.Add(lblProgreso);

            bool pintando = false;

            picJamonGlasear.MouseDown += (s, e) => { pintando = true; };
            picJamonGlasear.MouseUp += (s, e) => { pintando = false; };
            picJamonGlasear.MouseLeave += (s, e) => { pintando = false; };

            picJamonGlasear.MouseMove += (s, e) =>
            {
                if (pintando && pixelesGlaseados < pixelesRequeridos)
                {
                    using (Graphics g = Graphics.FromImage(picJamonGlasear.Image))
                    {
                        Brush brush = new SolidBrush(Color.FromArgb(255, 165, 0));
                        g.FillEllipse(brush, e.X - 10, e.Y - 10, 20, 20);
                    }
                    picJamonGlasear.Invalidate();

                    pixelesGlaseados += 2;
                    int progreso = (pixelesGlaseados * 100) / pixelesRequeridos;
                    lblProgreso.Text = $"Progreso: {progreso}%";

                    if (pixelesGlaseados >= pixelesRequeridos)
                    {
                        MessageBox.Show("¡Glaseado aplicado perfectamente!\n+100 puntos",
                                      "¡Magnífico! ✨", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        puntos += 100;
                        ActualizarPuntos();
                        btnContinuar.Visible = true;
                        btnContinuar.Text = "▶ CONTINUAR";
                    }
                }
            };

            timerJuego.Start();
        }

        private void MostrarPasoHornear()
        {

            panelRecipiente.Visible = true;   // lo usamos
            picLicuadora.Visible = false;     // ocultar licuadora
            picHorno.Visible = true;          // mostrar horno
            panelIngredientes.Visible = false;


            lblPaso.Text = "Paso 5: Hornear y Caramelizar 🔥";
            lblInstrucciones.Text = "AJUSTA LA TEMPERATURA del horno usando las teclas + y -\r\nMantén la temperatura en 180°C durante 8 segundos.";

            picLicuadora.Visible = false;
            picHorno.Visible = true;
            btnContinuar.Visible = false;
            temperaturaHorno = 100;
            tiempoTranscurrido = 0;
            int tiempoEnTemperatura = 0;

            var panelTemp = new Panel
            {
                Location = new Point(690, 180),
                Size = new Size(240, 240),
                BackColor = Color.FromArgb(240, 240, 220),
                BorderStyle = BorderStyle.FixedSingle
            };
            panelJuego.Controls.Add(panelTemp);

            var lblTemp = new Label
            {
                Location = new Point(20, 20),
                Size = new Size(200, 80),
                Font = new Font("Arial", 14, FontStyle.Bold),
                Text = $"🌡️ Temperatura:\n{temperaturaHorno}°C\n\nObjetivo: 180°C",
                BackColor = Color.Transparent
            };
            panelTemp.Controls.Add(lblTemp);

            var lblTiempoTemp = new Label
            {
                Location = new Point(20, 110),
                Size = new Size(200, 50),
                Font = new Font("Arial", 11),
                Text = "Tiempo en 180°C:\n0 / 8 seg",
                BackColor = Color.Transparent
            };
            panelTemp.Controls.Add(lblTiempoTemp);

            var lblInstrucTemp = new Label
            {
                Location = new Point(20, 170),
                Size = new Size(200, 50),
                Font = new Font("Arial", 9),
                Text = "Usa las teclas:\n[+] Subir temp\n[-] Bajar temp",
                BackColor = Color.Transparent,
                ForeColor = Color.DarkBlue
            };
            panelTemp.Controls.Add(lblInstrucTemp);

            this.KeyPreview = true;
            KeyEventHandler keyHandler = null;
            keyHandler = (s, e) =>
            {
                if (pasoActual == 5)
                {
                    if (e.KeyCode == Keys.Add || e.KeyCode == Keys.Oemplus)
                        temperaturaHorno = Math.Min(temperaturaHorno + 5, 250);
                    else if (e.KeyCode == Keys.Subtract || e.KeyCode == Keys.OemMinus)
                        temperaturaHorno = Math.Max(temperaturaHorno - 5, 50);

                    lblTemp.Text = $"🌡️ Temperatura:\n{temperaturaHorno}°C\n\nObjetivo: 180°C";

                    if (temperaturaHorno >= 175 && temperaturaHorno <= 185)
                        lblTemp.ForeColor = Color.Green;
                    else
                        lblTemp.ForeColor = Color.Red;

                    picHorno.Invalidate();
                }
            };
            this.KeyDown += keyHandler;

            Timer timerTemp = new Timer { Interval = 1000 };
            timerTemp.Tick += (s, e) =>
            {
                if (temperaturaHorno >= 175 && temperaturaHorno <= 185)
                {
                    tiempoEnTemperatura++;
                    lblTiempoTemp.Text = $"Tiempo en 180°C:\n{tiempoEnTemperatura} / 8 seg";
                    lblTiempoTemp.ForeColor = Color.Green;

                    if (tiempoEnTemperatura >= 8)
                    {
                        timerTemp.Stop();
                        timerJuego.Stop();
                        this.KeyDown -= keyHandler;

                        MessageBox.Show($"¡Perfecto! Glaseado caramelizado idealmente.\n+150 puntos\nTiempo total: {tiempoTranscurrido}s",
                                      "¡Obra maestra! 👨‍🍳✨", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        puntos += 150;
                        ActualizarPuntos();
                        btnContinuar.Visible = true;
                        btnContinuar.Text = "▶ FINALIZAR";
                    }
                }
                else
                {
                    tiempoEnTemperatura = 0;
                    lblTiempoTemp.ForeColor = Color.Red;
                }
            };
            timerTemp.Start();

            timerAnimacion.Start();
            timerJuego.Start();
        }

        private void MostrarPantallaFinal()

        {
            panelRecipiente.Visible = false;
            picLicuadora.Visible = false;
            picHorno.Visible = false;
            panelIngredientes.Visible = false;

            timerJuego.Stop();
            timerAnimacion.Stop();

            lblPaso.Text = "🏆 ¡FELICIDADES! 🏆";
            lblInstrucciones.Text = $"Has completado el Glaseado con Mango y Jengibre\r\nPuntuación Final: {puntos} puntos - Tiempo Total: {tiempoTranscurrido}s";

            picLicuadora.Visible = false;
            picHorno.Visible = false;
            panelIngredientes.Visible = false;
            btnContinuar.Visible = true;
            btnContinuar.Text = "🔄 JUGAR DE NUEVO";

            string calificacion = puntos >= 500 ? "⭐⭐⭐ Chef Maestro" :
                                 puntos >= 400 ? "⭐⭐ Chef Experto" :
                                 puntos >= 300 ? "⭐ Chef en Entrenamiento" : "Principiante";

            var panelFinal = new Panel
            {
                Location = new Point(270, 200),
                Size = new Size(420, 150),
                BackColor = Color.Gold,
                BorderStyle = BorderStyle.FixedSingle
            };
            panelJuego.Controls.Add(panelFinal);

            var lblCalificacion = new Label
            {
                Location = new Point(10, 40),
                Size = new Size(400, 70),
                Font = new Font("Arial", 18, FontStyle.Bold),
                Text = calificacion,
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.Transparent,
                ForeColor = Color.DarkRed
            };
            panelFinal.Controls.Add(lblCalificacion);
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (pasoActual == 6)
            {
                IniciarJuego();
            }
            else
            {
                pasoActual++;
                MostrarPaso();
            }
        }

        private void timerAnimacion_Tick(object sender, EventArgs e)
        {
            if (pasoActual == 2 && velocidadLicuadora > 0)
            {
                picLicuadora.Invalidate();
            }
            else if (pasoActual == 5)
            {
                picHorno.Invalidate();
            }
        }

        private void timerJuego_Tick(object sender, EventArgs e)
        {
            tiempoTranscurrido++;
            lblTiempo.Text = $"⏱️ Tiempo: {tiempoTranscurrido}s";

            if (pasoActual == 2)
            {
                if (velocidadLicuadora >= 50 && velocidadLicuadora <= 80)
                {
                    puntos += 5;
                    ActualizarPuntos();

                    if (tiempoTranscurrido >= 5)
                    {
                        timerJuego.Stop();
                        timerAnimacion.Stop();
                        MessageBox.Show("¡Mezcla homogénea perfecta!\n+100 puntos de bonus",
                                      "¡Excelente! 🌟", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        puntos += 100;
                        ActualizarPuntos();
                        btnContinuar.Visible = true;
                        btnContinuar.Text = "▶ CONTINUAR";
                    }
                }
            }
        }

        private void PicLicuadora_Paint(object sender, PaintEventArgs e)
        {
            if (pasoActual == 2 && velocidadLicuadora > 0)
            {
                int numLineas = velocidadLicuadora / 10;
                using (Pen pen = new Pen(Color.White, 3))
                {
                    for (int i = 0; i < numLineas; i++)
                    {
                        int angle = (Environment.TickCount / (100 - velocidadLicuadora)) % 360 + (i * 360 / numLineas);
                        double rad = angle * Math.PI / 180;
                        int x1 = picLicuadora.Width / 2;
                        int y1 = picLicuadora.Height / 2;
                        int x2 = x1 + (int)(Math.Cos(rad) * 80);
                        int y2 = y1 + (int)(Math.Sin(rad) * 80);
                        e.Graphics.DrawLine(pen, x1, y1, x2, y2);
                    }
                }
            }
        }

        private void PicHorno_Paint(object sender, PaintEventArgs e)
        {
            if (pasoActual == 5)
            {
                int numLlamas = temperaturaHorno / 30;
                for (int i = 0; i < numLlamas; i++)
                {
                    int x = 50 + i * 40;
                    int altura = random.Next(20, 50);
                    Color colorLlama = temperaturaHorno > 180 ? Color.OrangeRed : Color.Orange;
                    using (Brush brush = new SolidBrush(colorLlama))
                    {
                        Point[] puntos = {
                            new Point(x, picHorno.Height - 20),
                            new Point(x - 10, picHorno.Height - 20 - altura),
                            new Point(x, picHorno.Height - 20 - altura - 10),
                            new Point(x + 10, picHorno.Height - 20 - altura)
                        };
                        e.Graphics.FillPolygon(brush, puntos);
                    }
                }

                using (Brush brush = new SolidBrush(Color.FromArgb(139, 69, 19)))
                {
                    e.Graphics.FillEllipse(brush, 120, 80, 200, 120);
                }
            }
        }

        private void ActualizarPuntos()
        {
            lblPuntos.Text = $"⭐ Puntos: {puntos}";
        }

        private void LimpiarPaneles()
        {
            timerAnimacion.Stop();
            timerJuego.Stop();
            tiempoTranscurrido = 0;

            List<Control> controlesARemover = new List<Control>();
            foreach (Control ctrl in panelJuego.Controls)
            {
                if (ctrl != lblInstrucciones && ctrl != lblPaso &&
                    ctrl != panelRecipiente && ctrl != panelIngredientes &&
                    ctrl != panelControles && ctrl != panelInfo)
                {
                    controlesARemover.Add(ctrl);
                }
            }
            foreach (Control ctrl in controlesARemover)
            {
                panelJuego.Controls.Remove(ctrl);
                ctrl.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mangomayinterf ventm2 = new mangomayinterf();   
            ventm2.Show();            
            this.Hide();
        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    public class IngredienteControl : Panel
    {
        public string Nombre { get; set; }
        private Label lblEmoji;
        private Label lblNombre;

        public IngredienteControl(string nombre, string emoji)
        {
            this.Nombre = nombre;
            this.Size = new Size(280, 55);
            this.BackColor = Color.FromArgb(255, 255, 224);
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Cursor = Cursors.Hand;

            lblEmoji = new Label
            {
                Text = emoji,
                Font = new Font("Segoe UI Emoji", 24),
                Location = new Point(10, 8),
                Size = new Size(50, 40),
                BackColor = Color.Transparent
            };

            lblNombre = new Label
            {
                Text = nombre,
                Font = new Font("Arial", 11, FontStyle.Bold),
                Location = new Point(70, 15),
                Size = new Size(200, 25),
                BackColor = Color.Transparent
            };

            this.Controls.Add(lblEmoji);
            this.Controls.Add(lblNombre);

            this.MouseDown += IngredienteControl_MouseDown;
        }

        private void IngredienteControl_MouseDown(object sender, MouseEventArgs e)
        {
            this.DoDragDrop(this.Nombre, DragDropEffects.Copy);
        }
    }
}