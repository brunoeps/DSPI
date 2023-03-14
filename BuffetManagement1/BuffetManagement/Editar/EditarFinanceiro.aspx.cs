using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BuffetManagement.Editar
{
    public partial class EditarFinanceiro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                string Id = Request.QueryString["Id"].ToString();
                var financeiro = new Negócio.Financeiro().Read("", "", Convert.ToInt32(Id),"");
            }
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            Modelo.Financeiro EditaLancamento = new Modelo.Financeiro();
            EditaLancamento.Fornecedor = txtNomeFonecedor.Text;
            EditaLancamento.Valor = float.Parse(txtValor.Text);
            EditaLancamento.Id = Convert.ToInt32(Request.QueryString["Id"].ToString());
            EditaLancamento.Vencimento = Convert.ToDateTime (TxtVencimento.Text);
            
            Negócio.Financeiro Acoesfinanceiro = new Negócio.Financeiro();
            Acoesfinanceiro.Update(EditaLancamento);
        }
    }
}