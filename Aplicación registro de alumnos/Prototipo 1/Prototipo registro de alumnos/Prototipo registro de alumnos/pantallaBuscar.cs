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
    public partial class pantallaBuscar : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=MARIANORUARTE;Initial Catalog=RegistroAlumnosCassaffousth;Integrated Security=True");

        public pantallaBuscar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pantallaBuscar_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void cargarDatos()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Alumnos", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
