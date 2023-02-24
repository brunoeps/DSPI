using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySqlConnector;

namespace BuffetManagement
{
    public partial class Pedidos : System.Web.UI.Page
    {
        private int _contador;
        private MySqlConnection connection;

        protected void Page_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection(SiteMaster.ConnectionString);
            if (!IsPostBack)
            {
                contador.Text = hdnContador.Value;
            }
        }

        protected void btnCadastraEvento_Click(object sender, EventArgs e)
        {

        }

        protected void btnPesquisaEvento_Click(object sender, EventArgs e)
        {

        }

        protected void grdEventos_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void btnAdicionar_Click(object sender, EventArgs e)
        {
            // Incrementa o valor do contador
            int valorAtual = int.Parse(hdnContador.Value);
            valorAtual++;
            hdnContador.Value = valorAtual.ToString();
            contador.Text = hdnContador.Value;
        }

        protected void btnSubtrair_Click(object sender, EventArgs e)
        {
            // Subtrai o valor do contador, se possível
            int valorAtual = int.Parse(hdnContador.Value);
            if (valorAtual > 0)
            {
                valorAtual--;
                hdnContador.Value = valorAtual.ToString();
                contador.Text = hdnContador.Value;
            }
        }

        protected void ddlCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ddlPacote_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}