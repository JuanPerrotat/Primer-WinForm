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
    public partial class PerfilPersona : Form
    {
        public PerfilPersona()
        {
            InitializeComponent();
        }

        private void cmbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fechaNacimiento = dtpFechaNacimiento.Value;
            string chocolate = checkChocolate.Checked == true ? "Le gusta el chocolate." : "No le gusta el chocolate";
            string clase;
            if (rbtnWizard.Checked)
                clase = "Wizard";
            else if (rbtnDworf.Checked)
                clase = "Dworf";
            else
                clase = "Elf";
            string colorFavorito = cmbColor.SelectedItem.ToString();
            string bichos = numBichos.Value.ToString();

            MessageBox.Show("Nombre: " + nombre + ". Fecha de nacimiento: " + fechaNacimiento + chocolate + "El tipo de clase es: " + clase + ", su color favorito es: " + colorFavorito + ". Y, por último, la cantidad de bichos matados fue de: " + bichos + "." );

        }
    }
}
