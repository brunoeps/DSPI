using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuffetManagement.Negócio
{
    public class Pacotes
    {
        private MySqlConnection connection;

        public Pacotes()
        {
            connection = new MySqlConnection(SiteMaster.ConnectionString);
        }
        public bool Create(Modelo.Pacotes pacotes)
        {
            try
            {
                connection.Open();
                var comando = new MySqlCommand($@"INSERT INTO pacotes (nome, preco) VALUES (@nome, preco)", connection);
                comando.Parameters.Add(new MySqlParameter("nome", pacotes.Nome));
                comando.Parameters.Add(new MySqlParameter("cpf", pacotes.PrecoPP));
                comando.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }
    }
}