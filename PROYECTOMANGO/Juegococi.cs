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
    public partial class btnrece24 : Form
    {
        public btnrece24()
        {
            InitializeComponent();
        }

        private void btncoci_Click(object sender, EventArgs e)
        {
            juegoreceta1 ventam1 = new juegoreceta1();
            ventam1.Show();
            this.Hide();
        }
    }
}
