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
    public partial class agregarautores : Form
    {
        //Variables globales
        public string cadena_conexion = "server=localhost;user id=biblioteca;password=trejo1090;database=biblioteca";

        //Estas variables pueden ir en el boton que corresponde
        //Pero es mas efectivo que sean publicas globales
        public string usuario_modificar;
        public string usuario_eliminar;

        public agregarautores()
        {
            InitializeComponent();
        }

        private void bcerrar_Click(object sender, EventArgs e)
        {
            Close(); 
        }


        private void agregarautores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaDataSet.tautor' Puede moverla o quitarla según sea necesario.
            this.tautorTableAdapter.Fill(this.bibliotecaDataSet.tautor);
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaDataSet3.tautor' Puede moverla o quitarla según sea necesario.
            //this.tautorTableAdapter.Fill(this.bibliotecaDataSet3.tautor);
            bbuscar.Enabled = false;

            //Desabilitar campos, se activan al crear nuevo registro

            textnon.Enabled = false;
            txtfa.Enabled = false;
            txtna.Enabled = false;
            txtgenelite.Enabled = false;
            txtpais.Enabled = false;
            txtobser.Enabled = false;
            
            //txtnivel.Enabled = false;

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

        private void bnuevo_Click(object sender, EventArgs e)
        {
            bbuscar.Enabled = false;
            textnon.Enabled = true;
            txtna.Enabled = true;
            txtfa.Enabled = true;
            txtgenelite.Enabled = true;
            txtpais.Enabled = true;
            txtobser.Enabled = true;

            textnon.Text = "";
            txtfa.Text = "";
            txtna.Text = "";
            txtgenelite.Text = " Seleccione ";
            txtpais.Text = " Seleccione ";
            txtobser.Text = "";

            bnuevo.Visible = false;
            bguardar.Visible = true;
        }

        private void bguardar_Click(object sender, EventArgs e)
        {
            bbuscar.Enabled = false;
            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                string myInsertQuery = "INSERT INTO tautor(nombreau,paisau,fechnaciau,fechmuerau,observacionesau,generoau) Values(?nombreau,?paisau,?fechnaciau,?fechmuerau,?observacionesau,?generoau)";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);


                myCommand.Parameters.Add("?nombreau", MySqlDbType.VarChar, 50).Value = textnon.Text;
                myCommand.Parameters.Add("?paisau", MySqlDbType.VarChar, 20).Value = txtpais.Text;
                myCommand.Parameters.Add("?fechnaciau", MySqlDbType.VarChar, 20).Value = txtna.Text;
                myCommand.Parameters.Add("?fechmuerau", MySqlDbType.VarChar, 20).Value = txtfa.Text;
                myCommand.Parameters.Add("?observacionesau", MySqlDbType.VarChar,200).Value = txtobser.Text;
                myCommand.Parameters.Add("?generoau", MySqlDbType.VarChar,50).Value = txtgenelite.Text;

                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                MessageBox.Show("Usuario agregado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string consulta = "select * from tautor";

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
            textnon.Enabled = false;
            txtna.Enabled = false;
            txtfa.Enabled = false;
            txtgenelite.Enabled = false;
            txtpais.Enabled = false;
            txtobser.Enabled = false;
            textnon.Text = "";
            txtna.Text = "";
            txtfa.Text = "";
            txtgenelite.Text = " Seleccione ";
            txtpais.Text = " Seleccione ";
            txtobser.Text = "";
            bnuevo.Focus();
        }

        private void bmodificar_Click(object sender, EventArgs e)
        {
            bbuscar.Enabled = false;
            textnon.Enabled = true;
            txtfa.Enabled = true;
            txtna.Enabled = true;
            txtgenelite.Enabled = true;
            txtpais.Enabled = true;
            txtobser.Enabled = true;
            textnon.Focus();

            bmodificar.Visible = false;
            bactualizar.Visible = true;

            usuario_modificar = textnon.Text.ToString();
        }

        private void bactualizar_Click(object sender, EventArgs e)
        {
            bbuscar.Enabled = false ;

            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                string nom = textnon.Text.ToString();
                string di = txtna.Text.ToString();
                string conta =txtfa.Text.ToString();
                string pa = txtpais.Text.ToString();
                string co = txtgenelite.Text.ToString();
                string ob = txtobser.Text.ToString();

                string myInsertQuery = "UPDATE tautor SET nombreau = '" + nom + "', paisau = '" + pa + "', fechnaciau = '" + conta + "', fechmuerau = '" + di + "', observacionesau = '" + ob + "',generoau= '" + co + "' WHERE nombreau = '" + usuario_modificar + "'";
                //nombree, direccione,contactose,paise,correoe
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                MessageBox.Show("Usuario modificado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string consulta = "select * from tautor";

                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "biblioteca");
                dataGridView1.DataSource = ds;
                //dataGridView1.DataMember = " biblioteca";

            }
            catch (MySqlException)
            {
                MessageBox.Show("Error al modificar el usuario", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            bmodificar.Visible = true;
            bactualizar.Visible = false;

            //Desabilitar campos, se activan al crear nuevo registro

            textnon.Enabled = false;
            txtfa.Enabled = false;
            txtna.Enabled = false;
            txtgenelite.Enabled = false;
            txtpais.Enabled = false;
            txtobser.Enabled = false;
            textnon.Text = "";
            txtna.Text = "";
            txtfa.Text = "";
            txtgenelite.Text = " Seleccione ";
            txtpais.Text = " Seleccione ";
            txtobser.Text = "";

            bmodificar.Focus();
        }

        private void bbuscar_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true)
            {
                try
                {
                    MySqlConnection myConnection = new MySqlConnection(cadena_conexion);
                    string myInsertQuery = ("select * from tautor Where idautor = '" + txtbuscar.Text + "'");
                    MySqlCommand myCommand = new MySqlCommand(myInsertQuery, myConnection);
                    myCommand.Connection = myConnection;
                    myConnection.Open();
                    MySqlDataReader myReader;
                    myReader = myCommand.ExecuteReader();
                    if (myReader.Read() == true)
                    {
                        textnon.Text = (myReader.GetString(1));
                        txtfa.Text = (myReader.GetString(4));
                        txtna.Text = (myReader.GetString(3));
                        txtgenelite.Text = (myReader.GetString(6));
                        txtpais.Text = (myReader.GetString(2));
                        txtobser.Text = (myReader.GetString(5));
                        

                       
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
                    string myInsertQuery = ("select * from tautor Where nombreau = '" + txtbuscar.Text + "'");
                    MySqlCommand myCommand = new MySqlCommand(myInsertQuery, myConnection);
                    myCommand.Connection = myConnection;
                    myConnection.Open();
                    MySqlDataReader myReader;
                    myReader = myCommand.ExecuteReader();
                    if (myReader.Read() == true)
                    {


                        textnon.Text = (myReader.GetString(1));
                        txtfa.Text = (myReader.GetString(4));
                        txtna.Text = (myReader.GetString(3));
                        txtgenelite.Text = (myReader.GetString(6));
                        txtpais.Text = (myReader.GetString(2));
                        txtobser.Text = (myReader.GetString(5));


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
            bbuscar.Enabled = false;
            try
            {

                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                string myInsertQuery = "delete from tautor Where idautor = " + txtbuscar.Text + "";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                MessageBox.Show("Usuario eliminado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);


                string consulta = "select * from tautor";

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

            textnon.Enabled = false;
            txtfa.Enabled = false;
            txtna.Enabled = false;
            txtgenelite.Enabled = false;
            txtpais.Enabled = false;
            txtobser.Enabled = false;


            textnon.Text = "";
            txtna.Text = "";
            txtfa.Text = "";
            txtgenelite.Text = "Seleccione ";
            txtpais.Text = " Seleccione ";
            radioButton1.Checked = false;

            txtobser.Text = "";
            txtbuscar.Focus();

        }

        private void tautorBindingSource_CurrentChanged(object sender, EventArgs e)
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
    }
    }
  
