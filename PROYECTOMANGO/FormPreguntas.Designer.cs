namespace PROYECTOMANGO
{
    partial class FormPreguntas
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
            this.lblPreguntas = new System.Windows.Forms.Label();
            this.rbOpcion1 = new System.Windows.Forms.RadioButton();
            this.rbOpcion2 = new System.Windows.Forms.RadioButton();
            this.rbOpcion3 = new System.Windows.Forms.RadioButton();
            this.btnResponder = new System.Windows.Forms.Button();
            this.lblContador = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPreguntas
            // 
            this.lblPreguntas.AutoSize = true;
            this.lblPreguntas.BackColor = System.Drawing.Color.Transparent;
            this.lblPreguntas.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreguntas.Location = new System.Drawing.Point(27, 71);
            this.lblPreguntas.Name = "lblPreguntas";
            this.lblPreguntas.Size = new System.Drawing.Size(88, 32);
            this.lblPreguntas.TabIndex = 0;
            this.lblPreguntas.Text = "label1";
            // 
            // rbOpcion1
            // 
            this.rbOpcion1.AutoSize = true;
            this.rbOpcion1.BackColor = System.Drawing.Color.Transparent;
            this.rbOpcion1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOpcion1.Location = new System.Drawing.Point(108, 200);
            this.rbOpcion1.Name = "rbOpcion1";
            this.rbOpcion1.Size = new System.Drawing.Size(200, 40);
            this.rbOpcion1.TabIndex = 1;
            this.rbOpcion1.TabStop = true;
            this.rbOpcion1.Text = "radioButton1";
            this.rbOpcion1.UseVisualStyleBackColor = false;
            // 
            // rbOpcion2
            // 
            this.rbOpcion2.AutoSize = true;
            this.rbOpcion2.BackColor = System.Drawing.Color.Transparent;
            this.rbOpcion2.Font = new System.Drawing.Font("Times New Roman", 24F);
            this.rbOpcion2.Location = new System.Drawing.Point(108, 253);
            this.rbOpcion2.Name = "rbOpcion2";
            this.rbOpcion2.Size = new System.Drawing.Size(200, 40);
            this.rbOpcion2.TabIndex = 2;
            this.rbOpcion2.TabStop = true;
            this.rbOpcion2.Text = "radioButton2";
            this.rbOpcion2.UseVisualStyleBackColor = false;
            // 
            // rbOpcion3
            // 
            this.rbOpcion3.AutoSize = true;
            this.rbOpcion3.BackColor = System.Drawing.Color.Transparent;
            this.rbOpcion3.Font = new System.Drawing.Font("Times New Roman", 24F);
            this.rbOpcion3.Location = new System.Drawing.Point(108, 299);
            this.rbOpcion3.Name = "rbOpcion3";
            this.rbOpcion3.Size = new System.Drawing.Size(200, 40);
            this.rbOpcion3.TabIndex = 3;
            this.rbOpcion3.TabStop = true;
            this.rbOpcion3.Text = "radioButton3";
            this.rbOpcion3.UseVisualStyleBackColor = false;
            // 
            // btnResponder
            // 
            this.btnResponder.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResponder.Location = new System.Drawing.Point(400, 360);
            this.btnResponder.Name = "btnResponder";
            this.btnResponder.Size = new System.Drawing.Size(208, 89);
            this.btnResponder.TabIndex = 4;
            this.btnResponder.Text = "Verificar Respuesta";
            this.btnResponder.UseVisualStyleBackColor = true;
            this.btnResponder.Click += new System.EventHandler(this.btnResponder_Click);
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.BackColor = System.Drawing.Color.Transparent;
            this.lblContador.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.Location = new System.Drawing.Point(38, 426);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(61, 23);
            this.lblContador.TabIndex = 5;
            this.lblContador.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(703, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pon a Prueba tus conocimientos del mango";
            // 
            // FormPreguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROYECTOMANGO.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(768, 481);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.btnResponder);
            this.Controls.Add(this.rbOpcion3);
            this.Controls.Add(this.rbOpcion2);
            this.Controls.Add(this.rbOpcion1);
            this.Controls.Add(this.lblPreguntas);
            this.Name = "FormPreguntas";
            this.Text = "FormPreguntas";
            this.Load += new System.EventHandler(this.FormPreguntas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPreguntas;
        private System.Windows.Forms.RadioButton rbOpcion1;
        private System.Windows.Forms.RadioButton rbOpcion2;
        private System.Windows.Forms.RadioButton rbOpcion3;
        private System.Windows.Forms.Button btnResponder;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Label label1;
    }
}