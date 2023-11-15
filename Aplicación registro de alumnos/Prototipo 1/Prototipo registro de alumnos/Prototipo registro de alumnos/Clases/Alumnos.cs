using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo_registro_de_alumnos.Clases
{
    public class Alumnos
    {
        Conexion cn = new Conexion();

        public DataTable MostrarAlumnos()
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_mostrarTablaAlumnos", cn.LeerCadena());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}
