using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace examenFinalBALM.Clases
{
    public class ClsEncuestas
    {
        public int numero { get; set; }
        public string nombre { get; set; }
        public string genero { get; set; }
        public int edad { get; set; }
        public string correo { get; set; }
        public string partido { get; set; }

        private static int tipoOperacion = 0;

        public static List<ClsEncuestas> EncuestasP = new List<ClsEncuestas>();

        public ClsEncuestas(int numero, string nombre, string genero, int edad, string correo, string partido)
        {
            this.numero = numero;
            this.nombre = nombre;
            this.genero = genero;
            this.edad = edad;
            this.correo = correo;
            this.partido = partido;
        }
        public ClsEncuestas()
        {

        }

        public static int AgregarEncuestas(string nombre, string genero, string edad, string correo, string partido)
        {
            int retorno = 0;
            tipoOperacion = 1;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = Clases.DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("Sp_Encuesta", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@Operacion", tipoOperacion));
                    cmd.Parameters.Add(new SqlParameter("@Numero", 0));
                    cmd.Parameters.Add(new SqlParameter("@Nombre", nombre));
                    cmd.Parameters.Add(new SqlParameter("@Genero", genero));
                    cmd.Parameters.Add(new SqlParameter("@Edad", edad));
                    cmd.Parameters.Add(new SqlParameter("@CorreoElectronico", correo));
                    cmd.Parameters.Add(new SqlParameter("@PartidoPolitico", partido));

                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = -1;
            }
            finally
            {
                Conn.Close();
            }

            return retorno;
        }
       
        public static List<ClsEncuestas> ObtenerReportes()
        {
            int retorno = 0;
            tipoOperacion = 2;
            SqlConnection Conn = new SqlConnection();

            try
            {

                using (Conn = Clases.DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("Sp_Encuesta", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@Operacion", tipoOperacion));
                    retorno = cmd.ExecuteNonQuery();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ClsEncuestas Encuesta = new ClsEncuestas();
                            Encuesta.numero = reader.GetInt32(0);
                            Encuesta.nombre = reader.GetString(1);
                            Encuesta.genero = reader.GetString(2);
                            Encuesta.edad = reader.GetInt32(3);
                            Encuesta.correo = reader.GetString(4);
                            Encuesta.partido = reader.GetString(5);
                            EncuestasP.Add(Encuesta);
                        }

                    }
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                return EncuestasP;
            }
            finally
            {
                Conn.Close();
                Conn.Dispose();
            }
            return EncuestasP;
        }
    }
}