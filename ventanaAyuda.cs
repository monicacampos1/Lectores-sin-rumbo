using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_semana_10
{
    public partial class ventanaAyuda : Form
    {
        public ventanaAyuda()
        {
            InitializeComponent();
        }

        string carpeta = Application.StartupPath + @"\carpeta ayuda";
        string archivo =  @"\ayuda.txt";


        private void ventanaAyuda_Load(object sender, EventArgs e)
        {
            string ubicacion = carpeta + archivo;

            string leer = System.IO.File.ReadAllText(ubicacion);
            textContedor.Text = leer;
        }

        private void textContedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void bcerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
