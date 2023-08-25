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
        public string nombreParticipante { get; set; }
        public string Genero { get; set; }
        public int Edad { get; set; }
        public string Correo { get; set; }
        public string PartidoPolitico { get; set; }
        public int BitacoraID { get; set; }
        public string Accion { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Detalles { get; set; }


        private static int tipoOperacion = 0;

        public static List<ClsEncuestas> EncuestasP = new List<ClsEncuestas>();
        public ClsEncuestas(int numero, string nombreparticipante, string genero, int edad, string correo, string partidopolitico, int bitacoraID, string Accion, DateTime fechaRegistro, string detalles)
        {
            this.numero = numero;
            this.nombreParticipante = nombreparticipante;
            this.Genero = genero;
            this.Edad = edad;
            this.Correo = correo;
            this.PartidoPolitico = partidopolitico;
            this.BitacoraID = bitacoraID;
            this.Accion = Accion;
            this.FechaRegistro = fechaRegistro;
            this.Detalles = detalles;

        }
        public ClsEncuestas()
        {

        }

        public static int AgregarEncuestas(string nombreparticipante, string genero, string edad, string correo, string partidopolitico)
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
                    cmd.Parameters.Add(new SqlParameter("@EncuestaID", 0));
                    cmd.Parameters.Add(new SqlParameter("@Nombre", nombreparticipante));
                    cmd.Parameters.Add(new SqlParameter("@Genero", genero));
                    cmd.Parameters.Add(new SqlParameter("@Edad", edad));
                    cmd.Parameters.Add(new SqlParameter("@CorreoElectronico", correo));
                    cmd.Parameters.Add(new SqlParameter("@PartidoPolitico", partidopolitico));

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
        public static List<ClsEncuestas> ObtenerEncuestas()
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
                            ClsEncuestas encuesta = new ClsEncuestas();
                            encuesta.numero = reader.GetInt32(0);
                            encuesta.nombreParticipante = reader.GetString(1);
                            encuesta.Genero = reader.GetString(2);
                            encuesta.Edad = reader.GetInt32(3);
                            encuesta.Correo = reader.GetString(4);
                            encuesta.PartidoPolitico = reader.GetString(5);
                            EncuestasP.Add(encuesta);
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


        public static int AgregarBitacora(int BitacoraID, string Accion, DateTime FechaRegistro, string detalles)
        {
            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = Clases.DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("Sp_Encuesta", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@BitacoraID", BitacoraID));
                    cmd.Parameters.Add(new SqlParameter("Accion", Accion));
                    cmd.Parameters.Add(new SqlParameter("@FechaRegistro", FechaRegistro));
                    cmd.Parameters.Add(new SqlParameter("@Detalles", detalles));

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
        public static List<ClsEncuestas> ObtenerBitacora()
        {
            int retorno = 0;
            SqlConnection Conn = new SqlConnection();

            try
            {
                using (Conn = Clases.DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("Sp_Encuesta", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    retorno = cmd.ExecuteNonQuery();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ClsEncuestas bitacora = new ClsEncuestas();
                            bitacora.BitacoraID = reader.GetInt32(0);
                            bitacora.Accion = reader.GetString(1);
                            bitacora.FechaRegistro = reader.GetDateTime(2);
                            bitacora.Detalles = reader.GetString(3);
                            EncuestasP.Add(bitacora);
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