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
    public partial class agregarempleados : Form
    {
        //Variables globales
        public string cadena_conexion = "server=localhost;user id=biblioteca;password=trejo1090;persistsecurityinfo=True;database=biblioteca";
        
        //Estas variables pueden ir en el boton que corresponde
        //Pero es mas efectivo que sean publicas globales
        public string usuario_modificar;
        public string usuario_eliminar;
        public agregarempleados()
        {
            InitializeComponent();
        }

        private void bcerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void agregarempleados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaDataSet.tpuestos' Puede moverla o quitarla según sea necesario.
            this.tpuestosTableAdapter.Fill(this.bibliotecaDataSet.tpuestos);
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaDataSet.templeados' Puede moverla o quitarla según sea necesario.
            this.templeadosTableAdapter.Fill(this.bibliotecaDataSet.templeados);
           
            //Desabilitar campos, se activan al crear nuevo registro
            txtnom.Enabled = false;
            txtcorreo.Enabled = false;
            txtdirec.Enabled = false;
            txtgenero.Enabled = false;
            txttelefono.Enabled = false;
            txtpuesto.Enabled = false;
            txtdui.Enabled = false;
            txtis.Enabled = false;
            txtafp.Enabled = false;
            txtobser.Enabled = false;

            //txtnivel.Enabled = false;

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

        private void bnuevo_Click(object sender, EventArgs e)
        {
         
            txtnom.Enabled = true;
            txtcorreo.Enabled = true;
            txtdirec.Enabled = true;
            txtgenero.Enabled = true;
            txttelefono.Enabled = true;
            txtpuesto.Enabled = true;
            txtdui.Enabled = true;
            txtis.Enabled = true;
            txtafp.Enabled = true;
            txtobser.Enabled = true;

            txtnom.Text = "";
            txtcorreo.Text = "";
            txtdirec.Text = "";
            txtgenero.Text = "Seleccione";
            txttelefono.Text = "";
            txtpuesto.Text = "Seleccione";
            txtdui.Text = "";
            txtis.Text = "";
            txtafp.Text = "";
            txtobser.Text = "";

            txtnom.Focus();
            bnuevo.Visible = false;
            bguardar.Visible = true;
        }

        private void bguardar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                string myInsertQuery = "INSERT INTO templeados(nombreem,telefonoem,correoem,generoem,duiem,isssem,direccionem,afpem,idpuestoem,observacionesem) Values(?nombreem,?telefonoem,?correoem,?generoem,?duiem,?isssem,?direccionem,?afpem,?idpuestoem,?observacionesem)";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);


                myCommand.Parameters.Add("?nombreem", MySqlDbType.VarChar, 50).Value = txtnom.Text;
                myCommand.Parameters.Add("?telefonoem", MySqlDbType.VarChar, 15).Value = txttelefono.Text;
                myCommand.Parameters.Add("?generoem", MySqlDbType.VarChar, 15).Value = txtgenero.Text;
                myCommand.Parameters.Add("?duiem", MySqlDbType.VarChar, 150).Value = txtdui.Text;
                myCommand.Parameters.Add("?isssem", MySqlDbType.VarChar, 50).Value = txtis.Text;
                myCommand.Parameters.Add("?direccionem", MySqlDbType.VarChar, 50).Value = txtdirec.Text;
                myCommand.Parameters.Add("?afpem", MySqlDbType.VarChar, 15).Value = txtafp.Text;
                myCommand.Parameters.Add("?idpuestoem", MySqlDbType.VarChar, 50).Value = txtpuesto.Text;
                myCommand.Parameters.Add("?correoem", MySqlDbType.VarChar, 150).Value = txtcorreo.Text;
                myCommand.Parameters.Add("?observacionesem", MySqlDbType.VarChar, 150).Value = txtcorreo.Text;

                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                MessageBox.Show("Usuario agregado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string consulta = "select * from templeados";

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
            txtnom.Enabled = false;
            txtcorreo.Enabled = false;
            txtdirec.Enabled = false;
            txtgenero.Enabled = false;
            txttelefono.Enabled = false;
            txtpuesto.Enabled = false;
            txtdui.Enabled = false;
            txtis.Enabled = false;
            txtafp.Enabled = false;
            txtobser.Enabled = false;
            txtnom.Text = "";
            txtcorreo.Text = "";
            txtdirec.Text = "";
            txtgenero.Text = "  Seleccione ";
            txttelefono.Text = "";
            txtpuesto.Text = "Seleccione";
            txtdui.Text = "";
            txtis.Text = "";
            txtafp.Text = "";
            txtobser.Text = "";
            bnuevo.Focus();
        }

        private void bmodificar_Click(object sender, EventArgs e)
        {
            txtnom.Enabled = true;
            txtcorreo.Enabled = true;
            txtdirec.Enabled = true;
            txtgenero.Enabled = true;
            txttelefono.Enabled = true;
            txtpuesto.Enabled = true;
            txtdui.Enabled = true;
            txtis.Enabled = true;
            txtafp.Enabled = true;
            txtobser.Enabled = true;
            txtnom.Focus();
            bmodificar.Visible = false;
            bactualizar.Visible = true;

            usuario_modificar = txtnom.Text.ToString();
        }

        private void bactualizar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                string no = txtnom.Text.ToString();
                string co = txtcorreo.Text.ToString();
                string di = txtdirec.Text.ToString();
                string ge = txtgenero.Text.ToString();
                string te = txttelefono.Text.ToString();
                string pu = txtpuesto.Text.ToString();
                string du = txtdui.Text.ToString();
                string ti = txtis.Text.ToString();
                string af = txtafp.Text.ToString();
                string ob = txtobser.Text.ToString();


                //string myInsertQuery = "UPDATE templeados SET nombreusu = '" + usu + "', claveusu = '" + cla + "', contactousu = '" + con + "', direccionusu = '" + dir + "', identificadorusu = '" + ide + "' WHERE  nombreusu = '" + usuario_modificar + "'";
                string myInsertQuery = "UPDATE templeados SET nombreem = '" + no + "',telefonoem = '" + te + "',correoem = '" + co + "',generoem = '" + ge + "',duiem = '" + du + "',isssem = '" + ti + "',direccionem = '" + di + "',afpem = '" + af + "',idpuestoem= '" + pu + "', observaciones '" + ob+ "' WHERE  nombreem = '" + usuario_modificar + "'";


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

                string consulta = "select * from templeados";

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
            txtnom.Enabled = false;
            txtcorreo.Enabled = false;
            txtdirec.Enabled = false;
            txtgenero.Enabled = false;
            txttelefono.Enabled = false;
            txtpuesto.Enabled = false;
            txtdui.Enabled = false;
            txtis.Enabled = false;
            txtafp.Enabled = false;
            txtobser.Enabled = false;
            txtnom.Text = "";
            txtcorreo.Text = "";
            txtdirec.Text = "";
            txtgenero.Text = "Seleccione";
            txttelefono.Text = "";
            txtpuesto.Text = "";
            txtdui.Text = "";
            txtis.Text = "";
            txtafp.Text = "";
            txtobser.Text = "";
            bmodificar.Focus();
        }

        private void beliminar_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                string myInsertQuery = "delete from templeados Where idempleado= " + txtbuscar.Text + "";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                MessageBox.Show("Usuario eliminado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);


                string consulta = "select * from templeados";

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

            txtnom.Enabled = false;
            txtcorreo.Enabled = false;
            txtdirec.Enabled = false;
            txtgenero.Enabled = false;
            txttelefono.Enabled = false;
            txtpuesto.Enabled = false;
            txtdui.Enabled = false;
            txtis.Enabled = false;
            txtafp.Enabled = false;
            txtobser.Enabled = false;
            txtnom.Text = "";
            txtcorreo.Text = "";
            txtdirec.Text = "";
            txtgenero.Text = "Seleccione";
            txttelefono.Text = "";
            txtpuesto.Text = "Seleccione";
            txtdui.Text = "";
            txtis.Text = "";
            txtafp.Text = "";
            txtobser.Text = "";

            txtbuscar.Focus();


        }
    

        private void bbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);
                myConnection.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = myConnection;
                comando.CommandText = ("select * from templeados Where 	idempleado = " + txtbuscar.Text + "");
                MySqlDataReader leer = comando.ExecuteReader();
                if (leer.Read() == true)
                {

                    txtnom.Text = leer["nombreem"].ToString();
                    txttelefono.Text = leer["telefonoem"].ToString();
                    txtcorreo.Text = leer["correoem"].ToString();
                    txtgenero.Text = leer["generoem"].ToString(); ;
                    txtdui.Text = leer["duiem"].ToString();
                    txtis.Text = leer["isssem"].ToString();
                    txtdirec.Text = leer["direccionem"].ToString();
                    txtafp.Text = leer["afpem"].ToString();
                    txtpuesto.Text = leer["idpuestoem"].ToString();
                    txtobser.Text = leer["observacionesem"].ToString();
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

        private void txtgenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }
    
  