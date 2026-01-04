namespace PROYECTOMANGO
{
    partial class FormAbono
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAbono = new System.Windows.Forms.Button();
            this.pbBolsaAbono = new System.Windows.Forms.PictureBox();
            this.pbMango = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBolsaAbono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMango)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(36, 13);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "REGRESAR";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAbono
            // 
            this.btnAbono.Location = new System.Drawing.Point(233, 368);
            this.btnAbono.Name = "btnAbono";
            this.btnAbono.Size = new System.Drawing.Size(75, 23);
            this.btnAbono.TabIndex = 1;
            this.btnAbono.Text = "Abonar";
            this.btnAbono.UseVisualStyleBackColor = true;
            this.btnAbono.Click += new System.EventHandler(this.btnAbono_Click);
            // 
            // pbBolsaAbono
            // 
            this.pbBolsaAbono.BackColor = System.Drawing.Color.Transparent;
            this.pbBolsaAbono.Image = global::PROYECTOMANGO.Properties.Resources.abonopng;
            this.pbBolsaAbono.Location = new System.Drawing.Point(-5, 244);
            this.pbBolsaAbono.Name = "pbBolsaAbono";
            this.pbBolsaAbono.Size = new System.Drawing.Size(232, 226);
            this.pbBolsaAbono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBolsaAbono.TabIndex = 2;
            this.pbBolsaAbono.TabStop = false;
            this.pbBolsaAbono.Click += new System.EventHandler(this.pbBolsaAbono_Click);
            // 
            // pbMango
            // 
            this.pbMango.Image = global::PROYECTOMANGO.Properties.Resources.mangocdxd;
            this.pbMango.Location = new System.Drawing.Point(183, 63);
            this.pbMango.Name = "pbMango";
            this.pbMango.Size = new System.Drawing.Size(186, 175);
            this.pbMango.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMango.TabIndex = 3;
            this.pbMango.TabStop = false;
            this.pbMango.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormAbono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROYECTOMANGO.Properties.Resources.mangoFondo;
            this.ClientSize = new System.Drawing.Size(522, 450);
            this.Controls.Add(this.pbMango);
            this.Controls.Add(this.btnAbono);
            this.Controls.Add(this.pbBolsaAbono);
            this.Controls.Add(this.btnVolver);
            this.Name = "FormAbono";
            this.Text = "FormAbono";
            this.Load += new System.EventHandler(this.FormAbono_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBolsaAbono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMango)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAbono;
        private System.Windows.Forms.PictureBox pbBolsaAbono;
        private System.Windows.Forms.PictureBox pbMango;
    }
}