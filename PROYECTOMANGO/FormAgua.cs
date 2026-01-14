using PROYECTOBETA001;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTOMANGO
{
    public partial class FormAgua : Form
    {
        Timer timerActualizar = new Timer();
        int objetivo = 0;


        public FormAgua()
        {
            InitializeComponent();
        }

        private void FormAgua_Load(object sender, EventArgs e)
        {
            pbAguaCopia.Minimum = 0;
            pbAguaCopia.Maximum = 100;
            pbAguaCopia.Step = 1;
            pbAguaCopia.Style = ProgressBarStyle.Continuous;
            pbAguaCopia.Value = Cuidatumango098.sed;

            pbMango.AllowDrop = true;

            timerActualizar.Interval = 50;
            timerActualizar.Tick += timerActualizar_Tick;
        }

        private void pbBotellaAgua_MouseDown(object sender, MouseEventArgs e)
        {
            pbBotellaAgua.DoDragDrop("AGUA", DragDropEffects.Move);
        }

        private void pbMango_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Move;
        }
        private void pbMango_DragDrop(object sender, DragEventArgs e)
        {
            Cuidatumango098.sed += 20;
            if (Cuidatumango098.sed > 100)
                Cuidatumango098.sed = 100;

            objetivo = Cuidatumango098.sed;
            timerActualizar.Start();
        }
        private void timerActualizar_Tick(object sender, EventArgs e)
        {
            if (pbAguaCopia.Value < objetivo)
            {
                pbAguaCopia.Value++;
            }
            else
            {
                timerActualizar.Stop();
            }
        }


        private void btnHidratar_Click(object sender, EventArgs e)
        {
            Cuidatumango098.sed = 100;
            MessageBox.Show("hidratando");
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Cuidatumango098 f = new Cuidatumango098();
            f.Show();
            this.Close();
        }
    }
}
