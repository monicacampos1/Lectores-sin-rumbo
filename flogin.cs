using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Practica_semana_10
{
    public partial class flogin : Form
    {
        public flogin()
        {
            InitializeComponent();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {

            try

            {

                MySqlConnection conn = new MySqlConnection("server=localhost;user id=biblioteca;password=trejo1090;persistsecurityinfo=True;database=biblioteca");

                conn.Open();

                MySqlCommand Pedir = new MySqlCommand("Select nombreusu, claveusu from tusuarios where nombreusu = '" + txtusu.Text + "'And claveusu = '" + txtclave.Text + "'", conn);
                Pedir.ExecuteNonQuery();
                DataSet fe = new DataSet();
                MySqlDataAdapter te = new MySqlDataAdapter(Pedir);

                te.Fill(fe, "tusuarios");

                DataRow res;
                res = fe.Tables["tusuarios"].Rows[0];

                if ((txtusu.Text == res["nombreusu"].ToString()) || (txtclave.Text == res["claveusu"].ToString()))
                {

                    Menu fprincipal = new Menu();
                    fprincipal.Show();
                    this.Hide();
                }

            }
            catch
            {


                txtusu.Clear();
                txtclave.Clear();

                MessageBox.Show("Error de usuario o clave de acceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            mysqlusu fprincipal = new mysqlusu();
            fprincipal.Show();
            this.Hide();
        }
    }
}
