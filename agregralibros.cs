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
    public partial class agregralibros : Form
    {

        //Variables globales
        public string cadena_conexion = " server=localhost;user id=biblioteca;password=trejo1090;persistsecurityinfo=True;database=biblioteca";
        DataTable datos = new DataTable (); 

        //Estas variables pueden ir en el boton que corresponde
        //Pero es mas efectivo que sean publicas globales
        public string usuario_modificar;
        public string usuario_eliminar;

        public agregralibros()
        {
            InitializeComponent();
        }

        private void bcerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void agregralibros_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaDataSet.teditoriales' Puede moverla o quitarla según sea necesario.
            this.teditorialesTableAdapter.Fill(this.bibliotecaDataSet.teditoriales);
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaDataSet.tautor' Puede moverla o quitarla según sea necesario.
            this.tautorTableAdapter.Fill(this.bibliotecaDataSet.tautor);
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaDataSet.tlibros' Puede moverla o quitarla según sea necesario.
            this.tlibrosTableAdapter.Fill(this.bibliotecaDataSet.tlibros);

           
            bbuscar.Enabled = false;

            //Desabilitar campos, se activan al crear nuevo registro
            txtnom.Enabled = false;
            txtedi.Enabled = false;
            txtdis.Enabled = false;
            txtibs.Enabled = false;
            txtobser.Enabled = false;
            txtautor.Enabled = false;
            txtcate.Enabled = false;
            txtestante.Enabled = false;
            txtidioma.Enabled = false;

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

        private void bnuevo_Click(object sender, EventArgs e)
        {
          
            txtnom.Enabled = true;
            txtedi.Enabled = true;
            txtdis.Enabled = true;
            txtibs.Enabled = true;
            txtobser.Enabled = true;
            txtautor.Enabled = true;
            txtcate.Enabled = true;
            txtestante.Enabled = true;
            txtidioma.Enabled = true;
            txtnom.Text = "";
            txtedi.Text = "";
            txtdis.Text = "";
            txtibs.Text = "";
            txtobser.Text = "";
            txtautor.Text = ""; ;
            txtcate.Text = "";
            txtestante.Text = "";
            txtidioma.Text = "Seleccione el idioma ";

            bnuevo.Visible = false;
            bguardar.Visible = true;
        }

        private void bguardar_Click(object sender, EventArgs e)
        {

            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                string myInsertQuery = " INSERT INTO tlibros ( nombreli, autorli, editorialli ,categoriali ,estanteli, disponiblesli, isbmli, idiomali, observacionesli)Values(?nombreli, ?autorli, ?editorialli, ?categoriali, ?estanteli, ?disponiblesli, ?isbmli, ?idiomali, ?observacionesli)";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
               

                myCommand.Parameters.Add("?nombreli", MySqlDbType.VarChar, 50).Value = txtnom.Text;
                myCommand.Parameters.Add("?autorli", MySqlDbType.VarChar, 50).Value = txtautor.Text;
                myCommand.Parameters.Add("?editorialli", MySqlDbType.VarChar, 50).Value = txtedi.Text;
                myCommand.Parameters.Add("?categoriali", MySqlDbType.VarChar, 50).Value = txtcate.Text;
                myCommand.Parameters.Add("?estanteli", MySqlDbType.VarChar, 50).Value = txtestante.Text;
                myCommand.Parameters.Add("?disponiblesli", MySqlDbType.Int32, 11).Value = txtdis.Text;
                myCommand.Parameters.Add("?isbmli", MySqlDbType.VarChar, 20).Value = txtibs.Text;
                myCommand.Parameters.Add("?idiomali", MySqlDbType.VarChar, 20).Value = txtidioma.Text;
                myCommand.Parameters.Add("?observacionesli", MySqlDbType.VarChar, 150).Value = txtobser.Text;

                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                MessageBox.Show("Libro agregado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string consulta = "select * from tlibros";

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
            txtedi.Enabled = false;
            txtdis.Enabled = false;
            txtibs.Enabled = false;
            txtobser.Enabled = false;
            txtautor.Enabled = false;
            txtcate.Enabled = false;
            txtestante.Enabled = false;
            txtidioma.Enabled = false;
            bbuscar.Enabled = false;
            txtnom.Text = "";
            txtedi.Text = "";
            txtdis.Text = "";
            txtibs.Text = "";
            txtobser.Text = "";
            txtautor.Text = ""; ;
            txtcate.Text = "";
            txtestante.Text = "";
            txtidioma.Text = "Seleccione el idioma ";
            bnuevo.Focus();
        }

        private void bmodificar_Click(object sender, EventArgs e)
        {
            bbuscar.Enabled = false;
            txtnom.Enabled = true;
            txtedi.Enabled = true;
            txtdis.Enabled = true;
            txtibs.Enabled = true;
            txtobser.Enabled = true;
            txtautor.Enabled = true;
            txtcate.Enabled = true;
            txtestante.Enabled = true;
            txtidioma.Enabled = true;
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

                string myInsertQuery = "UPDATE tlibros SET nombreli = ?nombreli, autorli = ?autorli, editorialli = ?editorialli ,categoriali = ?categoriali ,estanteli = ?estanteli, disponiblesli = ?disponiblesli, isbmli = ?isbmli, idiomali = ?idiomali, observacionesli = ?observacionesli  Where nombreli = " + usuario_modificar + ""; 
                //string myInsertQuery = "UPDATE usuarios SET nombre = ?nombre, clave = ?clave, nivel = ?nivel Where nombre = " + usuario_modificar + "";


                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);


                myCommand.Parameters.Add("?nombreli", MySqlDbType.VarChar, 50).Value = txtnom.Text;
                myCommand.Parameters.Add("?autorli", MySqlDbType.VarChar, 50).Value = txtautor.Text;
                myCommand.Parameters.Add("?editorialli", MySqlDbType.VarChar, 50).Value = txtedi.Text;
                myCommand.Parameters.Add("?categoriali", MySqlDbType.VarChar, 50).Value = txtcate.Text;
                myCommand.Parameters.Add("?estanteli", MySqlDbType.VarChar, 50).Value = txtestante.Text;
                myCommand.Parameters.Add("?disponiblesli", MySqlDbType.Int32, 11).Value = txtdis.Text;
                myCommand.Parameters.Add("?isbmli", MySqlDbType.VarChar, 20).Value = txtibs.Text;
                myCommand.Parameters.Add("?idiomali", MySqlDbType.VarChar, 20).Value = txtidioma.Text;
                myCommand.Parameters.Add("?observacionesli", MySqlDbType.VarChar, 150).Value = txtobser.Text;

                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                MessageBox.Show("Usuario modificado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string consulta = "select * from tlibros";

                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "biblioteca");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = " biblioteca";

            }
            catch (MySqlException)
            {
                MessageBox.Show("Error al modificar el usuario", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            bmodificar.Visible = true;
            bactualizar.Visible = false;

            //Desabilitar campos, se activan al crear nuevo registro

            bbuscar.Enabled = false;
            txtnom.Enabled = false;
            txtedi.Enabled = false;
            txtdis.Enabled = false;
            txtibs.Enabled = false;
            txtobser.Enabled = false;
            txtautor.Enabled = false;
            txtcate.Enabled = false;
            txtestante.Enabled = false;
            txtidioma.Enabled = false;

            txtnom.Text = "";
            txtedi.Text = "";
            txtdis.Text = "";
            txtibs.Text = "";
            txtobser.Text = "";
            txtautor.Text = ""; ;
            txtcate.Text = "";
            txtestante.Text = "";
            txtidioma.Text = " Seleccione el idioma ";

            bmodificar.Focus();
        }

    
    private void bbuscar_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                try
                {
                    MySqlConnection myConnection = new MySqlConnection(cadena_conexion);
                    string myInsertQuery = ("select * from tlibros Where idlibro= '" + txtbuscar.Text + "'");
                    MySqlCommand myCommand = new MySqlCommand(myInsertQuery, myConnection);
                    myCommand.Connection = myConnection;
                    myConnection.Open();
                    MySqlDataReader myReader;
                    myReader = myCommand.ExecuteReader();
                    if (myReader.Read() == true)
                    {


                        txtnom.Text = (myReader.GetString(1));
                        txtedi.Text = (myReader.GetString(3));
                        txtdis.Text = (myReader.GetString(6));
                        txtibs.Text = (myReader.GetString(7));
                        txtobser.Text = (myReader.GetString(9));
                        txtautor.Text = (myReader.GetString(2));
                        txtcate.Text = (myReader.GetString(4));
                        txtestante.Text = (myReader.GetString(5));
                        txtidioma.Text = (myReader.GetString(8));
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

                        txtnom.Text = (myReader.GetString(1));
                        txtedi.Text = (myReader.GetString(3));
                        txtdis.Text = (myReader.GetString(6));
                        txtibs.Text = (myReader.GetString(7));
                        txtobser.Text = (myReader.GetString(9));
                        txtautor.Text = (myReader.GetString(2));
                        txtcate.Text = (myReader.GetString(4));
                        txtestante.Text = (myReader.GetString(5));
                        txtidioma.Text = (myReader.GetString(8));

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

        private void beliminar_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                string myInsertQuery = " delete from tlibros Where idlibro = " + txtbuscar.Text + "";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                MessageBox.Show("Usuario eliminado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);


                string consulta = "select * from tlibros";

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

            bbuscar.Enabled = false;
            txtnom.Enabled = false;
            txtedi.Enabled = false;
            txtdis.Enabled = false;
            txtibs.Enabled = false;
            txtobser.Enabled = false;
            txtautor.Enabled = false;
            txtcate.Enabled = false;
            txtestante.Enabled = false;
            txtidioma.Enabled = false;
            txtnom.Text = "";
            txtedi.Text = "";
            txtdis.Text = "";
            txtibs.Text = "";
            txtobser.Text = "";
            txtautor.Text = ""; ;
            txtcate.Text = "";
            txtestante.Text = "";
            txtidioma.Text = " Seleccione el idioma ";
            txtbuscar.Focus();


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            bbuscar.Enabled = true;
        }

        private void rnombre_CheckedChanged(object sender, EventArgs e)
        {
            bbuscar.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide(); 
        }
    }
}






