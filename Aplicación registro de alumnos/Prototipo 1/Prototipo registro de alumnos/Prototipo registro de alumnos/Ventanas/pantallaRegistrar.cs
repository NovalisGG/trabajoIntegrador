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
using System.Drawing.Drawing2D;
using Prototipo_registro_de_alumnos.Clases;

namespace Prototipo_registro_de_alumnos
{
    public partial class pantallaRegistrar : Form
    {
        Image? fotoCus;
        Image? fotoDNI;
        SqlCombobox c = new SqlCombobox();
        public pantallaRegistrar()
        {
            InitializeComponent();
        }
        private void pantallaRegistrar_Load(object sender, EventArgs e)
        {
            cmb_cursos.DataSource = c.cargarComboboxCursos();
            cmb_cursos.DisplayMember = "curso";
            cmb_cursos.ValueMember = "id_curso";

            cmb_divisiones.DataSource = c.cargarComboboxDivisiones();
            cmb_divisiones.DisplayMember = "division";
            cmb_divisiones.ValueMember = "id_division";

            cmb_especialidades.DataSource = c.cargarComboboxEspecialidades();
            cmb_especialidades.DisplayMember = "nombreEspecialidad";
            cmb_especialidades.ValueMember = "id_especialidad";

            cmb_generoAlumno.DataSource = c.cargarComboboxGeneros();
            cmb_generoAlumno.DisplayMember = "nombreGenero";
            cmb_generoAlumno.ValueMember = "id_genero";

            cmb_generoTutor.DataSource = c.cargarComboboxGeneros();
            cmb_generoTutor.DisplayMember = "nombreGenero";
            cmb_generoTutor.ValueMember = "id_genero";

            cmb_nacionalidadAlumno.DataSource = c.cargarComboboxPaises();
            cmb_nacionalidadAlumno.DisplayMember = "nombrePais";
            cmb_nacionalidadAlumno.ValueMember = "id_pais";

            cmb_nacionalidadTutor.DataSource = c.cargarComboboxPaises();
            cmb_nacionalidadTutor.DisplayMember = "nombrePais";
            cmb_nacionalidadTutor.ValueMember = "id_pais";

            cmb_turnos.DataSource = c.cargarComboboxTurnos();
            cmb_turnos.DisplayMember = "nombreTurno";
            cmb_turnos.ValueMember = "id_turno";

            cmb_parentescoTutor.DataSource = c.cargarComboboxParentescos();
            cmb_parentescoTutor.DisplayMember = "nombreParentesco";
            cmb_parentescoTutor.ValueMember = "id_parentesco";

            btn_registrar.Enabled = false;

            DibujarRectanguloInterfaz();
        }

