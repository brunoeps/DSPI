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
                var comando = new MySqlCommand($@"INSERT INTO pacotes (nome, preco) VALUES (@nome, @preco)", connection);
                comando.Parameters.Add(new MySqlParameter("nome", pacotes.Nome));
                comando.Parameters.Add(new MySqlParameter("preco", pacotes.PrecoPP));
                comando.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }
        public List<Modelo.Pacotes> Read(string nome, string preco, int id)
        {
            var packs = new List<Modelo.Pacotes>();
            try
            {
                connection.Open();
                var comando = new MySqlCommand("select * from pacotes WHERE (1=1) ", connection);
                if (nome.Equals("") == false)
                {
                    comando.CommandText += $"and nome LIKE @nome";
                    comando.Parameters.Add(new MySqlParameter("nome", $"%{nome}%"));
                }

                if (preco.Equals("") == false)
                {
                    comando.CommandText += $"and preco = @preco";
                    comando.Parameters.Add(new MySqlParameter("preco", preco));
                }

                if (id != 0)
                {
                    comando.CommandText += $"and id = @id";
                    comando.Parameters.Add(new MySqlParameter("id", id));
                }

                var reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    var pacotes = new Modelo.Pacotes();
                    pacotes.Nome = reader.GetString("nome");
                    pacotes.PrecoPP = reader.GetFloat("preco");
                    pacotes.Id = reader.GetInt32("id");
                    packs.Add(pacotes);                 
                }
                connection.Close();
            }
            catch { }
            return packs;
        }
        public bool Update(Modelo.Pacotes pacotes)
        {
            try
            {
                connection.Open();
                var comando = new MySqlCommand($@"UPDATE pacotes SET nome = @nome, preco = @preco, WHERE id = @id", connection);
                comando.Parameters.Add(new MySqlParameter("nome", pacotes.Nome));
                comando.Parameters.Add(new MySqlParameter("preco", pacotes.PrecoPP));
                comando.Parameters.Add(new MySqlParameter("id", pacotes.Id));
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
                var comando = new MySqlCommand("DELETE FROM pacotes WHERE id = " + id, connection);
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
