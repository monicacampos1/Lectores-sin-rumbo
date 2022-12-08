using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;



namespace Practica_semana_10
{
    public partial class Menu : Form
    {

        public Menu()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void rjButton7_Click(object sender, EventArgs e)
        {
           // Propuesta u = new Propuesta();
           // u.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 290)
            {
                MenuVertical.Width = 77;
            }
            else
                MenuVertical.Width = 290;

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new autores());
        }

        private void artanPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AbrirFormulario(object FormularioHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = FormularioHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
        private void btnLibros_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new libros());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new empleados1());
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new prestamos());
        }

        private void button10_Click(object sender, EventArgs e)
        {
         
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new editoriales ());
        }

        private void button12_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new proveedores ());
        }

        private void button13_Click(object sender, EventArgs e)
        {
         
        }

        private void button14_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new acercade());
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

            AbrirFormulario(new contactos1());
        }

        private void button15_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new ugbverde());
        }

        private void button16_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new ventanaAyuda());
        }
    }
}