        private void ValidarCampos()
        {
            var vr = !string.IsNullOrEmpty(tbox_nombreAlumno.Texts) &&
                !string.IsNullOrEmpty(tbox_apellidoAlumno.Texts) &&
                !string.IsNullOrEmpty(tbox_dniAlumno.Texts) &&
                !string.IsNullOrEmpty(tbox_numeroTelefonoAlumno.Texts) &&
                !string.IsNullOrEmpty(tbox_emailAlumno.Texts) &&
                !string.IsNullOrEmpty(tbox_barrio.Texts) &&
                !string.IsNullOrEmpty(tbox_calle.Texts) &&
                !string.IsNullOrEmpty(tbox_nroCalle.Texts) &&
                !string.IsNullOrEmpty(tbox_nombreTutor.Texts) &&
                !string.IsNullOrEmpty(tbox_apellidoTutor.Texts) &&
                !string.IsNullOrEmpty(tbox_dniTutor.Texts) &&
                !string.IsNullOrEmpty(tbox_nroCalle.Texts) &&
                !string.IsNullOrEmpty(tbox_nroTelefonoTutor.Texts) &&
                !string.IsNullOrEmpty(tbox_emailTutor.Texts) &&
                !string.IsNullOrEmpty(tbox_ocupacionTutor.Texts);

            btn_registrar.Enabled = vr;
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPersonalizado2__TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            

            //Datos a guardar del alumno
            string nombreAlumno = tbox_nombreAlumno.Texts;
            string apellidoAlumno = tbox_apellidoAlumno.Texts;
            string dniAlumno = tbox_dniAlumno.Texts;
            DateTime fechaNacimientoAlumno = dtp_fechaNacimientoAlumo.Value.Date;
            string numeroTelefonoAlumno = tbox_numeroTelefonoAlumno.Texts;
            string emailAlumno = tbox_emailAlumno.Texts;
            string direccionAlumno = tbox_barrio.Texts + ", " + tbox_calle.Texts + " " + tbox_nroCalle.Texts;
            string curso = cmb_cursos.GetItemText();
            string division = cmb_divisiones.GetItemText();
            string turno = cmb_turnos.GetItemText();
            string generoAlumno = cmb_generoAlumno.GetItemText();
            string especialidadAlumno = cmb_especialidades.GetItemText();
            string nacionalidadAlumno = cmb_nacionalidadAlumno.GetItemText();
            byte[] fotoCusBytes = ImageToByteArray(fotoCus);
            byte[] fotoDniBytes = ImageToByteArray(fotoDNI);
            
            //Datos a guardar del tutor
            string nombreTutor = tbox_nombreTutor.Texts;
            string apellidoTutor = tbox_apellidoTutor.Texts;
            string dniTutor = tbox_dniTutor.Texts;
            DateTime fechaNacimientoTutor = dtp_fechaNacimientoTutor.Value;
            string numeroTelefonoTutor = tbox_nroTelefonoTutor.Texts;
            string emailTutor = tbox_emailTutor.Texts;
            string nacionalidadTutor = cmb_nacionalidadTutor.GetItemText();
            string parentesco = cmb_parentescoTutor.GetItemText();
            string generoTutor = cmb_generoTutor.GetItemText();
            string ocupacionTutor = tbox_ocupacionTutor.Texts;


            string queryTutores = "INSERT INTO Tutores (dni_tutor, parentesco, nombreTutor, apellidoTutor, fechaNacimientoTutor, genero, emailTutor, telefonoTutor, nacionalidad, ocupacion) VALUES(@dni_tutor, @parentesco, @nombreTutor, @apellidoTutor, @fechaNacimientoTutor, @genero, @emailTutor, @telefonoTutor, @nacionalidad, @ocupacion)";

            using (SqlConnection connection = new SqlConnection("Data Source=MARIANORUARTE;Initial Catalog=RegistroAlumnosCassaffousth;Integrated Security=True"))
            {
                SqlCommand command = new SqlCommand(queryTutores, connection);
                command.Parameters.AddWithValue("@dni_tutor", Convert.ToInt32(dniTutor));
                command.Parameters.AddWithValue("@parentesco", parentesco);
                command.Parameters.AddWithValue("@nombreTutor", nombreTutor);
                command.Parameters.AddWithValue("@apellidoTutor", apellidoTutor);
                command.Parameters.AddWithValue("@fechaNacimientoTutor", fechaNacimientoTutor.ToString("dd-MM-yyyy hh:mm:ss"));
                command.Parameters.AddWithValue("@genero", generoTutor);
                command.Parameters.AddWithValue("@emailTutor", emailTutor);
                command.Parameters.AddWithValue("@telefonoTutor", numeroTelefonoTutor);
                command.Parameters.AddWithValue("@nacionalidad", nacionalidadTutor);
                command.Parameters.AddWithValue("@ocupacion", ocupacionTutor);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            string queryAlumnos = "insert into Alumnos (dni_alumno, nombreAlumno, apellidoAlumno, fechaNacimientoAlumno, generoAlumno, emailAlumno, telefonoAlumno, direccionAlumno, cusAlumno, cursoAlumno, divisionAlumno, turnoAlumno, especialidadAlumno, fotoDNI, tutorAlumno, nacionalidadAlumno)" + 
                "values(@dni_alumno, @nombreAlumno, @apellidoAlumno, @fechaNacimientoAlumno, @generoAlumno, @emailAlumno, @telefonoAlumno, @direccionAlumno, @cusAlumno," +
                " @cursoAlumno, @divisionAlumno, @turnoAlumno, @especialidadAlumno, @fotoDNI, @tutorAlumno, @nacionalidadAlumno)";
            using (SqlConnection connection1 = new SqlConnection("Data Source=MARIANORUARTE;Initial Catalog=RegistroAlumnosCassaffousth;Integrated Security=True"))
            {
                SqlCommand command = new SqlCommand(queryAlumnos, connection1);
                command.Parameters.AddWithValue("@dni_Alumno", Convert.ToInt32(dniAlumno));
                command.Parameters.AddWithValue("@nombreAlumno", nombreAlumno);
                command.Parameters.AddWithValue("@apellidoAlumno", apellidoAlumno);
                command.Parameters.AddWithValue("@fechaNacimientoAlumno", fechaNacimientoAlumno.ToString("dd-MM-yyyy hh:mm:ss"));   
                command.Parameters.AddWithValue("@generoAlumno", generoAlumno);
                command.Parameters.AddWithValue("@emailAlumno", emailAlumno);
                command.Parameters.AddWithValue("@telefonoAlumno", numeroTelefonoAlumno);
                command.Parameters.AddWithValue("@direccionAlumno", direccionAlumno);
                command.Parameters.AddWithValue("@cusAlumno", fotoCusBytes);
                command.Parameters.AddWithValue("@cursoAlumno", curso);
                command.Parameters.AddWithValue("@divisionAlumno", division);
                command.Parameters.AddWithValue("@turnoAlumno", turno);
                command.Parameters.AddWithValue("@especialidadAlumno", especialidadAlumno);
                command.Parameters.AddWithValue("@fotoDNI", fotoDniBytes);
                command.Parameters.AddWithValue("@tutorAlumno", dniTutor);
                command.Parameters.AddWithValue("@nacionalidadAlumno", nacionalidadAlumno);

                connection1.Open();
                command.ExecuteNonQuery();
                connection1.Close();
            }

            MessageBox.Show("Alumno y tutor agregado con éxito.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public byte[] ImageToByteArray(Image imagen)
        {
            MemoryStream ms = new MemoryStream();
            imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            return ms.ToArray();
        }

        private void btn_buscarCUS_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscarFoto = new OpenFileDialog();
            DialogResult rs = buscarFoto.ShowDialog();

            if (rs == DialogResult.OK)
            {
                fotoCus = Image.FromFile(buscarFoto.FileName);
                btn_buscarCUS.BackColor = Color.Green;
            }

            
        }

        private void btn_BuscarFotoDNI_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscarFoto = new OpenFileDialog();
            DialogResult rs = buscarFoto.ShowDialog();

            if (rs == DialogResult.OK)
            {
                fotoDNI = Image.FromFile(buscarFoto.FileName);
                btn_BuscarFotoDNI.BackColor = Color.Green;
            }
        }

        private void btn_registrarSalir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Está seguro que desea salir? Se perderán los cambios", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                Close();
        }

