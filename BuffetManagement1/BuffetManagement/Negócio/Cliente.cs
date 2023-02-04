using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuffetManagement.Negócio
{
    public class Cliente
    {
        private MySqlConnection connection;

        public Cliente()
        {
            connection = new MySqlConnection(SiteMaster.ConnectionString);
        }
        public bool Create(Modelo.Cliente cliente)
        {
            try
            {
                connection.Open();
                var comando = new MySqlCommand($@"INSERT INTO clientes (nome, cpf, telefone) VALUES (@nome, @cpf, @telefone)", connection);
                comando.Parameters.Add(new MySqlParameter("nome", cliente.Nome));
                comando.Parameters.Add(new MySqlParameter("cpf", cliente.Cpf));
                comando.Parameters.Add(new MySqlParameter("telefone", cliente.Telefone));
                comando.ExecuteNonQuery();
                connection.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public List<Modelo.Cliente> Read(string nome, string cpf, string telefone)
        {
            var clientes = new List<Modelo.Cliente>();
            try
            {
                connection.Open();
                var comando = new MySqlCommand("select * from clientes WHERE (1=1) ", connection);
                if (nome.Equals("") == false)
                {
                    comando.CommandText += $"and nome LIKE @nome";
                    comando.Parameters.Add(new MySqlParameter("nome", $"%{nome}%"));
                }
                
                if (cpf.Equals("") == false)
                {
                    comando.CommandText += $"and cpf = @cpf";
                    comando.Parameters.Add(new MySqlParameter("cpf",cpf));
                }

                if (telefone.Equals("") == false)
                {
                    comando.CommandText += $"and telefone = @telefone";
                    comando.Parameters.Add(new MySqlParameter("telefone", telefone));
                }
                var reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    var cliente = new Modelo.Cliente();
                    cliente.Nome = reader.GetString("nome");
                    cliente.Cpf = reader.GetString("cpf");
                    cliente.Telefone = reader.GetString("telefone");
                    cliente.Id = reader.GetInt32("id");
                    clientes.Add(cliente);
                }
                connection.Close();
            }
            catch { }
            return clientes;
        }

        public bool Update(Modelo.Cliente cliente)
        {
            try
            {
                connection.Open();
                var comando = new MySqlCommand($@"UPDATE clientes SET nome = @nome, cpf = @cpf, telefone = @telefone WHERE id = @id", connection);
                comando.Parameters.Add(new MySqlParameter("nome", cliente.Nome));
                comando.Parameters.Add(new MySqlParameter("cpf", cliente.Cpf));
                comando.Parameters.Add(new MySqlParameter("telefone", cliente.Telefone));
                comando.Parameters.Add(new MySqlParameter("id", cliente.Id));
                comando.ExecuteNonQuery();
                connection.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool Delete(int id)
        {
            try
            {
                connection.Open();
                var comando = new MySqlCommand("DELETE FROM clientes WHERE id = " + id, connection);
                comando.ExecuteNonQuery();
                connection.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}