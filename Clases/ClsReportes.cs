using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace examenFinalBALM.Clases
{
    public class ClsReportes
    {
        public int cantidadM { get; set; }
        public int cantidadF { get; set; }

        private static int tipoReporte = 0;

        public static List<ClsReportes> reportes = new List<ClsReportes>();

        public ClsReportes(int hombres, int mujeres)
        {
            cantidadM = hombres;
            cantidadF = mujeres;
        }
        public ClsReportes()
        {

        }
        public static List<ClsReportes> ObtenerReportes()
        {
            int retorno = 0;
            tipoReporte = 2;
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
                            ClsReportes EncuestasC = new ClsReportes();
                            EncuestasC.cantidadM = reader.GetInt32(0);
                            EncuestasC.cantidadF = reader.GetInt32(1);
                            reportes.Add(EncuestasC);
                        }
                    }
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                return reportes;
            }
            finally
            {
                Conn.Close();
                Conn.Dispose();
            }
            return reportes;
        }
    }
}