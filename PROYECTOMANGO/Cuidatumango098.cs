    using PROYECTOMANGO;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace PROYECTOBETA001
    {
        public partial class Cuidatumango098 : Form

        {
        public static int hambre = 100;
        public static int sed = 100;

        public Cuidatumango098()
            {
                InitializeComponent();
                pbAbono.Value = hambre;
                pbSed.Value = sed;
            timerEstado.Interval = 27000;
            timerEstado.Start();
            }

            private void button1_Click(object sender, EventArgs e)
            {
                FormAbono f = new FormAbono();
                f.Show();
                this.Hide();
            }

            private void Form1_Load(object sender, EventArgs e)
            {

            }

            private void timer1_Tick(object sender, EventArgs e)
            {
                if (hambre > 0) hambre--;
                if (sed > 0) sed--;

                pbAbono.Value = hambre;
                pbSed.Value = sed;

                if (hambre == 0 || sed == 0)
                {
                    timerEstado.Stop();
                    MessageBox.Show("manguito esta mal :(");
                }
            }

            private void button2_Click(object sender, EventArgs e)
            {
                FormAgua f = new FormAgua();
                f.Show();
                this.Hide();
            }
        

            private void REGREMANG_Click(object sender, EventArgs e)
            {
                Interfazprinc h56s = new Interfazprinc();
                h56s.Show();
                this.Hide();

            }

            private void label1_Click(object sender, EventArgs e)
            {

            }

            private void pbAbono_Click(object sender, EventArgs e)
            {

            }
        }
    }
