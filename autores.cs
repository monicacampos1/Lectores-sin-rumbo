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
using System.Data.SqlTypes; 

namespace Practica_semana_10
{
    public partial class autores : Form
    {
        //Variables globales
        public string cadena_conexion = " server=localhost;user id=biblioteca;password=trejo1090;database=biblioteca;persistsecurityinfo=True";
        public autores()
        {
            InitializeComponent();
        }

        private void bagregar_Click(object sender, EventArgs e)
        {
            agregarautores ven = new agregarautores();
            ven.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void autores_Load(object sender, EventArgs e)
        {
            txtautor.Visible = false;
            txtid.Visible = false;
            label1.Visible = false;
            label2.Visible = false;

            bbuscar.Enabled = false;


            try
            {

                string consulta = "select * from tautor";

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

            {
                try
                {

                    string consulta = "select * from tautor";

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
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtautor.Visible = false;
            txtid.Visible = false;
            label1.Visible = false;
            label2.Visible = false;

        
            txtautor.Text = "";
            txtid.Text = "";
            textbuscar.Text = "";
            radioButton1.Checked = false;
            rnombre.Checked = false;
            bbuscar.Enabled = false;
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
                    string myInsertQuery = ("select * from tautor Where idautor = '" + textbuscar.Text + "'");
                    MySqlCommand myCommand = new MySqlCommand(myInsertQuery, myConnection);
                    myCommand.Connection = myConnection;
                    myConnection.Open();
                    MySqlDataReader myReader;
                    myReader = myCommand.ExecuteReader();
                    if (myReader.Read() == true)
                    {
                        txtautor.Text = (myReader.GetString(2));
                        txtid.Text = (myReader.GetString(1));
                        txtautor.Visible = true;
                        txtid.Visible = true;
                        label1.Visible = true;
                        label2.Visible = true;


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
                    string myInsertQuery = ("select * from tautor Where nombreau = '" + textbuscar.Text + "'");
                    MySqlCommand myCommand = new MySqlCommand(myInsertQuery, myConnection);
                    myCommand.Connection = myConnection;
                    myConnection.Open();
                    MySqlDataReader myReader;
                    myReader = myCommand.ExecuteReader();
                    if (myReader.Read() == true)
                    {

                        txtautor.Text = (myReader.GetString(2));
                        txtid.Text = (myReader.GetString(1));
                                txtautor.Visible = true;
                                txtid.Visible = true;
                                label1.Visible = true;
                                label2.Visible = true;

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


