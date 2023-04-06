using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySqlConnector;

namespace BuffetManagement.Editar
{
    public partial class EditarFinanceiro : System.Web.UI.Page
    {
        private MySqlConnection connection;
        protected void Page_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection(SiteMaster.ConnectionString);
            if (IsPostBack == false)
            {
                string Id = Request.QueryString["Id"].ToString();
                var financeiro = new Negócio.Financeiro().Read("", "", Convert.ToInt32(Id), "");
            }
            //if (IsPostBack == false)
            //{
            //    if (!IsPostBack)
            //    {
            //        var id = Request.QueryString["id"].ToString();

            //        connection.Open();
            //        var comando = new MySqlCommand($@"SELECT `nome`, `cpf`, `telefone`, `id` FROM `clientes` WHERE `id`= " + Convert.ToInt32(id), connection);
            //        using (var reader = comando.ExecuteReader())
            //        {
            //            while (reader.Read())
            //            {
            //                txtNome.Text = reader.GetString("nome");
            //                txtCPF.Text = reader.GetString("cpf");
            //                txtTelefone.Text = reader.GetString("telefone");

            //            }
            //        }
            //        connection.Close();
            //    }
            //}
        }
        protected void btnEditar_Click(object sender, EventArgs e)
        {
            Modelo.Financeiro EditaLancamento = new Modelo.Financeiro();
            EditaLancamento.Fornecedor = txtNomeFonecedor.Text;
            EditaLancamento.Valor = float.Parse(txtValor.Text);
            EditaLancamento.Id = Convert.ToInt32(Request.QueryString["Id"].ToString());
            EditaLancamento.Vencimento = Convert.ToDateTime(TxtVencimento.Text);

            Negócio.Financeiro Acoesfinanceiro = new Negócio.Financeiro();
            Acoesfinanceiro.Update(EditaLancamento);
        }
    }
}