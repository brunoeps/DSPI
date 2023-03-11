using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuffetManagement.Negócio
{
    public class Financeiro

    {
        private MySqlConnection connection;

        public Financeiro()
        {
            connection = new MySqlConnection(SiteMaster.ConnectionString);
        }
         public bool Create(Modelo.Financeiro financeiro)
        {
            try
            {
                connection.Open();
                var comando = new MySqlCommand($@"INSERT INTO financeiro (fornecedor, valor, vencimento) VALUES (@fornecedor, @valor, @vencimento)", connection);
                comando.Parameters.Add(new MySqlParameter("fornecedor", financeiro.Fornecedor));
                comando.Parameters.Add(new MySqlParameter("valor", financeiro.Valor));
                comando.Parameters.Add(new MySqlParameter("vencimento", financeiro.Vencimento));
                comando.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }
        public List<Modelo.Financeiro> Read(string fornecedor, string valor, int id, string vencimento)
        {
            var packs = new List<Modelo.Financeiro>();
            try
            {
                connection.Open();
                var comando = new MySqlCommand("select * from pacotes WHERE (1=1) ", connection);
                if (fornecedor.Equals("") == false)
                {
                    comando.CommandText += $"and fornecedor LIKE @fornecedor";
                    comando.Parameters.Add(new MySqlParameter("nome", $"%{fornecedor}%"));
                }

                if (valor.Equals("") == false)
                {
                    comando.CommandText += $"and valor = @valor";
                    comando.Parameters.Add(new MySqlParameter("valor", valor));
                }

                if (id != 0)
                {
                    comando.CommandText += $"and id = @id";
                    comando.Parameters.Add(new MySqlParameter("id", id));
                }

                if (vencimento.Equals("") == false)
                {
                    comando.CommandText += $"and vencimento = @vencimento";
                    comando.Parameters.Add(new MySqlParameter("vencimento", vencimento));
                }

                var reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    var financeiro = new Modelo.Financeiro();
                    financeiro.Fornecedor = reader.GetString("fornecedor");
                    financeiro.Valor = reader.GetFloat("valor");
                    financeiro.Id = reader.GetInt32("id");
                    financeiro.Vencimento = reader.GetDateTime("vencimento");
                    packs.Add(financeiro);
                }
                connection.Close();
            }
            catch { }
            return packs;
        }
        public bool Update(Modelo.Financeiro financeiro)
        {
            try
            {
                connection.Open();
                var comando = new MySqlCommand($@"UPDATE pacotes SET fornecedor = @fornecedor, valor = @valor, vencimento =@vencimento WHERE id = @id", connection);
                comando.Parameters.Add(new MySqlParameter("fornecedor", financeiro.Fornecedor));
                comando.Parameters.Add(new MySqlParameter("valor", financeiro.Valor));
                comando.Parameters.Add(new MySqlParameter("vencimento", financeiro.Vencimento));
                comando.Parameters.Add(new MySqlParameter("id", financeiro.Id));
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
                var comando = new MySqlCommand("DELETE FROM financeiro WHERE id = " + id, connection);
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