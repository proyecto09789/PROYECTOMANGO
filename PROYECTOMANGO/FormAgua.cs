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
        public FormAgua()
        {
            InitializeComponent();
        }

        private void FormAgua_Load(object sender, EventArgs e)
        {

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
