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
    public partial class ugbverde : Form
    {
        public ugbverde()
        {
            InitializeComponent();
        }

        private void bcerrar_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void ugbverde_Load(object sender, EventArgs e)
        {
            //prueba de que no 
        }

        private void ugb_Click(object sender, EventArgs e)
        {
            recomen ven = new recomen();
            ven.Show();
        }
    }
}
