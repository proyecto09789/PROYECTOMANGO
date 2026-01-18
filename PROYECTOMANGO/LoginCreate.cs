using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTOBETA001
{
    public partial class LoginForm : Form
    {

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand command;
        MySqlDataReader mdr;

        public LoginForm()
        {
            InitializeComponent();
        }

        private async Task btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please input Username and Password", "Error");
            }

            else
            {
                connection.Open();
                string selectQuery = "SELECT * FROM loginform.userinfo WHERE Username = '" + txtUsername.Text + "' AND Password = '" + txtPassword.Text + "';";
                command = new MySqlCommand(selectQuery, connection);
                mdr = command.ExecuteReader();
                if (mdr.Read())
                {
                    string MyConnection2 = "datasource=localhost;port=3306;username=root;password=";
                    string Query = "update loginform.userinfo set LastLogin='" + dateTimePicker1.Value + "' where Username='" + this.txtUsername.Text + "';";
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    while (MyReader2.Read())
                    {
                    }
                    MyConn2.Close();

                    IINIEXITO.Visible = true;

                    fonNombre.Visible = true;

                    await Task.Delay(4000);
                    this.Hide();
                    Interfazprinc frm2 = new Interfazprinc ();
                    frm2.ShowDialog();

                    

                }
                else
                {

                    MessageBox.Show("Incorrect Login Information! Try again.");
                }

                connection.Close();
            }
        }
/*
        private void HacerBotonRedondeado(Button boton, int radio)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();

            path.AddArc(0, 0, radio, radio, 180, 90);
            path.AddArc(boton.Width - radio, 0, radio, radio, 270, 90);
            path.AddArc(boton.Width - radio, boton.Height - radio, radio, radio, 0, 90);
            path.AddArc(0, boton.Height - radio, radio, radio, 90, 90);

            path.CloseFigure();
            boton.Region = new Region(path);
        }*/


        private void btnCreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateAccountForm frm3 = new CreateAccountForm();
            frm3.ShowDialog();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

            /*-------------------------------------------------------------------Esto es para rendondear los botones------------------------------------------------------------------------------*/
            /* Desabilitado por ahora
            //Botón de crear cuenta
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.FlatAppearance.BorderSize = 0;
            btnCreate.BackColor = Color.FromArgb(255, 153, 0); // Naranja
            btnCreate.ForeColor = Color.White;

            btnCreate.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnCreate.Size = new Size(142, 55);

            HacerBotonRedondeado(btnCreate, 32);

            //Botón de login
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.BackColor = Color.FromArgb(186, 63, 157); // Morado
            btnLogin.ForeColor = Color.White;

            btnLogin.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnLogin.Size = new Size(125, 55);

            HacerBotonRedondeado(btnLogin, 32);*/
            /*________________________________________________________________________________________________________________________________________________________________*/

        }
        

        private async void btnLogin1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please input Username and Password", "Error");
            }

            else
            {
                connection.Open();
                string selectQuery = "SELECT * FROM loginform.userinfo WHERE Username = '" + txtUsername.Text + "' AND Password = '" + txtPassword.Text + "';";
                command = new MySqlCommand(selectQuery, connection);
                mdr = command.ExecuteReader();
                if (mdr.Read())
                {
                    string MyConnection2 = "datasource=localhost;port=3306;username=root;password=";
                    string Query = "update loginform.userinfo set LastLogin='" + dateTimePicker1.Value + "' where Username='" + this.txtUsername.Text + "';";
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    while (MyReader2.Read())
                    {
                    }
                    MyConn2.Close();

                    IINIEXITO.Visible = true;

                    await Task.Delay(2000);

                    IINIEXITO.Visible = false;

                    fonNombre.Visible = true;

                    await Task.Delay(4000);
                    this.Hide();
                    Interfazprinc frm2 = new Interfazprinc();
                    frm2.ShowDialog();




                }
                else
                {

                    MessageBox.Show("Incorrect Login Information! Try again.");
                }

                connection.Close();
            }
        }
    }
}
