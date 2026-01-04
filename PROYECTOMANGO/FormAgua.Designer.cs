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
            // FormAgua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROYECTOMANGO.Properties.Resources.mangoFondo1;
            this.ClientSize = new System.Drawing.Size(479, 450);
            this.Controls.Add(this.btnHidratar);
            this.Controls.Add(this.btnVolver);
            this.Name = "FormAgua";
            this.Text = "FormAgua";
            this.Load += new System.EventHandler(this.FormAgua_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnHidratar;
    }
}