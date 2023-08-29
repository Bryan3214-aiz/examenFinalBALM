using examenFinalBALM.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.DataVisualization.Charting;
using System.Web.UI.WebControls;

namespace examenFinalBALM
{
    public partial class Formulario1 : System.Web.UI.Page
    {
        List<ClsEncuestas> Encuestas = ClsEncuestas.ObtenerReportes();
        public void LimpiarCampos()
        {
            tnombre.Text = string.Empty;
            tedad.Text = string.Empty;
            tcorreo.Text = string.Empty;
        }
        public void alertas(String texto)
        {
            string message = texto;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("<script type = 'text/javascript'>");
            sb.Append("window.onload=function(){");
            sb.Append("alert('");
            sb.Append(message);
            sb.Append("')};");
            sb.Append("</script>");
            ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());

        }
        protected void EnviarEncuesta_Click(object sender, EventArgs e)
        {
            int resultado = ClsEncuestas.AgregarEncuestas(tnombre.Text, tGenero.Text, tedad.Text, tcorreo.Text, tpartido.Text);  

            if (IsValid)
            {
                if (resultado > 0)
                {
                    alertas("Encuesta enviada correctamente, gracias por participar :)");
                }
                else
                {
                    alertas("Error al enviar los datos, intentalo de nuevo :(");
                }
            }
        }
    }
}