using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebPruebaMontana.Conexion
{
    public class Conexiones
    {
		public SqlConnection conSql;
		public ConnectionStringSettings configuracion;

		public Conexiones()
		{

			conSql = new SqlConnection();
			configuracion = ConfigurationManager.ConnectionStrings["Conexion_BD"];
			conSql.ConnectionString = configuracion.ConnectionString;

		}
	}
}