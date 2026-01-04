namespace PROYECTOBETA001
{
    partial class Cuidatumango098
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cuidatumango098));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbAbono = new System.Windows.Forms.ProgressBar();
            this.pbSed = new System.Windows.Forms.ProgressBar();
            this.timerEstado = new System.Windows.Forms.Timer(this.components);
            this.btnAbono = new System.Windows.Forms.Button();
            this.btnSed = new System.Windows.Forms.Button();
            this.REGREMANG = new System.Windows.Forms.Button();
            this.pbMango = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMango)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(125, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Abono";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(399, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sed";
            // 
            // pbAbono
            // 
            this.pbAbono.Location = new System.Drawing.Point(89, 410);
            this.pbAbono.Name = "pbAbono";
            this.pbAbono.Size = new System.Drawing.Size(186, 23);
            this.pbAbono.TabIndex = 3;
            this.pbAbono.Value = 100;
            this.pbAbono.Click += new System.EventHandler(this.pbAbono_Click);
            // 
            // pbSed
            // 
            this.pbSed.Location = new System.Drawing.Point(346, 410);
            this.pbSed.Name = "pbSed";
            this.pbSed.Size = new System.Drawing.Size(157, 23);
            this.pbSed.TabIndex = 4;
            this.pbSed.Value = 100;
            // 
            // timerEstado
            // 
            this.timerEstado.Enabled = true;
            this.timerEstado.Interval = 1000;
            this.timerEstado.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnAbono
            // 
            this.btnAbono.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbono.Location = new System.Drawing.Point(122, 452);
            this.btnAbono.Name = "btnAbono";
            this.btnAbono.Size = new System.Drawing.Size(121, 35);
            this.btnAbono.TabIndex = 5;
            this.btnAbono.Text = "Abonar";
            this.btnAbono.UseVisualStyleBackColor = true;
            this.btnAbono.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSed
            // 
            this.btnSed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSed.Location = new System.Drawing.Point(357, 452);
            this.btnSed.Name = "btnSed";
            this.btnSed.Size = new System.Drawing.Size(121, 35);
            this.btnSed.TabIndex = 6;
            this.btnSed.Text = "Hidratar";
            this.btnSed.UseVisualStyleBackColor = true;
            this.btnSed.Click += new System.EventHandler(this.button2_Click);
            // 
            // REGREMANG
            // 
            this.REGREMANG.Location = new System.Drawing.Point(13, 13);
            this.REGREMANG.Name = "REGREMANG";
            this.REGREMANG.Size = new System.Drawing.Size(75, 23);
            this.REGREMANG.TabIndex = 7;
            this.REGREMANG.Text = "REGRESAR";
            this.REGREMANG.UseVisualStyleBackColor = true;
            this.REGREMANG.Click += new System.EventHandler(this.REGREMANG_Click);
            // 
            // pbMango
            // 
            this.pbMango.Image = global::PROYECTOMANGO.Properties.Resources.mangocdxd;
            this.pbMango.Location = new System.Drawing.Point(222, 64);
            this.pbMango.Name = "pbMango";
            this.pbMango.Size = new System.Drawing.Size(181, 195);
            this.pbMango.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMango.TabIndex = 0;
            this.pbMango.TabStop = false;
            // 
            // Cuidatumango098
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(615, 533);
            this.Controls.Add(this.REGREMANG);
            this.Controls.Add(this.btnSed);
            this.Controls.Add(this.btnAbono);
            this.Controls.Add(this.pbSed);
            this.Controls.Add(this.pbAbono);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbMango);
            this.Name = "Cuidatumango098";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMango)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMango;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar pbAbono;
        private System.Windows.Forms.ProgressBar pbSed;
        private System.Windows.Forms.Timer timerEstado;
        private System.Windows.Forms.Button btnAbono;
        private System.Windows.Forms.Button btnSed;
        private System.Windows.Forms.Button REGREMANG;
    }
}