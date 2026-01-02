// ARCHIVO: juegoreceta1.Designer.cs
// Coloca este código en el archivo juegoreceta1.Designer.cs

namespace PROYECTOMANGO
{
    partial class juegoreceta1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerAnimacion = new System.Windows.Forms.Timer(this.components);
            this.timerJuego = new System.Windows.Forms.Timer(this.components);
            this.panelJuego = new System.Windows.Forms.Panel();
            this.lblInstrucciones = new System.Windows.Forms.Label();
            this.lblPaso = new System.Windows.Forms.Label();
            this.panelRecipiente = new System.Windows.Forms.Panel();
            this.picLicuadora = new System.Windows.Forms.PictureBox();
            this.picHorno = new System.Windows.Forms.PictureBox();
            this.panelIngredientes = new System.Windows.Forms.Panel();
            this.panelControles = new System.Windows.Forms.Panel();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.btbmejue = new System.Windows.Forms.Button();
            this.panelJuego.SuspendLayout();
            this.panelRecipiente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLicuadora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHorno)).BeginInit();
            this.panelControles.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerAnimacion
            // 
            this.timerAnimacion.Interval = 50;
            this.timerAnimacion.Tick += new System.EventHandler(this.timerAnimacion_Tick);
            // 
            // timerJuego
            // 
            this.timerJuego.Interval = 1000;
            this.timerJuego.Tick += new System.EventHandler(this.timerJuego_Tick);
            // 
            // panelJuego
            // 
            this.panelJuego.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(205)))));
            this.panelJuego.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelJuego.Controls.Add(this.lblInstrucciones);
            this.panelJuego.Controls.Add(this.lblPaso);
            this.panelJuego.Controls.Add(this.panelRecipiente);
            this.panelJuego.Controls.Add(this.panelIngredientes);
            this.panelJuego.Controls.Add(this.panelControles);
            this.panelJuego.Controls.Add(this.panelInfo);
            this.panelJuego.Location = new System.Drawing.Point(20, 90);
            this.panelJuego.Name = "panelJuego";
            this.panelJuego.Size = new System.Drawing.Size(960, 640);
            this.panelJuego.TabIndex = 1;
            // 
            // lblInstrucciones
            // 
            this.lblInstrucciones.BackColor = System.Drawing.Color.Transparent;
            this.lblInstrucciones.Font = new System.Drawing.Font("Arial", 11F);
            this.lblInstrucciones.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblInstrucciones.Location = new System.Drawing.Point(20, 15);
            this.lblInstrucciones.Name = "lblInstrucciones";
            this.lblInstrucciones.Size = new System.Drawing.Size(920, 50);
            this.lblInstrucciones.TabIndex = 0;
            this.lblInstrucciones.Text = "Instrucciones del juego";
            // 
            // lblPaso
            // 
            this.lblPaso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(150)))));
            this.lblPaso.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblPaso.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPaso.Location = new System.Drawing.Point(20, 70);
            this.lblPaso.Name = "lblPaso";
            this.lblPaso.Size = new System.Drawing.Size(920, 35);
            this.lblPaso.TabIndex = 1;
            this.lblPaso.Text = "Paso actual";
            this.lblPaso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelRecipiente
            // 
            this.panelRecipiente.BackColor = System.Drawing.Color.Transparent;
            this.panelRecipiente.Controls.Add(this.picLicuadora);
            this.panelRecipiente.Controls.Add(this.picHorno);
            this.panelRecipiente.Location = new System.Drawing.Point(330, 120);
            this.panelRecipiente.Name = "panelRecipiente";
            this.panelRecipiente.Size = new System.Drawing.Size(340, 300);
            this.panelRecipiente.TabIndex = 2;
            // 
            // picLicuadora
            // 
            this.picLicuadora.BackColor = System.Drawing.Color.White;
            this.picLicuadora.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picLicuadora.Location = new System.Drawing.Point(50, 10);
            this.picLicuadora.Name = "picLicuadora";
            this.picLicuadora.Size = new System.Drawing.Size(240, 280);
            this.picLicuadora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLicuadora.TabIndex = 0;
            this.picLicuadora.TabStop = false;
            // 
            // picHorno
            // 
            this.picHorno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.picHorno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picHorno.Location = new System.Drawing.Point(0, 0);
            this.picHorno.Name = "picHorno";
            this.picHorno.Size = new System.Drawing.Size(340, 300);
            this.picHorno.TabIndex = 1;
            this.picHorno.TabStop = false;
            this.picHorno.Visible = false;
            // 
            // panelIngredientes
            // 
            this.panelIngredientes.AutoScroll = true;
            this.panelIngredientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(220)))));
            this.panelIngredientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelIngredientes.Location = new System.Drawing.Point(20, 120);
            this.panelIngredientes.Name = "panelIngredientes";
            this.panelIngredientes.Size = new System.Drawing.Size(300, 420);
            this.panelIngredientes.TabIndex = 3;
            // 
            // panelControles
            // 
            this.panelControles.BackColor = System.Drawing.Color.Transparent;
            this.panelControles.Controls.Add(this.btnContinuar);
            this.panelControles.Controls.Add(this.progressBar);
            this.panelControles.Location = new System.Drawing.Point(20, 550);
            this.panelControles.Name = "panelControles";
            this.panelControles.Size = new System.Drawing.Size(920, 80);
            this.panelControles.TabIndex = 4;
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.LightGreen;
            this.btnContinuar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinuar.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.btnContinuar.Location = new System.Drawing.Point(360, 5);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(200, 50);
            this.btnContinuar.TabIndex = 0;
            this.btnContinuar.Text = "▶ COMENZAR";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(10, 60);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(900, 15);
            this.progressBar.TabIndex = 1;
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.Transparent;
            this.panelInfo.Controls.Add(this.lblPuntos);
            this.panelInfo.Controls.Add(this.lblTiempo);
            this.panelInfo.Location = new System.Drawing.Point(690, 430);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(250, 110);
            this.panelInfo.TabIndex = 5;
            // 
            // lblPuntos
            // 
            this.lblPuntos.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblPuntos.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblPuntos.Location = new System.Drawing.Point(10, 60);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(230, 30);
            this.lblPuntos.TabIndex = 0;
            this.lblPuntos.Text = "⭐ Puntos: 0";
            // 
            // lblTiempo
            // 
            this.lblTiempo.BackColor = System.Drawing.Color.Transparent;
            this.lblTiempo.Font = new System.Drawing.Font("Arial", 10F);
            this.lblTiempo.Location = new System.Drawing.Point(10, 20);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(230, 25);
            this.lblTiempo.TabIndex = 1;
            this.lblTiempo.Text = "⏱️ Tiempo: 0s";
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(200, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(600, 70);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "🍽️ RECETA DEL:\r\nGlaseado con Mango y Jengibre 🥭";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.panelPrincipal.Controls.Add(this.btbmejue);
            this.panelPrincipal.Controls.Add(this.lblTitulo);
            this.panelPrincipal.Controls.Add(this.panelJuego);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1000, 749);
            this.panelPrincipal.TabIndex = 0;
            this.panelPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPrincipal_Paint);
            // 
            // btbmejue
            // 
            this.btbmejue.BackColor = System.Drawing.Color.Cornsilk;
            this.btbmejue.Location = new System.Drawing.Point(4, 4);
            this.btbmejue.Name = "btbmejue";
            this.btbmejue.Size = new System.Drawing.Size(145, 34);
            this.btbmejue.TabIndex = 2;
            this.btbmejue.Text = "🏠 MENÚ PRINCIPAL";
            this.btbmejue.UseVisualStyleBackColor = false;
            this.btbmejue.Click += new System.EventHandler(this.button1_Click);
            // 
            // juegoreceta1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 749);
            this.Controls.Add(this.panelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "juegoreceta1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juego de Cocina - Glaseado con Mango y Jengibre";
            this.panelJuego.ResumeLayout(false);
            this.panelRecipiente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLicuadora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHorno)).EndInit();
            this.panelControles.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.panelPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerAnimacion;
        private System.Windows.Forms.Timer timerJuego;
        private System.Windows.Forms.Panel panelJuego;
        private System.Windows.Forms.Label lblInstrucciones;
        private System.Windows.Forms.Label lblPaso;
        private System.Windows.Forms.Panel panelRecipiente;
        private System.Windows.Forms.PictureBox picLicuadora;
        private System.Windows.Forms.PictureBox picHorno;
        private System.Windows.Forms.Panel panelIngredientes;
        private System.Windows.Forms.Panel panelControles;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label lblPuntos;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Button btbmejue;
    }
}