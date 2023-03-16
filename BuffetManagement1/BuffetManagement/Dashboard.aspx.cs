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

    }
}