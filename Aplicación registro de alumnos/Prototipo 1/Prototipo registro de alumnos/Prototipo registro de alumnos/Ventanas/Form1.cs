using System.Data.SqlClient;
using System.Data;
using Prototipo_registro_de_alumnos.Ventanas;

namespace Prototipo_registro_de_alumnos

{
    public partial class Form1 : Form
    {
        pantallaRegistrar ventanaRegistrar = new pantallaRegistrar();
        ventanaAgregarServidor vas = new ventanaAgregarServidor();
        pantallaBuscar ventanaBuscar = new pantallaBuscar();
        pantallaActualizar pantallaActualizar = new pantallaActualizar();
        SqlConnection conn = new SqlConnection(@"Data Source=MARIANORUARTE;Initial Catalog=RegistroAlumnosCassaffousth;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ventanaRegistrar.ShowDialog();
        }

        private void btn_buscarAlumnos_Click(object sender, EventArgs e)
        {
            ventanaBuscar.ShowDialog();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            ventanaRegistrar.ShowDialog();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            ventanaBuscar.ShowDialog();
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            pantallaActualizar.ShowDialog();
        }

        private void btn_ventanaAgregarServidor_Click(object sender, EventArgs e)
        {
            vas.ShowDialog();
        }
    }
}