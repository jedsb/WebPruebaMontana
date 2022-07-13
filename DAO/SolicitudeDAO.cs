using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebPruebaMontana.Conexion;

namespace WebPruebaMontana.DAO
{
    public class SolicitudeDAO
    {
        public DataTable ObtenerSolicitud(int solicitudeId)
        {
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            Conexiones con = new Conexiones();
            try
            {
                con.conSql.Open();
                cmd = new SqlCommand("usp_Solicitude_GetOne_V2", con.conSql);
                cmd.Parameters.AddWithValue("@solicitudeId", solicitudeId);
                cmd.CommandType = CommandType.StoredProcedure;
                da.SelectCommand = cmd;
                da.Fill(dt);                
            }
            catch (Exception e)
            {
               
            }
            finally
            {
                con.conSql.Close();
                con.conSql.Dispose();
            }
            return dt;
        }
    }
}