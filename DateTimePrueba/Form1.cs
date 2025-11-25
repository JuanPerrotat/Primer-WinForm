using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimePrueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDtp_Click(object sender, EventArgs e)
        {
            DateTime fecha1 = dtpFecha.Value;
            MessageBox.Show("La fecha seleccionada es: " + fecha1.ToString("d en MMMM en el año y"));
        }

        private void btnCal_Click(object sender, EventArgs e)
        {

            MessageBox.Show("La fecha seleccionada es: " + calFecha.SelectionStart.ToString("d/M/yyyy"));
        }
    }
}
