using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototipo_registro_de_alumnos.Clases;

namespace Prototipo_registro_de_alumnos
{
    public class SqlCombobox
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

        public DataTable cargarComboboxDivisiones()
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_cargarDivisiones", cn.LeerCadena());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable cargarComboboxTurnos()
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_cargarTurnos", cn.LeerCadena());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable cargarComboboxEspecialidades()
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_cargarEspecialidades", cn.LeerCadena());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable cargarComboboxPaises()
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_cargarPaises", cn.LeerCadena());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable cargarComboboxParentescos()
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_cargarParentescos", cn.LeerCadena());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable cargarComboboxGeneros()
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_cargarGeneros", cn.LeerCadena());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }
}
