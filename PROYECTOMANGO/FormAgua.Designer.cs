namespace PROYECTOMANGO
{
    partial class FormAgua
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
            this.btnHidratar = new System.Windows.Forms.Button();
            this.pbAguaCopia = new System.Windows.Forms.ProgressBar();
            this.pbMango = new System.Windows.Forms.PictureBox();
            this.pbBotellaAgua = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMango)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBotellaAgua)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(26, 12);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "REGRESAR";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnHidratar
            // 
            this.btnHidratar.Location = new System.Drawing.Point(196, 367);
            this.btnHidratar.Name = "btnHidratar";
            this.btnHidratar.Size = new System.Drawing.Size(75, 23);
            this.btnHidratar.TabIndex = 1;
            this.btnHidratar.Text = "Hidratar";
            this.btnHidratar.UseVisualStyleBackColor = true;
            this.btnHidratar.Click += new System.EventHandler(this.btnHidratar_Click);
            // 
            // pbAguaCopia
            // 
            this.pbAguaCopia.Location = new System.Drawing.Point(161, 326);
            this.pbAguaCopia.Name = "pbAguaCopia";
            this.pbAguaCopia.Size = new System.Drawing.Size(157, 23);
            this.pbAguaCopia.TabIndex = 5;
            this.pbAguaCopia.Value = 100;
            // 
            // pbMango
            // 
            this.pbMango.Image = global::PROYECTOMANGO.Properties.Resources.mangocdxd;
            this.pbMango.Location = new System.Drawing.Point(162, 62);
            this.pbMango.Name = "pbMango";
            this.pbMango.Size = new System.Drawing.Size(156, 159);
            this.pbMango.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMango.TabIndex = 6;
            this.pbMango.TabStop = false;
            // 
            // pbBotellaAgua
            // 
            this.pbBotellaAgua.BackColor = System.Drawing.Color.Transparent;
            this.pbBotellaAgua.Image = global::PROYECTOMANGO.Properties.Resources.regaderapng;
            this.pbBotellaAgua.Location = new System.Drawing.Point(26, 304);
            this.pbBotellaAgua.Name = "pbBotellaAgua";
            this.pbBotellaAgua.Size = new System.Drawing.Size(178, 134);
            this.pbBotellaAgua.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBotellaAgua.TabIndex = 7;
            this.pbBotellaAgua.TabStop = false;
            // 
            // FormAgua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROYECTOMANGO.Properties.Resources.mangoFondo1;
            this.ClientSize = new System.Drawing.Size(479, 450);
            this.Controls.Add(this.btnHidratar);
            this.Controls.Add(this.pbAguaCopia);
            this.Controls.Add(this.pbBotellaAgua);
            this.Controls.Add(this.pbMango);
            this.Controls.Add(this.btnVolver);
            this.Name = "FormAgua";
            this.Text = "FormAgua";
            this.Load += new System.EventHandler(this.FormAgua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMango)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBotellaAgua)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnHidratar;
        private System.Windows.Forms.ProgressBar pbAguaCopia;
        private System.Windows.Forms.PictureBox pbMango;
        private System.Windows.Forms.PictureBox pbBotellaAgua;
    }
}