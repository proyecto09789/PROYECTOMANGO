namespace PROYECTOBETA001
{
    partial class LoginForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnLogin1 = new System.Windows.Forms.Button();
            this.relleno0 = new System.Windows.Forms.Label();
            this.relleno3 = new System.Windows.Forms.Label();
            this.relleno2 = new System.Windows.Forms.Label();
            this.relleno1 = new System.Windows.Forms.Label();
            this.fonNombre = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fonNombre)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(459, 314);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(455, 26);
            this.txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(459, 429);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(455, 26);
            this.txtPassword.TabIndex = 1;
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.BackColor = System.Drawing.Color.Transparent;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(685, 499);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(236, 103);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Registrar Usuario";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.Transparent;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.Transparent;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.Transparent;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(782, 536);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(10, 26);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Visible = false;
            // 
            // btnLogin1
            // 
            this.btnLogin1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin1.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin1.Location = new System.Drawing.Point(434, 500);
            this.btnLogin1.Name = "btnLogin1";
            this.btnLogin1.Size = new System.Drawing.Size(226, 102);
            this.btnLogin1.TabIndex = 2;
            this.btnLogin1.Text = "Iniciar Sesión";
            this.btnLogin1.UseVisualStyleBackColor = false;
            this.btnLogin1.Click += new System.EventHandler(this.btnLogin1_Click);
            // 
            // relleno0
            // 
            this.relleno0.AutoSize = true;
            this.relleno0.BackColor = System.Drawing.Color.Transparent;
            this.relleno0.Location = new System.Drawing.Point(650, 500);
            this.relleno0.Name = "relleno0";
            this.relleno0.Size = new System.Drawing.Size(67, 117);
            this.relleno0.TabIndex = 5;
            this.relleno0.Text = "                    \r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n.";
            // 
            // relleno3
            // 
            this.relleno3.AutoSize = true;
            this.relleno3.BackColor = System.Drawing.Color.Transparent;
            this.relleno3.Location = new System.Drawing.Point(431, 500);
            this.relleno3.Name = "relleno3";
            this.relleno3.Size = new System.Drawing.Size(16, 143);
            this.relleno3.TabIndex = 6;
            this.relleno3.Text = "   \r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n.";
            // 
            // relleno2
            // 
            this.relleno2.AutoSize = true;
            this.relleno2.BackColor = System.Drawing.Color.Transparent;
            this.relleno2.Location = new System.Drawing.Point(431, 588);
            this.relleno2.Name = "relleno2";
            this.relleno2.Size = new System.Drawing.Size(490, 26);
            this.relleno2.TabIndex = 7;
            this.relleno2.Text = "\r\n                                                                               " +
    "                                                                                " +
    "  ";
            // 
            // relleno1
            // 
            this.relleno1.AutoSize = true;
            this.relleno1.BackColor = System.Drawing.Color.Transparent;
            this.relleno1.Location = new System.Drawing.Point(422, 483);
            this.relleno1.Name = "relleno1";
            this.relleno1.Size = new System.Drawing.Size(511, 26);
            this.relleno1.TabIndex = 8;
            this.relleno1.Text = "\r\n                                                                               " +
    "                                                                                " +
    "         ";
            // 
            // fonNombre
            // 
            this.fonNombre.Image = global::PROYECTOMANGO.Properties.Resources.PANTALLADECARGA;
            this.fonNombre.Location = new System.Drawing.Point(2, 669);
            this.fonNombre.Name = "fonNombre";
            this.fonNombre.Size = new System.Drawing.Size(1370, 213);
            this.fonNombre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fonNombre.TabIndex = 10;
            this.fonNombre.TabStop = false;
            this.fonNombre.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.BackgroundImage = global::PROYECTOMANGO.Properties.Resources.FONDOINTERFAACTUALIZADO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.fonNombre);
            this.Controls.Add(this.relleno1);
            this.Controls.Add(this.relleno2);
            this.Controls.Add(this.relleno3);
            this.Controls.Add(this.relleno0);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnLogin1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.dateTimePicker1);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fonNombre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnLogin1;
        private System.Windows.Forms.Label relleno0;
        private System.Windows.Forms.Label relleno3;
        private System.Windows.Forms.Label relleno2;
        private System.Windows.Forms.Label relleno1;
        private System.Windows.Forms.PictureBox fonNombre;
    }
}

