using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BuffetManagement
{
    public partial class SiteMaster : MasterPage
    {
        public static string ConnectionString = "Server=mysql5025.site4now.net;User ID=a95eb6_dspi;Password=sa*100200300;Database=db_a95eb6_dspi";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public static void ExibirAlert(Page page, string mensagem)
        {
            page.ClientScript.RegisterStartupScript(
                 page.GetType(),
                 "MessageBox" + Guid.NewGuid(),
                 "<script language='javascript'>alert('" + mensagem + "');</script>");
        }

        public static void ExibirAlert(Page page, string mensagem, string pagina)
        {
            page.ClientScript.RegisterStartupScript(
                 page.GetType(),
                 "MessageBox" + Guid.NewGuid(),
                 "<script language='javascript'>alert('" + mensagem + "');window.location = '" + pagina + "';</script>");
        }
    }
}