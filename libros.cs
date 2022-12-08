using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_semana_10
{
    public partial class libros : Form
    {

      
        //Variables globales
        public string cadena_conexion = "server=localhost;user id=biblioteca;password=trejo1090;database=biblioteca;persistsecurityinfo=True";
        public libros()
        {
            InitializeComponent();



        }

        private void bagregar_Click(object sender, EventArgs e)
        {
            agregralibros ven = new agregralibros();
            ven.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void libros_Load(object sender, EventArgs e)
        {

            bbuscar.Enabled = false;
            tedi.Enabled = false;
            txtli.Enabled = false;
            txtlibros.Enabled = false;
            txtau.Enabled = false;
            txtes.Enabled = false;

            try
            {

                string consulta = "select * from tlibros";

        MySqlConnection conexion = new MySqlConnection(cadena_conexion);
        MySqlDataAdapter comando = new MySqlDataAdapter(consulta, conexion);

        System.Data.DataSet ds = new System.Data.DataSet();
        comando.Fill(ds, "biblioteca");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "biblioteca";

            }
            catch (MySqlException)
            {

                MessageBox.Show("Error de conexion", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            try
            {

                string consulta = "select * from tlibros";

                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter comando = new MySqlDataAdapter(consulta, conexion);

                System.Data.DataSet ds = new System.Data.DataSet();
                comando.Fill(ds, "biblioteca");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "biblioteca";

            }
            catch (MySqlException)
            {

                MessageBox.Show("Error de conexion", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
          
            tedi.Text = "";
            txtli.Text = "";
            txtlibros.Text = "";
            txtau.Text = "";
            txtes.Text = "";
            radioButton1.Checked = false;
            rnombre.Checked = false;
            bbuscar.Enabled = false;

            label1.Visible = false ;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            tedi.Visible = false;
            txtli.Visible = false;
            txtlibros.Visible = false;
            txtau.Visible = false;
            txtes.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void bbuscar_Click(object sender, EventArgs e)
        {
           
            if (radioButton1.Checked == true)
            {
                try
                {
                    MySqlConnection myConnection = new MySqlConnection(cadena_conexion);
                    string myInsertQuery = ("select * from tlibros Where idlibro = '" + txtbuscar.Text + "'");
                    MySqlCommand myCommand = new MySqlCommand(myInsertQuery, myConnection);
                    myCommand.Connection = myConnection;
                    myConnection.Open();
                    MySqlDataReader myReader;
                    myReader = myCommand.ExecuteReader();
                    if (myReader.Read() == true)
                    {


                        tedi.Text = (myReader.GetString(3));
                        txtli.Text = (myReader.GetString(0));
                        txtlibros.Text = (myReader.GetString(1));
                        txtau.Text = (myReader.GetString(2));
                        txtes.Text = (myReader.GetString(5));

                        label1.Visible = true;
                        label2.Visible = true;
                        label3.Visible = true;
                        label4.Visible = true;
                        label5.Visible = true;
                        tedi.Visible = true;
                        txtli.Visible = true;
                        txtlibros.Visible = true;
                        txtau.Visible = true;
                        txtes.Visible = true;

                    }
                    else
                    {
                        MessageBox.Show("El usuario no existe", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    myReader.Close();
                    myConnection.Close();
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Campo de busqueda está vacío", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else

            {
                if (rnombre.Checked == true)
            {
                {
                try
                {
                    MySqlConnection myConnection = new MySqlConnection(cadena_conexion);
                    string myInsertQuery = ("select * from tlibros Where nombreli = '" + txtbuscar.Text + "'");
                    MySqlCommand myCommand = new MySqlCommand(myInsertQuery, myConnection);
                    myCommand.Connection = myConnection;
                    myConnection.Open();
                    MySqlDataReader myReader;
                    myReader = myCommand.ExecuteReader();
                    if (myReader.Read() == true)
                    {


                        tedi.Text = (myReader.GetString(3));
                        txtli.Text = (myReader.GetString(0));
                        txtlibros.Text = (myReader.GetString(1));
                        txtau.Text = (myReader.GetString(2));
                        txtes.Text = (myReader.GetString(5));
                                label1.Visible = true;
                                label2.Visible = true;
                                label3.Visible = true;
                                label4.Visible = true;
                                label5.Visible = true;
                                tedi.Visible = true;
                                txtli.Visible = true;
                                txtlibros.Visible = true;
                                txtau.Visible = true;
                                txtes.Visible = true;

                            }
                    else
                    {
                        MessageBox.Show("El usuario no existe", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                   
                    myReader.Close();
                    myConnection.Close();
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Campo de busqueda está vacío", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

                                    
            }
        }
    
}

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            bbuscar.Enabled = true;
        }

        private void rnombre_CheckedChanged(object sender, EventArgs e)
        {
            bbuscar.Enabled = true;
        }
    }
        }





