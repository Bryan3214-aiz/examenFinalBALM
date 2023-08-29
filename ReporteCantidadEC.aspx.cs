using examenFinalBALM.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace examenFinalBALM
{
    public partial class ReporteCantidadEC : System.Web.UI.Page
    {
        List<ClsCantidad> Cantidad = ClsCantidad.ObtenerCantidad();
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
            Cantidad.Clear();
            repeaterCantidad.DataSource = null;
            repeaterCantidad.DataBind();
        }

        private void CargarEncuestas()
        {
            LimpiarTabla();
            Cantidad = ClsCantidad.ObtenerCantidad();
            repeaterCantidad.DataSource = Cantidad;
            repeaterCantidad.DataBind();
        }
    }
}