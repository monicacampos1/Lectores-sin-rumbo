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
    public partial class agregareditoriales : Form
    {
        //Variables globales
        public string cadena_conexion = "server=localhost;user id=biblioteca;password=trejo1090;database=biblioteca";

        //Estas variables pueden ir en el boton que corresponde
        //Pero es mas efectivo que sean publicas globales
        public string usuario_modificar;
        public string usuario_eliminar;

        public agregareditoriales()
        {
            InitializeComponent();
        }

        private void bcerrar_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void agregareditoriales_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaDataSet.teditoriales' Puede moverla o quitarla según sea necesario.
            this.teditorialesTableAdapter.Fill(this.bibliotecaDataSet.teditoriales);

            button2.Enabled = false;

            //Desabilitar campos, se activan al crear nuevo registro
            txtnome.Enabled = false;
            txtdirecc.Enabled = false;
            txtcontac.Enabled = false;
            txtpais.Enabled = false;
            txtcorreo.Enabled = false;
            //txtnivel.Enabled = false;

            try
            {

                string consulta = "select * from teditoriales";

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
            
            txtnome.Enabled = true;
            txtdirecc.Enabled = true;
            txtcontac.Enabled = true;
            txtpais.Enabled = true;
            txtcorreo.Enabled = true;
            txtnome.Text = "";
            txtdirecc.Text = "";
            txtcontac.Text = "";
            txtpais.Text = "Selecciona";
            txtcorreo.Text = "";

            txtnome.Focus();
            bnuevo.Visible = false;
            bguardar.Visible = true;
        }

        private void bguardar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                string myInsertQuery = "INSERT INTO teditoriales(nombree, direccione,contactose,paise,correoe) Values(?nombree,?direccione,?contactose,?paise,?correoe	)";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
                txtnome.Enabled = true;
                txtdirecc.Enabled = true;
                txtcontac.Enabled = true;
                txtpais.Enabled = true;
                txtcorreo.Enabled = true;

                myCommand.Parameters.Add("?nombree", MySqlDbType.VarChar, 50).Value = txtnome.Text;
                myCommand.Parameters.Add("?direccione", MySqlDbType.VarChar, 150).Value = txtdirecc.Text;
                myCommand.Parameters.Add("?contactose", MySqlDbType.VarChar, 15).Value = txtcontac.Text;
                myCommand.Parameters.Add("?paise", MySqlDbType.VarChar, 20).Value = txtpais.Text;
                myCommand.Parameters.Add("?correoe", MySqlDbType.VarChar, 20).Value = txtcorreo.Text;

                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                MessageBox.Show("Usuario agregado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string consulta = "select * from teditoriales";

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
           
            txtnome.Enabled = false;
            txtdirecc.Enabled = false;
            txtcontac.Enabled = false;
            txtpais.Enabled = false;
            txtcorreo.Enabled = false;
            txtnome.Text = "";
            txtdirecc.Text = "";
            txtcontac.Text = "";
            txtpais.Text = "Selecciona";
            txtcorreo.Text = "";

            bnuevo.Focus();
        }

        private void bmodificar_Click(object sender, EventArgs e)
        {


            txtnome.Enabled = true;
            txtdirecc.Enabled = true;
            txtcontac.Enabled = true;
            txtpais.Enabled = true;
            txtcorreo.Enabled = true;
            txtnome.Focus();

            bmodificar.Visible = false;
            bactualizar.Visible = true;

            usuario_modificar = txtnome.Text.ToString();
        }

        
        private void bactualizar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                string nom = txtnome.Text.ToString();
                string di = txtdirecc.Text.ToString();
                string conta = txtcontac.Text.ToString();
                string pa = txtpais.Text.ToString();
                string co = txtcorreo.Text.ToString();
                
             
                string myInsertQuery = "UPDATE teditoriales SET nombree = '" + nom + "', direccione = '" + di + "', contactose = '" + co + "', paise = '" + pa+ "', correoe = '" + co + "' WHERE nombree = '" + usuario_modificar + "'";
                //nombree, direccione,contactose,paise,correoe
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                MessageBox.Show("Usuario modificado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string consulta = "select * from teditoriales";

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
          
            txtnome.Enabled = false;
            txtdirecc.Enabled = false;
            txtcontac.Enabled = false;
            txtpais.Enabled = false;
            txtcorreo.Enabled = false;


            bmodificar.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                try
                {
                    MySqlConnection myConnection = new MySqlConnection(cadena_conexion);
                    string myInsertQuery = ("select * from teditoriales Where ideditorial = '" + txtbuscar.Text + "'");
                    MySqlCommand myCommand = new MySqlCommand(myInsertQuery, myConnection);
                    myCommand.Connection = myConnection;
                    myConnection.Open();
                    MySqlDataReader myReader;
                    myReader = myCommand.ExecuteReader();
                    if (myReader.Read() == true)
                    {
                        txtnome.Text = (myReader.GetString(1));
                        txtdirecc.Text = (myReader.GetString(2));
                        txtcontac.Text = (myReader.GetString(3));
                        txtpais.Text = (myReader.GetString(4));
                        txtcorreo.Text = (myReader.GetString(5));
                        
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
                    string myInsertQuery = ("select * from teditoriales Where nombree = '" + txtbuscar.Text + "'");
                    MySqlCommand myCommand = new MySqlCommand(myInsertQuery, myConnection);
                    myCommand.Connection = myConnection;
                    myConnection.Open();
                    MySqlDataReader myReader;
                    myReader = myCommand.ExecuteReader();
                    if (myReader.Read() == true)
                    {

                        txtnome.Text = (myReader.GetString(1));
                        txtdirecc.Text = (myReader.GetString(2));
                        txtcontac.Text = (myReader.GetString(3));
                        txtpais.Text = (myReader.GetString(4));
                        txtcorreo.Text = (myReader.GetString(5));
                       

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

                string myInsertQuery = "delete from teditoriales Where ideditorial = " + txtbuscar.Text + "";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                MessageBox.Show("Usuario eliminado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);


                string consulta = "select * from teditoriales";

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

            
            txtnome.Enabled = false;
            txtdirecc.Enabled = false;
            txtcontac.Enabled = false;
            txtpais.Enabled = false;
            txtcorreo.Enabled = false;
            txtnome.Text = "";
            txtdirecc.Text = "";
            txtcontac.Text = "";
            txtpais.Text = " Selecciona";
            txtcorreo.Text = "";
            txtbuscar.Focus();


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }

        private void rnombre_CheckedChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }
    }
}


    

    

