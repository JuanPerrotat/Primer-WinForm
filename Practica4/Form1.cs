using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica4
{
    public partial class frmPractica4 : Form
    {
        public frmPractica4()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmPractica4_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Ésta es la práctica número 4", "Mensaje de bienvenida");
        }

        private void rtxtbTexto_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMuestra_Click(object sender, EventArgs e)
        {
            if (rtxtbTexto.Text == "")
                rtxtbTexto.BackColor = Color.Red;
            else
                rtxtbTexto.BackColor = System.Drawing.SystemColors.Control;
            
        }

        private void rtxtbTexto_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void rtxtbTexto_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene " + rtxtbTexto.Text.Length + " Caracteres");
        }
    }
}
