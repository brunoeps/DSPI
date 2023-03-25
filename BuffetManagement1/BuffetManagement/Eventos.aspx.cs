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

        private MySqlConnection connection;

        protected void Page_Load(object sender, EventArgs e)
        {

            connection = new MySqlConnection(SiteMaster.ConnectionString);
            if (!IsPostBack)
            {
                connection.Open();
                var reader = new MySqlCommand("SELECT nome from clientes", connection).ExecuteReader();
                while (reader.Read())
                {
                    ddlCliente.Items.Add(reader.GetString(0));
                }

                connection.Close();

                connection.Open();

                reader = new MySqlCommand("SELECT nome from pacotes", connection).ExecuteReader();
                while (reader.Read())
                {
                    ddlPacote.Items.Add(reader.GetString(0));
                }

                connection.Close();
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

        protected void ddlPacote_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();

            var reader = new MySqlCommand("SELECT preco from pacotes where nome = @nome", connection);
            reader.Parameters.AddWithValue("@nome", ddlPacote.Text); // substitua 'nomeDoPacote' pelo valor correto
            var preco = (float)reader.ExecuteScalar(); // use ExecuteScalar para recuperar apenas um valor

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

                var reader = new MySqlCommand("SELECT preco from pacotes where nome = @nome", connection);
                reader.Parameters.AddWithValue("@nome", ddlPacote.Text); // substitua 'nomeDoPacote' pelo valor correto
                var preco = (float)reader.ExecuteScalar(); // use ExecuteScalar para recuperar apenas um valor

                int quantidade = Convert.ToInt32(txtQuantidade.Text);
                float valorTotal = quantidade * preco;
                txtValor.Text = valorTotal.ToString("C"); // exibe o valor formatado como moeda na label

                connection.Close();
            }
        }

        protected void grdEventos_RowCommand1(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void grdEventos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }
    }
}