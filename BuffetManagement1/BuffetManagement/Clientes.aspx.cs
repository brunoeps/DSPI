using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BuffetManagement.Modelo;

namespace BuffetManagement
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastraCliente_Click(object sender, EventArgs e)
        {
            Modelo.Cliente NovoCliente = new Modelo.Cliente();
            NovoCliente.Nome = txtNomeCliente.Text;
            NovoCliente.Cpf = txtCPFCliente.Text;
            NovoCliente.Telefone = txtTelefoneCliente.Text;

            Negócio.Cliente AcoesCliente = new Negócio.Cliente();
            AcoesCliente.Create(NovoCliente);
        }

        protected void btnPesquisaCliente_Click(object sender, EventArgs e)
        {
            var clientes = new Negócio.Cliente().Read(txtNomeCliente.Text, txtCPFCliente.Text, txtTelefoneCliente.Text);
            Session["dados"] = clientes;
            grdClientes.DataSource = clientes;
            grdClientes.DataBind();
        }

        protected void grdClientes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            var clientes = (List<Cliente>)Session["dados"];

            if (e.CommandName == "excluir")
            {
                if (new Negócio.Cliente().Delete(clientes[index].Id))
                    SiteMaster.ExibirAlert(this, "Cliente excluído com sucesso!");
                else
                    SiteMaster.ExibirAlert(this, "O cliente não pode ser excluído porque ele está sendo usado!");
                btnPesquisaCliente_Click(null, null);
            }

            if (e.CommandName == "editar")
            {
                Response.Redirect("EditarCliente.aspx?id=" + clientes[index].Id);
            }
        }

        protected void grdClientes_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            var clientes = (List<Cliente>)Session["dados"];
            grdClientes.PageIndex = e.NewPageIndex;
            grdClientes.DataSource = clientes;
            grdClientes.DataBind();
        }
    }
}