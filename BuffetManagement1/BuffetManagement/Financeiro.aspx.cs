using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BuffetManagement
{
    public partial class Financeiro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnPesquisaGasto_Click(object sender, EventArgs e)
        {
            var financeiro = new Negócio.Financeiro().Read(txtFornecedor.Text, txtValor.Text, 0, txtDataVencimento.Text);
            Session["dados"] = financeiro;
            grdFinanceiro.DataSource = financeiro;
            grdFinanceiro.DataBind();
        }

        protected void btnCadastraGasto_Click(object sender, EventArgs e)
        {
            try
            {
                Modelo.Financeiro NovoLancamento = new Modelo.Financeiro();
                NovoLancamento.Fornecedor = txtFornecedor.Text;
                NovoLancamento.Valor = float.Parse(txtValor.Text);
                NovoLancamento.Vencimento = Convert.ToDateTime(txtDataVencimento.Text);

                Negócio.Financeiro Acoesfinanceiro = new Negócio.Financeiro();
                Acoesfinanceiro.Create(NovoLancamento);

                SiteMaster.ExibirAlert(this, "Lançamento cadastrado com sucesso!");
                txtFornecedor.Text = "";
                txtValor.Text = "";
                txtDataVencimento.Text = "";
            }
            catch (Exception er)
            {
                SiteMaster.ExibirAlert(this, "Erro no lançamento!");
                Log.Error("Erro! " + er.Message);
            }
        }

        protected void grdFinanceiro_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            var financeiro = (List<Modelo.Financeiro>)Session["dados"];

            if (e.CommandName == "excluir")
            {
                if (new Negócio.Financeiro().Delete(financeiro[index].Id))
                    SiteMaster.ExibirAlert(this, "Lançamento excluído com sucesso!");
                else
                    SiteMaster.ExibirAlert(this, "O lançamento não pode ser excluído porque ele está sendo usado!");
                btnPesquisaGasto_Click(null, null);
            }

            if (e.CommandName == "editar")
            {
                Response.Redirect("Editar/EditarFinanceiro.aspx?id=" + financeiro[index].Id);
            }
        }

        protected void grdFinanceiro_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            var financeiro = (List<Financeiro>)Session["dados"];
            grdFinanceiro.PageIndex = e.NewPageIndex;
            grdFinanceiro.DataSource = financeiro;
            grdFinanceiro.DataBind();
        }
    }
}