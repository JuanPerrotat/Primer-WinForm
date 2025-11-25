using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo2
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void perfilPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PerfilPersona ventana = new PerfilPersona();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void tsbPerfilPersona_Click(object sender, EventArgs e)
        {

            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(PerfilPersona))
                {
                    MessageBox.Show("Ya hay una ventana de éste tipo abierta, no se pueden abrir dos ventanas iguales.");
                    return;
                }
            }

            PerfilPersona ventana = new PerfilPersona();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
