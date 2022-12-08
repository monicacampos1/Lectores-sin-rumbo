using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Practica_semana_10
{
    public partial class presta1 : Form

    {

        //Variables globales
        public string cadena_conexion = "server=localhost;user id=biblioteca;password=trejo1090;database=biblioteca";

        //Estas variables pueden ir en el boton que corresponde
        //Pero es mas efectivo que sean publicas globales
        public string usuario_modificar;
        public string usuario_eliminar;

        public presta1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaDataSet.tprestamos' Puede moverla o quitarla según sea necesario.
            this.tprestamosTableAdapter.Fill(this.bibliotecaDataSet.tprestamos);

            bbuscar.Enabled = false;

            //Desabilitar campos, se activan al crear nuevo registro
            txtusu.Enabled = false;
            txtidli.Enabled = false;
            txtlibro.Enabled = false;
            txtfecha.Enabled = false;
            txtdevo.Enabled = false;
            txtempleado.Enabled = false;
            txtobser.Enabled = false;

            //txtnivel.Enabled = false;

            try
            {

                string consulta = "select * from tprestamos";

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
            txtusu.Enabled = true;
            txtidli.Enabled = true;
            txtlibro.Enabled = true;
            txtfecha.Enabled = true;
            txtdevo.Enabled = true;
            txtempleado.Enabled = true;
            txtobser.Enabled = true;

            txtusu.Text = "";
            txtidli.Text = "";
            txtlibro.Text = "";
            txtfecha.Text = "";
            txtdevo.Text = "";
            txtempleado.Text = "";
            txtobser.Text = "";

            bnuevo.Visible = false;
            bguardar.Visible = true;
        }

        private void bguardar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                string myInsertQuery = "INSERT INTO tprestamos(idusup, nombrelip, idlibrop, fentregap, fdevolucionp, idempleadop,observacionesp) Values(?idusup,?nombrelip,?idlibrop,?fentregap,?fdevolucionp,?idempleadop,?observacionesp)";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

        
                //idusup, nombrelip, idlibrop, fentregap, fdevolucionp, idempleadop,observacionesp
                myCommand.Parameters.Add("?idusup", MySqlDbType.VarChar, 50).Value = txtusu.Text;
                myCommand.Parameters.Add("?nombrelip", MySqlDbType.VarChar, 150).Value = txtlibro.Text;
                myCommand.Parameters.Add("?idlibrop", MySqlDbType.VarChar, 15).Value = txtidli.Text;
                myCommand.Parameters.Add("?fentregap", MySqlDbType.VarChar, 20).Value = txtfecha.Text;
                myCommand.Parameters.Add("?fdevolucionp", MySqlDbType.VarChar, 20).Value = txtdevo.Text;
                myCommand.Parameters.Add("?idempleadop", MySqlDbType.VarChar, 50).Value = txtempleado.Text;
                myCommand.Parameters.Add("?observacionesp", MySqlDbType.VarChar, 150).Value = txtobser.Text;

                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                MessageBox.Show("Usuario agregado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string consulta = "select * from tprestamos";

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

            txtusu.Enabled = true;
            txtidli.Enabled = true;
            txtlibro.Enabled = true;
            txtfecha.Enabled = true;
            txtdevo.Enabled = true;
            txtempleado.Enabled = true;
            txtobser.Enabled = true;

            txtusu.Text = "";
            txtidli.Text = "";
            txtlibro.Text = "";
            txtfecha.Text = "";
            txtdevo.Text = "";
            txtempleado.Text = "";
            txtobser.Text = "";

            bnuevo.Focus();
        }

        private void beliminar_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                string myInsertQuery = "delete from tprestamos Where idprestamo = " + txtbuscar.Text + "";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                MessageBox.Show("Usuario eliminado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);


                string consulta = "select * from tprestamos ";

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
            txtidli.Enabled = false;
            txtlibro.Enabled = false;
            txtfecha.Enabled = false;
            txtdevo.Enabled = false;
            txtempleado.Enabled = false;
            txtobser.Enabled = false;
            txtusu.Text = "";
            txtidli.Text = "";
            txtlibro.Text = "";
            txtfecha.Text = "";
            txtdevo.Text = "";
            txtempleado.Text = "";
            txtobser.Text = "";
            txtbuscar.Focus();
            bbuscar.Enabled = false;

        }

        private void bmodificar_Click(object sender, EventArgs e)
        {
            bbuscar.Enabled = false;
            txtusu.Enabled = true;
            txtidli.Enabled = true;
            txtlibro.Enabled = true;
            txtfecha.Enabled = true;
            txtdevo.Enabled = true;
            txtempleado.Enabled = true;
            txtobser.Enabled = true;
            radioButton1.Checked = false;

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



                string usu = txtusu.Text.ToString();
                string cla = txtidli.Text.ToString();
                string con = txtlibro.Text.ToString();
                string dir = txtfecha.Text.ToString();
                string ide = txtdevo.Text.ToString();
                string em = txtempleado.Text.ToString();
                string ob = txtobser.Text.ToString();



                //Hay dos formas de pasar los valores

                //Primera forma de pasar los valores
                //string myInsertQuery = "UPDATE usuarios SET nombre = ?nombre, clave = ?clave, nivel = ?nivel Where nombre = " + usuario_modificar + "";

                //Segunda forma de pasar los valores, usaremos esto
                string myInsertQuery = "UPDATE tprestamos SET idusup = '" + usu + "', nombrelip = '" + con + "', idlibrop = '" + cla + "', fentregap = '" + dir + "', fdevolucionp = '" + ide + "', idempleadop = '" + em + "', observacionesp = '" + ob + "'WHERE  idusup = '" + usuario_modificar + "'";

                //idusup	nombrelip	idlibrop	fentregap	fdevolucionp	idempleadop	



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

                string consulta = "select * from tprestamos";

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
            txtidli.Enabled = false;
            txtlibro.Enabled = false;
            txtfecha.Enabled = false;
            txtdevo.Enabled = false;
            txtempleado.Enabled = false;
            txtobser.Enabled = false;
            bbuscar.Enabled = false;
            bmodificar.Focus();
        }

        private void bcerrar_Click(object sender, EventArgs e)
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
                    string myInsertQuery = ("select * from tprestamos Where idprestamo = '" + txtbuscar.Text + "'");
                    MySqlCommand myCommand = new MySqlCommand(myInsertQuery, myConnection);
                    myCommand.Connection = myConnection;
                    myConnection.Open();
                    MySqlDataReader myReader;
                    myReader = myCommand.ExecuteReader();
                    if (myReader.Read() == true)
                    {
                        txtdevo.Text = (myReader.GetString(5));
                        txtlibro.Text = (myReader.GetString(2));
                        txtempleado.Text = (myReader.GetString(6));
                        txtfecha.Text = (myReader.GetString(4));
                        txtidli.Text = (myReader.GetString(3));
                        txtobser.Text = (myReader.GetString(7));
                        txtusu.Text = (myReader.GetString(1));
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
                            string myInsertQuery = ("select * from tprestamos Where nombrelip = '" + txtbuscar.Text + "'");
                            MySqlCommand myCommand = new MySqlCommand(myInsertQuery, myConnection);
                            myCommand.Connection = myConnection;
                            myConnection.Open();
                            MySqlDataReader myReader;
                            myReader = myCommand.ExecuteReader();
                            if (myReader.Read() == true)
                            {

                                txtdevo.Text = (myReader.GetString(5));
                                txtlibro.Text = (myReader.GetString(2));
                                txtempleado.Text = (myReader.GetString(6));
                                txtfecha.Text = (myReader.GetString(4));
                                txtidli.Text = (myReader.GetString(3));
                                txtobser.Text = (myReader.GetString(7));
                                txtusu.Text = (myReader.GetString(1));

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
    
    
    

