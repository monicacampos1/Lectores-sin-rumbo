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
    public partial class agregarproveedores : Form
    {

        //Variables globales
        public string cadena_conexion = "server=localhost;user id=biblioteca;password=trejo1090;persistsecurityinfo=True;database=biblioteca";

        //Estas variables pueden ir en el boton que corresponde
        //Pero es mas efectivo que sean publicas globales
        public string usuario_modificar;
        public string usuario_eliminar;

        public agregarproveedores()
        {
            InitializeComponent();
        }

        private void bcerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void agregarproveedores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaDataSet.teditoriales' Puede moverla o quitarla según sea necesario.
            this.teditorialesTableAdapter.Fill(this.bibliotecaDataSet.teditoriales);
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaDataSet.tproveedores' Puede moverla o quitarla según sea necesario.
            this.tproveedoresTableAdapter.Fill(this.bibliotecaDataSet.tproveedores);

            bbuscar.Enabled = false;
            //Desabilitar campos, se activan al crear nuevo registro
            txtedi.Enabled = false;
            txtprove.Enabled = false;
            txttelefono.Enabled = false;
            txtdistri.Enabled = false;
            txtdirecc.Enabled = false;
            //txtnivel.Enabled = false;

            try
            {

                string consulta = "select * from tproveedores";

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

        private void bnuevo_Click(object sender, EventArgs e)
        {
            bbuscar.Enabled = false;
            txtedi.Enabled = true;
            txtprove.Enabled = true;
            txttelefono.Enabled = true;
            txtdistri.Enabled = true;
            txtdirecc.Enabled = true;
            txtedi.Text = "";
            txtprove.Text = "";
            txttelefono.Text = "";
            txtdistri.Text = "";
            txtdirecc.Text = "";
            txtedi.Focus();
            radioButton1.Checked = false;
            bnuevo.Visible = false;
            bguardar.Visible = true;

        }

        private void bguardar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                string myInsertQuery = "INSERT INTO tproveedores(ideditorialpro, nombrepro, direccionpro, telefonopro, nomdistribuidorapro) Values(?ideditorialpro,?nombrepro,?direccionpro,?telefonopro,?nomdistribuidorapro)";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);


                myCommand.Parameters.Add("?ideditorialpro", MySqlDbType.Int32, 11).Value = txtedi.Text;
                myCommand.Parameters.Add("?nombrepro", MySqlDbType.VarChar, 50).Value = txtprove.Text;
                myCommand.Parameters.Add("?direccionpro", MySqlDbType.VarChar,50).Value = txtdirecc.Text;
                myCommand.Parameters.Add("?telefonopro", MySqlDbType.VarChar, 20).Value =txttelefono.Text;
                myCommand.Parameters.Add("?nomdistribuidorapro", MySqlDbType.VarChar, 150).Value = txtdistri.Text;
                

                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                MessageBox.Show("Usuario agregado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string consulta = "select * from tproveedores";

                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "biblioteca");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "biblioteca";

            }
            catch (MySqlException)
            {
                MessageBox.Show("Ya existe el usuario", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            bnuevo.Visible = true;
            bguardar.Visible = false;

            //Desabilitar campos, se activan al crear nuevo registro
            txtedi.Enabled = false; 
            txtprove.Enabled   = false;
            txttelefono.Enabled = false;
            txtdistri.Enabled = false;
            txtdirecc.Enabled = false;
            bbuscar.Enabled = false;
            txtedi.Text = "";
            txtprove.Text = "";
            txttelefono.Text = "";
            txtdistri.Text = "";
            txtdirecc.Text = "";
            bnuevo.Focus();
        }

        private void bmodificar_Click(object sender, EventArgs e)
        {
            bbuscar.Enabled = false;
            txtedi.Enabled = true;
            txtprove.Enabled = true;
            txttelefono.Enabled = true;
            txtdistri.Enabled = true;
            txtdirecc.Enabled = true;

            txtedi.Focus();

            bmodificar.Visible = false;
            bactualizar.Visible = true;

            usuario_modificar = txtedi.Text.ToString();
        }

        private void bactualizar_Click(object sender, EventArgs e)
        {

            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);



                string usu = txtedi.Text.ToString();
                string cla = txtprove.Text.ToString();
                string con = txttelefono.Text.ToString();
                string dir = txtdistri.Text.ToString();
                string ide = txtdirecc.Text.ToString();

                string myInsertQuery = "UPDATE tproveedores SET ideditorialpro = '" + usu + "', nombrepro = '" + cla + "', direccionpro = '" + con + "', telefonopro = '" + dir + "', nomdistribuidorapro	 = '" + ide + "' WHERE  ideditorialpro = '" + usuario_modificar + "'";

                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                MessageBox.Show("Usuario modificado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string consulta = "select * from tproveedores";

                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "biblioteca");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "biblioteca";

            }
            catch (MySqlException)
            {
                MessageBox.Show("Error al modificar el usuario", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            bmodificar.Visible = true;
            bactualizar.Visible = false;

            //Desabilitar campos, se activan al crear nuevo registro
            txtedi.Enabled = false;
            txtprove.Enabled = false;
            txttelefono.Enabled = false;
            txtdistri.Enabled = false;
            txtdirecc.Enabled = false;
            bbuscar.Enabled = false;
            txtedi.Text = "";
            txtprove.Text = "";
            txttelefono.Text = "";
            txtdistri.Text = "";
            txtdirecc.Text = "";
            bmodificar.Focus();
        }

        private void bbuscar_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                try
                {
                    MySqlConnection myConnection = new MySqlConnection(cadena_conexion);
                    string myInsertQuery = ("select * from tproveedores Where idproveedor = '" + txtbuscar.Text + "'");
                    MySqlCommand myCommand = new MySqlCommand(myInsertQuery, myConnection);
                    myCommand.Connection = myConnection;
                    myConnection.Open();
                    MySqlDataReader myReader;
                    myReader = myCommand.ExecuteReader();
                    if (myReader.Read() == true)
                    {
                        txtedi.Text = (myReader.GetString(1));
                        txtprove.Text = (myReader.GetString(2));
                        txtdirecc.Text = (myReader.GetString(3));
                        txtdistri.Text = (myReader.GetString(5));
                        txttelefono.Text = (myReader.GetString(4));
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
                    string myInsertQuery = ("select * from tproveedores Where nombrepro = '" + txtbuscar.Text + "'");
                    MySqlCommand myCommand = new MySqlCommand(myInsertQuery, myConnection);
                    myCommand.Connection = myConnection;
                    myConnection.Open();
                    MySqlDataReader myReader;
                    myReader = myCommand.ExecuteReader();
                    if (myReader.Read() == true)
                    {

                        txtedi.Text = (myReader.GetString(1));
                        txtprove.Text = (myReader.GetString(2));
                        txtdirecc.Text = (myReader.GetString(3));
                        txtdistri.Text = (myReader.GetString(5));
                        txttelefono.Text = (myReader.GetString(4));

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

        private void beliminar_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                string myInsertQuery = "delete from tproveedores Where idproveedor = " + txtbuscar.Text + "";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                MessageBox.Show("Usuario eliminado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);


                string consulta = "select * from tproveedores";

                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "biblioteca");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "biblioteca";

            }
            catch (MySqlException)
            {
                MessageBox.Show("Error al eliminar el usuario, primero realice búsqueda del usuario y después puede eliminar.", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            bnuevo.Visible = true;
            bguardar.Visible = false;

            //Desabilitar campos, se activan al crear nuevo registro

            txtedi.Enabled = false;
            txtprove.Enabled = false;
            txttelefono.Enabled = false;
            txtdistri.Enabled = false;
            txtdirecc.Enabled = false;
            txtedi.Text = "";
            txtprove.Text = "";
            txttelefono.Text = "";
            txtdistri.Text = "";
            txtdirecc.Text = "";
            bbuscar.Enabled = false;
            txtbuscar.Focus();


        
    }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            bbuscar.Enabled = true;
        }

        private void rnombre_CheckedChanged(object sender, EventArgs e)
        {
            bbuscar.Enabled = true;
        }

        private void txtedi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

    
    

