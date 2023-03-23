using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySqlConnector;


namespace BuffetManagement
{
    public partial class Dashboard : System.Web.UI.Page
    {
        private MySqlConnection connection;
        protected void Page_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection(SiteMaster.ConnectionString);

            connection.Open();
            var command = new MySqlCommand("SELECT COUNT(*) FROM clientes WHERE 1 = 1", connection);
            var reader = command.ExecuteReader();
            reader.Read();
            lblClientes.Text = reader.GetInt16(0).ToString();
            connection.Close();

            connection.Open();
            command = new MySqlCommand("SELECT COUNT(*) FROM pacotes WHERE 1 = 1", connection);
            reader = command.ExecuteReader();
            reader.Read();
            lblPacotes.Text = reader.GetInt16(0).ToString();
            connection.Close();

            connection.Open();
            command = new MySqlCommand("SELECT SUM(valor) FROM financeiro WHERE MONTH(vencimento) = 2 AND YEAR(vencimento) = 2023", connection);
            reader = command.ExecuteReader();
            reader.Read();
            lblFinanceiro.Text = reader.GetFloat(0).ToString("C");
            connection.Close();

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // Obtém a data selecionada no campo de entrada de data
            string selectedDate = Request.Form["dateInput"];

            // Converte a data selecionada para o formato desejado
            DateTime date = Convert.ToDateTime(selectedDate);

            connection.Open();
            // Constrói a consulta SQL para buscar dados do banco de dados filtrando pela data selecionada
            var command = new MySqlCommand ("SELECT `valor` FROM `financeiro` WHERE vencimento = '" + date.ToString("yyyy-MM-dd") + "'", connection);
            var reader = command.ExecuteReader();
            // Executa a consulta SQL e obtém os dados do banco de dados
            // Aqui você precisaria usar o código apropriado para sua plataforma de banco de dados específica,
            // por exemplo, usando um objeto SqlConnection no .NET Framework ou um objeto MySqlConnection no MySQL.
            // O código a seguir é apenas um exemplo hipotético.

            {

               
                // Faz algo com os dados retornados da consulta
                // Por exemplo, exibe-os em uma grade ou em um rótulo
                while (reader.Read())
                {
                    // Obtém o valor de uma coluna específica dos dados retornados
                    string columnValue = reader.GetString(0);

                    // Faz algo com o valor da coluna, por exemplo, exibe-o em um rótulo
                    lblFinanceiro.Text = "Valor: " + columnValue;
                    connection.Close();
                }
            }
        }
    }
}