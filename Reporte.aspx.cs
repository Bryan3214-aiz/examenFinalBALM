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
        List<ClsEncuestas> Encuestas = ClsEncuestas.ObtenerEncuestas();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarEncuestas();
            }
            else
            {

            }
        }
        private void LimpiarTabla()
        {
            Encuestas.Clear();
            repeaterEncuestas.DataSource = null;
            repeaterEncuestas.DataBind();
        }

        private void CargarEncuestas()
        {
            LimpiarTabla();
            Encuestas = ClsEncuestas.ObtenerEncuestas();
            repeaterEncuestas.DataSource = Encuestas;
            repeaterEncuestas.DataBind();
        }
    }
}