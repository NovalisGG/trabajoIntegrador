﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Prototipo_registro_de_alumnos.Clases
{
    public class Conexion
    {
        public SqlConnection LeerCadena()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Prototipo_registro_de_alumnos.Properties.Settings.RegistroAlumnosCassaffousth"].ConnectionString);

            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
            else
            {
                cn.Open();
            }

            return cn;

        }

    }
}
