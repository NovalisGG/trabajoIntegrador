﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Prototipo_registro_de_alumnos.Clases;

namespace Prototipo_registro_de_alumnos
{
    public partial class pantallaBuscar : Form
    {
        private bool esIdentity = false;

        public pantallaBuscar()
        {
            InitializeComponent();
        }

        public pantallaBuscar(ListBox listaNueva)
        {
            
        }
        private void pantallaBuscar_Load(object sender, EventArgs e)
        {
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            string consultaBuscar;
            SqlConnection connection = new SqlConnection("Data Source=MARIANORUARTE;Initial Catalog=RegistroAlumnosCassaffousth;Integrated Security=True");

            if (cmb_tutorOalumno.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una tabla para buscar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (esIdentity)
                if (cmb_tutorOalumno.SelectedItem.ToString() == "Tutor")
                {
                    consultaBuscar = "select * from Tutores where dni_Tutor = " + tbox_barraBusqueda.Texts + "";

                }
                else 
                {
                    consultaBuscar = "select * from Alumnos where contains dni_alumno = " + tbox_barraBusqueda.Texts + "";
                }
            else
            {
                if (cmb_tutorOalumno.SelectedItem.ToString() == "Tutor")
                {
                    consultaBuscar = "select * from Tutores where apellidoTutor = '"  + tbox_barraBusqueda.Texts + "'";

                }
                else
                {
                    consultaBuscar = "select * from Alumnos where apellidoAlumno = '" + tbox_barraBusqueda.Texts + "'";
                }
            }



            connection.Open();

            SqlDataAdapter adaptador = new SqlDataAdapter(consultaBuscar, connection);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgvAlumnos.DataSource = dt;

            SqlCommand command = new SqlCommand(consultaBuscar, connection);
            SqlDataReader lector;
            lector = command.ExecuteReader();
            connection.Close();

        }

        private void Refresh()
        {
           
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AgregarAlDataGrid()
        {
           
        }

        private void textBoxPersonalizado1__TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbox_barraBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (e.KeyChar > 47 && e.KeyChar < 58)
            {
                esIdentity = true;
            }
            else
            {
                esIdentity = false;
            }
        }

        private void btn_eliminarRegistro_Click(object sender, EventArgs e)
        {
            string consultaBuscar;
            SqlConnection connection = new SqlConnection("Data Source=MARIANORUARTE;Initial Catalog=RegistroAlumnosCassaffousth;Integrated Security=True");

            if (cmb_tutorOalumno.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una tabla para buscar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (esIdentity)
                if (cmb_tutorOalumno.SelectedItem.ToString() == "Tutor")
                {
                    consultaBuscar = "delete  from Tutores where dni_Tutor = " + tbox_barraBusqueda.Texts + "";

                }
                else
                {
                    consultaBuscar = "delete  from Alumnos where dni_alumno = " + tbox_barraBusqueda.Texts;
                }
            else
            {
                if (cmb_tutorOalumno.SelectedItem.ToString() == "Tutor")
                {
                    consultaBuscar = "delete  from Tutores where apellidoTutor = '" + tbox_barraBusqueda.Texts + "'";

                }
                else
                {
                    consultaBuscar = "delete  from Alumnos where apellidoAlumno = '" + tbox_barraBusqueda.Texts + "'";
                }

            }

            connection.Open();

            SqlDataAdapter adaptador = new SqlDataAdapter(consultaBuscar, connection);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgvAlumnos.DataSource = dt;

            SqlCommand command = new SqlCommand(consultaBuscar, connection);
            SqlDataReader lector;
            lector = command.ExecuteReader();
            connection.Close();

            MessageBox.Show("Se ha eliminado el registro del alumno con éxito.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
