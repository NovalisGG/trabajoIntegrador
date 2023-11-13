using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Prototipo_registro_de_alumnos
{
    public partial class pantallaRegistrar : Form
    {
        SqlConnection connRegistrar = new SqlConnection(@"Data Source=MARIANORUARTE;Initial Catalog=RegistroAlumnosCassaffousth;Integrated Security=True");
        Cursos curso = new Cursos();
        public pantallaRegistrar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pantallaRegistrar_Load(object sender, EventArgs e)
        {
            
        }

        private void botonPersonalizado1_Click(object sender, EventArgs e)
        {

        }

        private void guardarDatos()
        {
            SqlDataAdapter da = new SqlDataAdapter("insert into Alumnos", connRegistrar);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPersonalizado2__TextChanged(object sender, EventArgs e)
        {

        }
    }
}
