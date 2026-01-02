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
    public partial class mangomayinterf : Form
    {
        Point panelOculto;
        Point panelVisible;

        public mangomayinterf()
        {
            InitializeComponent();
        }

       

        private void btnRecetaman_Click(object sender, EventArgs e)
        {
            
            panelBeneficios.Visible = false;
            paneldelusoculinario.Visible = true;

        }

        

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void mangomayinterf_Load(object sender, EventArgs e)

        {

            panelOculto = new Point(-panelrecetaGlaseadoMangJengibre.Width,
                                    panelrecetaGlaseadoMangJengibre.Location.Y);

            panelVisible = new Point(1, 1); 
            panelrecetaGlaseadoMangJengibre.Location = panelOculto;

        }

        private void verresetGlaseMan_Click(object sender, EventArgs e)
        {
            panelrecetaGlaseadoMangJengibre.Location = panelVisible;
            paneldelusoculinario.Visible = false;
        }

        private void CerrarbtnResetGlaseadoMango_Click(object sender, EventArgs e)
        {
            panelrecetaGlaseadoMangJengibre.Location = panelOculto;
            paneldelusoculinario.Visible = true;
        }

        private void menuinterzaprin01_Click(object sender, EventArgs e)
        {
            Interfazprinc vent0001 = new Interfazprinc();
            vent0001.Show();
            this.Hide();
        }

        private void btnbenefsal_Click(object sender, EventArgs e)
        {
            
            panelBeneficios.Visible = true;
     

        }

        private void panelrecetaGlaseadoMangJengibre_Paint(object sender, PaintEventArgs e)
        {

        }

      
        private void btnjuegococi_Click(object sender, EventArgs e)
        {
            btnrece24 ventjuegococi = new btnrece24();
            ventjuegococi.Show();
            this.Hide();
        }
    }
    
}

