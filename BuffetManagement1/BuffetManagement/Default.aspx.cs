using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySqlConnector;

namespace BuffetManagement
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var evento = new Negócio.Evento().Read(0, 0, 0, "", 0, "", "");
            Session["dados"] = evento;
            grdEventos.DataSource = evento;
            grdEventos.DataBind();
        }

        protected void grdEventos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            var evento = (List<Modelo.Evento>)Session["dados"];
            grdEventos.PageIndex = e.NewPageIndex;
            grdEventos.DataSource = evento;
            grdEventos.DataBind();
        }
    }
}