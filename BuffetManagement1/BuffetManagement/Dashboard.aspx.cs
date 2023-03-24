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
        }

        protected void data_TextChanged(object sender, EventArgs e)
        {
            string selectedDate = Request.Form["dateInput"];
            DateTime date = Convert.ToDateTime(selectedDate);
            connection.Open();

            var command = new MySqlCommand("SELECT `valor` FROM `financeiro` WHERE vencimento = '" + date.ToString("yyyy-MM-dd") + "'", connection);
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                string columnValue = reader.GetString(0);
                lblFinanceiro.Text = "Valor: " + columnValue;
                connection.Close();
            }
        }
    }
}
