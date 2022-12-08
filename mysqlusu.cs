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
    public partial class mysqlusu : Form
    {

        //Variables globales
        public string cadena_conexion = "server=localhost;user id=biblioteca;password=trejo1090;persistsecurityinfo=True;database=biblioteca";

        //Estas variables pueden ir en el boton que corresponde
        //Pero es mas efectivo que sean publicas globales
        public string usuario_modificar;
        public string usuario_eliminar;

        public mysqlusu()
        {
            InitializeComponent();
        }

        private void bcerrar_Click(object sender, EventArgs e)
        {
            flogin ven = new flogin();
            ven.Show();
            Close ();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void mysqlusu_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaDataSet.tusuarios' Puede moverla o quitarla según sea necesario.
            this.tusuariosTableAdapter.Fill(this.bibliotecaDataSet.tusuarios);

            //Desabilitar campos, se activan al crear nuevo registro
            txtusu.Enabled = false;
            txtclave.Enabled = false;
            txtcontac.Enabled = false;
            txtdirec.Enabled = false;
            txtiden.Enabled = false;
            //txtnivel.Enabled = false;

            try
            {

                string consulta = "select * from tusuarios";

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
         
          
            txtusu.Enabled = true;
            txtclave.Enabled = true;
            txtcontac.Enabled = true;
            txtdirec.Enabled = true;
            txtiden.Enabled = true;
            txtusu.Text = "";
            txtclave.Text = "";
            txtcontac.Text = "";
            txtdirec.Text = "";
            txtiden.Text = "";
            txtusu.Focus();
            bnuevo.Visible = false;
            bguardar.Visible = true;
        }

        private void bguardar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                string myInsertQuery = "INSERT INTO tusuarios(nombreusu,claveusu,contactousu,direccionusu,identificadorusu) Values(?nombreusu,?claveusu,?contactousu,?direccionusu,?identificadorusu)";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);


                myCommand.Parameters.Add("?nombreusu", MySqlDbType.VarChar, 50).Value = txtusu.Text;
                myCommand.Parameters.Add("?claveusu", MySqlDbType.VarChar, 15).Value = txtclave.Text;
                myCommand.Parameters.Add("?contactousu", MySqlDbType.VarChar, 15).Value = txtcontac.Text;
                myCommand.Parameters.Add("?direccionusu", MySqlDbType.VarChar, 150).Value = txtdirec.Text;
                myCommand.Parameters.Add("?identificadorusu", MySqlDbType.VarChar,50).Value = txtiden.Text;

                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                MessageBox.Show("Usuario agregado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string consulta = "select * from tusuarios";

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
            txtusu.Enabled = false;
            txtclave.Enabled = false;
            txtcontac.Enabled = false;
            txtdirec.Enabled = false;
            txtiden.Enabled = false; 
            txtusu.Text = "";
            txtclave.Text = "";
            txtcontac.Text = "";
            txtdirec.Text = "";
            txtiden.Text = "";
            bnuevo.Focus();
        }



        private void bmodificar_Click(object sender, EventArgs e)
        {

            txtusu.Enabled = true;
            txtclave.Enabled = true;
            txtcontac.Enabled = true;
            txtdirec.Enabled = true;
            txtiden.Enabled = true;

            txtusu.Focus();

            bmodificar.Visible = false;
            bactualizar.Visible = true;

            usuario_modificar = txtusu.Text.ToString();
        }

        private void bactualizar_Click(object sender, EventArgs e)
        {

            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                

                string usu =  txtusu.Text.ToString();
                string cla = txtclave.Text.ToString();
                string con = txtcontac.Text.ToString();
                string dir = txtdirec.Text.ToString();
                string ide = txtiden.Text.ToString();


                //Hay dos formas de pasar los valores

                //Primera forma de pasar los valores
                //string myInsertQuery = "UPDATE usuarios SET nombre = ?nombre, clave = ?clave, nivel = ?nivel Where nombre = " + usuario_modificar + "";

                //Segunda forma de pasar los valores, usaremos esto
                string myInsertQuery = "UPDATE tusuarios SET nombreusu = '" + usu + "', claveusu = '" + cla + "', contactousu = '" + con+ "', direccionusu = '" + dir + "', identificadorusu = '" + ide+ "' WHERE  nombreusu = '" + usuario_modificar + "'";
               


                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

                //En caso de usar primera forma, se pasan estos parámetros.
                //myCommand.Parameters.Add("?nombre", MySqlDbType.VarChar, 75).Value = txtusuario.Text;
                //myCommand.Parameters.Add("?clave", MySqlDbType.VarChar, 75).Value = txtclave.Text;
                //myCommand.Parameters.Add("?nivel", MySqlDbType.Int32, 11).Value = lstnivel.Text;

                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                MessageBox.Show("Usuario modificado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string consulta = "select * from tusuarios";

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
          
            txtusu.Enabled = false;
            txtclave.Enabled = false;
            txtcontac.Enabled = false;
            txtdirec.Enabled = false;
            txtiden.Enabled = false;
            bmodificar.Focus();
        }

        private void bbuscar_Click(object sender, EventArgs e)
        {

            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);
                myConnection.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = myConnection;
                comando.CommandText = ("select * from tusuarios Where idusuario = " + txtbuscar.Text + "");
                MySqlDataReader leer = comando.ExecuteReader();
                if (leer.Read() == true)
                {
                  
                    txtusu.Text = leer["nombreusu"].ToString();
                    txtclave.Text = leer["claveusu"].ToString();
                    txtcontac.Text = leer["contactousu"].ToString();
                    txtdirec.Text = leer["direccionusu"].ToString(); ;
                    txtiden.Text = leer["identificadorusu"].ToString();

                   

                }
                else
                {
                    MessageBox.Show("El usuario no existe", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                myConnection.Close();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Campo de busqueda está vacío", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //throw;
            }

        }

        private void beliminar_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                string myInsertQuery = "delete from tusuarios Where idusuario = " + txtbuscar.Text + "";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                MessageBox.Show("Usuario eliminado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);


                string consulta = "select * from tusuarios";

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
            
            txtusu.Enabled = false;
            txtclave.Enabled = false;
            txtcontac.Enabled = false;
            txtdirec.Enabled = false;
            txtiden.Enabled = false;
            txtusu.Text = "";
            txtclave.Text = "";
            txtcontac.Text = "";
            txtdirec.Text = "";
            txtiden.Text = "";

            txtbuscar.Focus();


        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
    }




