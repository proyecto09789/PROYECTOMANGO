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
    public partial class FormAbono : Form
    {
        public FormAbono()
        {
            InitializeComponent();

        }

        private void FormAbono_Load(object sender, EventArgs e)
        {

        }

        private void btnAbono_Click(object sender, EventArgs e)
        {
            Cuidatumango098.hambre = 100;
            MessageBox.Show("abonando");
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Cuidatumango098 f = new Cuidatumango098();
            f.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pbBolsaAbono_MouseDown(object sender, MouseEventArgs e)
        {
            pbBolsaAbono.DoDragDrop("ABONO", DragDropEffects.Move);
        }
        private void pbMango_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Move;
        }


        private void pbBolsaAbono_Click(object sender, EventArgs e)
        {

        }
    }
}
