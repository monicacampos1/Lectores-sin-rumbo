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
    public partial class empleados1 : Form
    {
        //Variables globales
        public string cadena_conexion = " server=localhost;user id=biblioteca;password=trejo1090;database=biblioteca;persistsecurityinfo=True";
        public empleados1()
        {
            InitializeComponent();
        }

        private void bagregar_Click(object sender, EventArgs e)
        {
            agregarempleados ven = new agregarempleados();
            ven.Show();
        }

        private void empledos1_Load(object sender, EventArgs e)
        {

            try
            {

                string consulta = "select * from templeados";

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

            bBuscar.Enabled = false;
            txtempleado.Enabled = false;
            txtidempleado.Enabled = false;
            label1.Visible = false;
            label2.Visible = false;
            txtempleado.Visible = false;
            txtidempleado.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bbuscar_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                try
                {
                    MySqlConnection myConnection = new MySqlConnection(cadena_conexion);
                    string myInsertQuery = ("select * from templeados Where idempleado = '" + txtbuscar.Text + "'");
                    MySqlCommand myCommand = new MySqlCommand(myInsertQuery, myConnection);
                    myCommand.Connection = myConnection;
                    myConnection.Open();
                    MySqlDataReader myReader;
                    myReader = myCommand.ExecuteReader();
                    if (myReader.Read() == true)
                    {

                        txtempleado.Text = (myReader.GetString(1));
                        txtidempleado.Text = (myReader.GetString(0));
                        label1.Visible = true;
                        label2.Visible = true;
                        txtempleado.Visible = true;
                        txtidempleado.Visible = true;

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
                    string myInsertQuery = ("select * from templeados Where nombreem = '" + txtbuscar.Text + "'");
                    MySqlCommand myCommand = new MySqlCommand(myInsertQuery, myConnection);
                    myCommand.Connection = myConnection;
                    myConnection.Open();
                    MySqlDataReader myReader;
                    myReader = myCommand.ExecuteReader();
                    if (myReader.Read() == true)
                    {

                        txtempleado.Text = (myReader.GetString(1));
                        txtidempleado.Text = (myReader.GetString(0));

                                label1.Visible = true;
                                label2.Visible = true;
                                txtempleado.Visible = true;
                                txtidempleado.Visible = true;

                            }
                    else
                    {
                        MessageBox.Show("El empleado no existe", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtempleado.Text = " ";
            txtidempleado.Text = " ";
            radioButton1.Checked = false;
            rnombre.Checked = false;
            bBuscar.Enabled = false;
            label1.Visible = false;
            label2.Visible = false;
            txtempleado.Visible = false;
            txtidempleado.Visible = false;

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            try
            {

                string consulta = "select * from templeados";

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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            bBuscar.Enabled = true;
        }

        private void rnombre_CheckedChanged(object sender, EventArgs e)
        {
            bBuscar.Enabled = true;
        }
    }
}