using examenFinalBALM.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace examenFinalBALM
{
    public partial class ReporteGenero : System.Web.UI.Page
    {
        List<ClsReportes> Encuestas = ClsReportes.ObtenerReportes();
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
            repeaterGenero.DataSource = null;
            repeaterGenero.DataBind();
        }

        private void CargarEncuestas()
        {
            LimpiarTabla();
            Encuestas = ClsReportes.ObtenerReportes();
            repeaterGenero.DataSource = Encuestas;
            repeaterGenero.DataBind();
        }
    }
}