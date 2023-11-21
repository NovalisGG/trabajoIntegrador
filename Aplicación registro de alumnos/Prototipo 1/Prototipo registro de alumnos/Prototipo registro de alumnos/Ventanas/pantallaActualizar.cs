using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Prototipo_registro_de_alumnos
{
    public partial class pantallaActualizar : Form
    {
        //Atributos
        Image foto;
        byte[] fotoConvertida;
        bool pasarFoto;


        string[] camposAlumnos = { "dni_alumno", "nombreAlumno", "apellidoAlumno", "emailAlumno", "telefonoAlumno", "direccionAlumno", "cusAlumno", "fotoDNI",
        "fechaNacimientoAlumno", "generoAlumno", "cursoAlumno", "divisionAlumno", "turnoAlumno", "especialidadAlumno", "TutorAlumno", "nacionalidadAlumno" };
        string[] camposTutores = { "dni_tutor", "nombreTutor", "apellidoTutor", "emailTutor", "telefonoTutor", "parentesco", "fechaNacimientoTutor", "genero",
             "nacionalidad", "ocupación" };

        public pantallaActualizar()
        {
            InitializeComponent();
        }

        //Eventos
        private void pantallaActualizar_Load(object sender, EventArgs e)
        {
            btn_actualizar.Enabled = false;
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            ChequearSiComboboxCompleto();

            string query;

            

            if (cmb_tipoPersonaBuscar.GetItemText() == "Alumnos")
            {
                query = "UPDATE Alumnos SET " + cmb_campos.GetItemText() + " = " + "'" + tbox_datoActualizado.Texts + "'" + " WHERE dni_alumno = " + tbox_dniApellido.Text + "";
            }
            else
            {
                query = "UPDATE Tutores SET " + cmb_campos.GetItemText() + " = " + "'" + tbox_datoActualizado.Texts + "'" + " WHERE dni_tutor = " + tbox_dniApellido.Text + "";
            }

            if (cmb_campos.GetItemText() == "cusAlumno" || cmb_campos.GetItemText() == "fotoDNI")
            {
                fotoConvertida = ImageToByteArray(foto);
                label1.Text = fotoConvertida.ToString();
                query = "UPDATE Alumnos SET " + cmb_campos.GetItemText() + " = @foto  WHERE dni_alumno = " + tbox_dniApellido.Text + "";
                pasarFoto = true;
            }

            using (SqlConnection connection = new SqlConnection("Data Source=MARIANORUARTE;Initial Catalog=RegistroAlumnosCassaffousth;Integrated Security=True"))
            {
                SqlCommand command = new SqlCommand(query, connection);

                if (pasarFoto) command.Parameters.AddWithValue("@foto", fotoConvertida);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            MessageBox.Show("Se ha actualizado el dato con éxito", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmb_campos_Click(object sender, EventArgs e)
        {
            //Saca la lista de elementos adecuada para el combobox cmb_campos. Esto porque la tabla alumnos y la tabla tutores
            //tienen campos distintos

            if (cmb_tipoPersonaBuscar.SelectedItem == null) return;

            if (cmb_tipoPersonaBuscar.GetItemText() == "Alumnos")
            {
                cmb_campos.DataSource = camposAlumnos;
            }
            else
            {
                cmb_campos.DataSource = camposTutores;
            }
        }

        private void tbox_barraBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmb_tipoPersonaBuscar.SelectedItem == null)
            {
                e.Handled = true;
                MessageBox.Show("Seleccione si se debe buscar un alumno/a o tutor/a.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }
            else
            {
                tbox_dniApellido.Enabled = true;
            }

            //Saca la lista de elementos adecuada para el combobox cmb_campos. Esto porque la tabla alumnos y la tabla tutores
            //tienen campos distintos
            if (cmb_tipoPersonaBuscar.SelectedItem == null) return;

            if (cmb_tipoPersonaBuscar.GetItemText() == "Alumnos")
            {
                cmb_campos.DataSource = camposAlumnos;
            }
            else
            {
                cmb_campos.DataSource = camposTutores;
            }
        }

        private void tbox_datoActualizado__TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void tbox_dniApellido_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void cmb_campos_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_campos.GetItemText() == "cusAlumno" || cmb_campos.GetItemText() == "fotoDNI")
            {
                btn_guardarFoto.Visible = true;
                btn_guardarFoto.Enabled = true;
                tbox_datoActualizado.Enabled = false;
                btn_actualizar.Enabled = true;
                tbox_datoActualizado.Enabled = false;
                tbox_datoActualizado.Visible = false;
            }
            else
            {
                btn_guardarFoto.Enabled = false;
                btn_guardarFoto.Visible = false;
                tbox_datoActualizado.Enabled = true;
                tbox_datoActualizado.Visible = true;
            }
        }

        private void btn_guardarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscarFoto = new OpenFileDialog();
            DialogResult rs = buscarFoto.ShowDialog();

            if (rs == DialogResult.OK)
            {
                foto = Image.FromFile(buscarFoto.FileName);
                btn_guardarFoto.BackColor = Color.Green;
                btn_guardarFoto.BorderColor = Color.Green;
                btn_actualizar.Enabled = true;
            }
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            tbox_datoActualizado.Texts = "";
            cmb_tipoPersonaBuscar.SelectedIndex = 0;
            tbox_dniApellido.Text = null;
            btn_guardarFoto.BackColor = Color.White;
            btn_guardarFoto.BorderColor = Color.White;
            Close();
        }

        //Métodos===============================
        private void ChequearSiComboboxCompleto()
        {
            if (cmb_tipoPersonaBuscar == null)
            {
                MessageBox.Show("Seleccione si se debe buscar un alumno/a o tutor/a.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (cmb_campos.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un campo a remplazar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ValidarCampos()
        {
            var vr = !string.IsNullOrEmpty(tbox_dniApellido.Text) &&
                !string.IsNullOrEmpty(tbox_datoActualizado.Texts);
           
            btn_actualizar.Enabled = vr;
        }

        

        public byte[] ImageToByteArray(Image imagen)
        {
            MemoryStream ms = new MemoryStream();
            imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            return ms.ToArray();
        }

        
    }
}
