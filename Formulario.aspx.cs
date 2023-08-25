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
        protected void Page_Load(object sender, EventArgs e)
        {

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
            int resultado = ClsEncuestas.AgregarEncuestas(tnombre.Text,tGenero.Text,tedad.Text,tcorreo.Text,tpartido.Text);

            if (resultado > 0)
            {
                alertas("Usuario ha sido ingresado con exito");
            }
            else
            {
                alertas("Error al ingresar Usuario");
            }
        }
    }
}