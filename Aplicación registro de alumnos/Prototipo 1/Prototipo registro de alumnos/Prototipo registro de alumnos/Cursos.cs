using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo_registro_de_alumnos
{
    public class Cursos
    {
        Conexion cn = new Conexion();

        public DataTable cargarComboboxCursos()
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_comboboxCursos", cn.LeerCadena());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
