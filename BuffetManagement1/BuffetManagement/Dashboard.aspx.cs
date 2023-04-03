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
            string selectedDate = data.Text;
            DateTime date = Convert.ToDateTime(selectedDate);
            connection.Open();

            var command = new MySqlCommand("SELECT IFNULL(SUM(`valor`),0) valor FROM `financeiro` WHERE `vencimento` = '" + date.ToString("yyyy-MM-dd") + "'", connection);
            var reader = command.ExecuteReader();

            if (reader.Read())
            {
                var columnValue = reader.GetFloat("valor").ToString("C");
                lblFinanceiro.Text = "Valor: " + Convert.ToString(columnValue);
                connection.Close();
            }
        }
    }
}
