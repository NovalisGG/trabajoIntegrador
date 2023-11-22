using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo_registro_de_alumnos.Ventanas
{
    public partial class ventanaAgregarServidor : Form
    {
       
        public ventanaAgregarServidor()
        {
            InitializeComponent();
        }

        private void botonPersonalizado1_Click(object sender, EventArgs e)
        {
            pantallaRegistrar.cadenaConexión = tbox_agregarServidor.Texts;
            MessageBox.Show("Se ha agregado el servidor.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
