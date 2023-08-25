using examenFinalBALM.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace examenFinalBALM
{
    public partial class Reporte : System.Web.UI.Page
    {
        List<ClsEncuestas> encuestas = ClsEncuestas.ObtenerEncuestas();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarClientes();
            }
            else
            {

            }
        }
        private void LimpiarTabla()
        {
            encuestas.Clear();
            repeaterEncuestas.DataSource = null;
            repeaterEncuestas.DataBind();
        }

        private void CargarClientes()
        {
            LimpiarTabla();
            encuestas = ClsEncuestas.ObtenerEncuestas();
            repeaterEncuestas.DataSource = encuestas;
            repeaterEncuestas.DataBind();
        }


    }
}