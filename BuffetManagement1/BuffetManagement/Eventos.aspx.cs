using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BuffetManagement.Modelo;
using Serilog;

namespace BuffetManagement
{
    public partial class Pedidos : System.Web.UI.Page
    {
        private MySqlConnection connection;

        protected void Page_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection(SiteMaster.ConnectionString);
            if (!IsPostBack)
            {
                connection.Open();
                var reader = new MySqlCommand("SELECT nome, id from clientes", connection).ExecuteReader();
                while (reader.Read())
                {
                    ddlCliente.Items.Add(new ListItem(reader.GetString(0), reader.GetInt32(1).ToString()));
                }

                connection.Close();

                connection.Open();

                reader = new MySqlCommand("SELECT nome, id from pacotes", connection).ExecuteReader();
                while (reader.Read())
                {
                    ddlPacote.Items.Add(new ListItem(reader.GetString(0), reader.GetInt32(1).ToString()));
                }
                connection.Close();


            }
        }

        protected void btnPesquisaEvento_Click(object sender, EventArgs e)
        {
            int idCliente;
            int.TryParse(ddlCliente.Text, out idCliente);

            int idPacotes;
            int.TryParse(ddlPacote.Text, out idPacotes);

            var evento = new Negócio.Evento().Read(idCliente, idPacotes, 0, txtValor.Text, Convert.ToInt32(txtQuantidade.Text));
            Session["dados"] = evento;
            grdEventos.DataSource = evento;
            grdEventos.DataBind();
        }

        protected void btnCadastraEvento_Click(object sender, EventArgs e)
        {
            try
            {
                Modelo.Evento NovoEvento = new Modelo.Evento();
                NovoEvento.IdCliente = Convert.ToInt32(ddlCliente.SelectedValue);
                NovoEvento.IdPacote = Convert.ToInt32(ddlPacote.SelectedValue);
                NovoEvento.Id = Convert.ToInt32(Request.QueryString["Id"].ToString());
                NovoEvento.Valor = float.Parse(txtValor.Text);
                NovoEvento.Quantidade = Convert.ToInt32(txtQuantidade.Text);

                Negócio.Evento AcoesEvento = new Negócio.Evento();
                AcoesEvento.Create(NovoEvento);

                SiteMaster.ExibirAlert(this, "Evento cadastrado com sucesso!");
                ddlCliente.Text = "";
                ddlPacote.Text = "";
                txtQuantidade.Text = "";
                txtValor.Text = "";
            }
            catch (Exception er)
            {
                SiteMaster.ExibirAlert(this, "Erro no cadastro!");
                Log.Error("Erro! " + er.Message);
            }
        }


        protected void grdEventos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            var evento = (List<Modelo.Evento>)Session["dados"];

            if (e.CommandName == "excluir")
            {
                if (new Negócio.Financeiro().Delete(evento[index].Id))
                    SiteMaster.ExibirAlert(this, "Evento excluído com sucesso!");
                else
                    SiteMaster.ExibirAlert(this, "O evento não pode ser excluído porque ele está sendo usado!");
                btnPesquisaEvento_Click(null, null);
            }

            if (e.CommandName == "editar")
            {
                Response.Redirect("Editar/EditarEvento.aspx?id=" + evento[index].Id);
            }
        }

        protected void ddlPacote_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();

            var comando = new MySqlCommand("SELECT preco from pacotes where id = @id", connection);
            comando.Parameters.AddWithValue("@id", ddlPacote.SelectedValue);
            var reader = comando.ExecuteReader();
            reader.Read();
            var preco = reader.GetFloat("preco");

            int quantidade = Convert.ToInt32(txtQuantidade.Text);
            float valorTotal = quantidade * preco;
            txtValor.Text = valorTotal.ToString("C"); // exibe o valor formatado como moeda na label

            connection.Close();
        }

        protected void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            int value;
            if (!int.TryParse(txtQuantidade.Text, out value))
            {
                // Se o valor inserido não for um número inteiro, exibe uma mensagem de erro.
                Response.Write("<script>alert('Insira somente números inteiros');</script>");
                txtQuantidade.Text = "";

            }

            else
            {
                connection.Open();

                var comando = new MySqlCommand("SELECT preco from pacotes where id = @id", connection);
                comando.Parameters.AddWithValue("@id", ddlPacote.SelectedValue);
                var reader = comando.ExecuteReader();
                reader.Read();
                var preco = reader.GetFloat("preco");
                int quantidade = Convert.ToInt32(txtQuantidade.Text);
                float valorTotal = quantidade * preco;

                txtValor.Text = valorTotal.ToString("C"); // exibe o valor formatado como moeda na label

                connection.Close();
            }

            if (Convert.ToInt32(txtQuantidade.Text) > 0)
            {
                btnCadastraEvento.Enabled = true;
            }
        }

        protected void grdEventos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            var evento = (List<Evento>)Session["dados"];
            grdEventos.PageIndex = e.NewPageIndex;
            grdEventos.DataSource = evento;
            grdEventos.DataBind();
        }

    }
}