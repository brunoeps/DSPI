using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BuffetManagement.Modelo;
using Serilog;
using MySqlConnector;

namespace BuffetManagement.Editar
{
    public partial class EditarEvento : System.Web.UI.Page
    {
        private MySqlConnection connection;

        protected void Page_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection(SiteMaster.ConnectionString);
            if (IsPostBack == false)
            {
                connection.Open();
                string Id = Request.QueryString["Id"].ToString();
                var evento = new Negócio.Evento().Read(0, 0, Convert.ToInt32(Id), "", 0);

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
                btnEditar.Enabled = true;
            }
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            Modelo.Evento EditaEvento = new Modelo.Evento();
            EditaEvento.IdCliente = Convert.ToInt32(ddlCliente.SelectedValue);
            EditaEvento.IdPacote = Convert.ToInt32(ddlPacote.SelectedValue);
            EditaEvento.Id = Convert.ToInt32(Request.QueryString["Id"].ToString());
            EditaEvento.Quantidade = Convert.ToInt32(txtQuantidade.Text);
            EditaEvento.Valor = float.Parse(txtValor.Text.Replace("R$", "").Replace(" ", ""));

            Negócio.Evento AcoesEvento = new Negócio.Evento();
            AcoesEvento.Update(EditaEvento);

            SiteMaster.ExibirAlert(this, "Alterado com sucesso", "../Eventos.aspx");
        }
    }
}