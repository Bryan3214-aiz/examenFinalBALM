using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace examenFinalBALM.Clases
{
    public class ClsCantidad
    {
        public int cantidadTotal { get; set; }

        private static int tipoReporte = 0;

        public static List<ClsCantidad> reportesTotal = new List<ClsCantidad>();

        public ClsCantidad(int cantidad)
        {
            cantidadTotal = cantidad;
        }
        public ClsCantidad()
        {

        }
        public static List<ClsCantidad> ObtenerCantidad()
        {
            int retorno = 0;
            tipoReporte = 1;
            SqlConnection Conn = new SqlConnection();

            try
            {

                using (Conn = Clases.DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("MenuReportes", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@TipoReporte", tipoReporte));
                    retorno = cmd.ExecuteNonQuery();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ClsCantidad EncuestasC = new ClsCantidad();
                            EncuestasC.cantidadTotal = reader.GetInt32(0);
                            reportesTotal.Add(EncuestasC);
                        }
                    }
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                return reportesTotal;
            }
            finally
            {
                Conn.Close();
                Conn.Dispose();
            }
            return reportesTotal;
        }
    }
}