        private void tbox_nombreAlumno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 129) || (e.KeyChar >= 131 && e.KeyChar <= 143) || (e.KeyChar >= 145 && e.KeyChar <= 159) || (e.KeyChar >= 166 && e.KeyChar <= 180) || (e.KeyChar >= 182 && e.KeyChar <= 223) || (e.KeyChar >= 225 && e.KeyChar <= 232) || (e.KeyChar >= 234 && e.KeyChar <= 255))
            {
                MessageBox.Show("Hola");
                e.Handled = true;
                return;
            }

            
            return;
        }

        private void tbox_dniAlumno_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(sender, e);
        }

        private void tbox_dniTutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void tbox_nroCalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void tbox_numeroTelefonoAlumno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void tbox_nroTelefonoTutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void tbox_apellidoAlumno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 129) || (e.KeyChar >= 131 && e.KeyChar <= 143) || (e.KeyChar >= 145 && e.KeyChar <= 159) || (e.KeyChar >= 166 && e.KeyChar <= 180) || (e.KeyChar >= 182 && e.KeyChar <= 223) || (e.KeyChar >= 225 && e.KeyChar <= 232) || (e.KeyChar >= 234 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void tbox_emailAlumno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 129) || (e.KeyChar >= 131 && e.KeyChar <= 143) || (e.KeyChar >= 145 && e.KeyChar <= 159) || (e.KeyChar >= 166 && e.KeyChar <= 180) || (e.KeyChar >= 182 && e.KeyChar <= 223) || (e.KeyChar >= 225 && e.KeyChar <= 232) || (e.KeyChar >= 234 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void tbox_barrio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 129) || (e.KeyChar >= 131 && e.KeyChar <= 143) || (e.KeyChar >= 145 && e.KeyChar <= 159) || (e.KeyChar >= 166 && e.KeyChar <= 180) || (e.KeyChar >= 182 && e.KeyChar <= 223) || (e.KeyChar >= 225 && e.KeyChar <= 232) || (e.KeyChar >= 234 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void tbox_calle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 129) || (e.KeyChar >= 131 && e.KeyChar <= 143) || (e.KeyChar >= 145 && e.KeyChar <= 159) || (e.KeyChar >= 166 && e.KeyChar <= 180) || (e.KeyChar >= 182 && e.KeyChar <= 223) || (e.KeyChar >= 225 && e.KeyChar <= 232) || (e.KeyChar >= 234 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void tbox_nombreTutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 129) || (e.KeyChar >= 131 && e.KeyChar <= 143) || (e.KeyChar >= 145 && e.KeyChar <= 159) || (e.KeyChar >= 166 && e.KeyChar <= 180) || (e.KeyChar >= 182 && e.KeyChar <= 223) || (e.KeyChar >= 225 && e.KeyChar <= 232) || (e.KeyChar >= 234 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void tbox_apellidoTutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 129) || (e.KeyChar >= 131 && e.KeyChar <= 143) || (e.KeyChar >= 145 && e.KeyChar <= 159) || (e.KeyChar >= 166 && e.KeyChar <= 180) || (e.KeyChar >= 182 && e.KeyChar <= 223) || (e.KeyChar >= 225 && e.KeyChar <= 232) || (e.KeyChar >= 234 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void tbox_emailTutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 129) || (e.KeyChar >= 131 && e.KeyChar <= 143) || (e.KeyChar >= 145 && e.KeyChar <= 159) || (e.KeyChar >= 166 && e.KeyChar <= 180) || (e.KeyChar >= 182 && e.KeyChar <= 223) || (e.KeyChar >= 225 && e.KeyChar <= 232) || (e.KeyChar >= 234 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void tbox_ocupacionTutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 129) || (e.KeyChar >= 131 && e.KeyChar <= 143) || (e.KeyChar >= 145 && e.KeyChar <= 159) || (e.KeyChar >= 166 && e.KeyChar <= 180) || (e.KeyChar >= 182 && e.KeyChar <= 223) || (e.KeyChar >= 225 && e.KeyChar <= 232) || (e.KeyChar >= 234 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void tbox_nombreAlumno__TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void tbox_apellidoAlumno__TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void tbox_dniAlumno__TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void tbox_numeroTelefonoAlumno__TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void tbox_emailAlumno__TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void tbox_barrio__TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void tbox_calle__TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void tbox_nroCalle__TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void tbox_nombreTutor__TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void tbox_apellidoTutor__TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void tbox_dniTutor__TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void tbox_nroTelefonoTutor__TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void tbox_emailTutor__TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void tbox_ocupacionTutor__TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void soloNumeros(object sender, KeyPressEventArgs e)
        {
            Console.WriteLine(e.KeyChar.ToString());
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void DibujarRectanguloInterfaz()
        {
            Rectangle rectangle = new Rectangle(0, 0,300, 300);
            int radius = 5;
            GraphicsPath path = Dibujar.RoundedRectanglePath(rectangle, radius);
            Graphics papel = pbox_fondoTutor.CreateGraphics();
            Pen lapiz = new Pen(Color.Black);
            SolidBrush pincel = new SolidBrush(Color.Black);

            Dibujar.FillRoundedRectangle(papel, pincel, path);
        }

    }

}
