using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuffetManagement.Negócio
{
    public class Evento
    {
        private MySqlConnection connection;

        public Evento()
        {
            connection = new MySqlConnection(SiteMaster.ConnectionString);
        }
        public bool Create(Modelo.Evento evento)
        {
            try
            {
                connection.Open();
                var comando = new MySqlCommand($@"INSERT INTO eventos (id_cliente, id_pacotes, quantidade, valor, data_evento, observacao) VALUES (@id_cliente, @id_pacotes, @quantidade, @valor, @data_evento, @observacao)", connection);
                comando.Parameters.Add(new MySqlParameter("id_cliente", evento.IdCliente));
                comando.Parameters.Add(new MySqlParameter("id_pacotes", evento.IdPacote));
                comando.Parameters.Add(new MySqlParameter("quantidade", evento.Quantidade));
                comando.Parameters.Add(new MySqlParameter("valor", evento.Valor));
                comando.Parameters.Add(new MySqlParameter("data_evento", evento.Data_evento));
                comando.Parameters.Add(new MySqlParameter("observacao", evento.Observacao));
                comando.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }
        public List<Modelo.Evento> Read(int id_cliente, int id_pacotes, int id, string valor, int quantidade, string data_evento, string observacao)
        {
            var packs = new List<Modelo.Evento>();
            try
            {
                connection.Open();
                var comando = new MySqlCommand("select * from eventos WHERE (1=1) ", connection);
                if (id_cliente != 0)
                {
                    comando.CommandText += $" and id_cliente LIKE @id_cliente";
                    comando.Parameters.Add(new MySqlParameter("id_cliente", id_cliente));
                }

                if (id_pacotes != 0)
                {
                    comando.CommandText += $" and id_pacotes LIKE @id_pacotes";
                    comando.Parameters.Add(new MySqlParameter("id_pacotes", id_pacotes));
                }

                if (id != 0)
                {
                    comando.CommandText += $" and id = @id";
                    comando.Parameters.Add(new MySqlParameter("id", id));
                }

                if (valor.Equals("") == false)
                {
                    comando.CommandText += $" and valor = @valor";
                    comando.Parameters.Add(new MySqlParameter("valor", valor));
                }

                if (quantidade > 0)
                {
                    comando.CommandText += $" and quantidade = @quantidade";
                    comando.Parameters.Add(new MySqlParameter("quantidade", quantidade));
                }

                if (data_evento.Equals("") == false)
                {
                    comando.CommandText += $"and data_evento = @data_evento";
                    comando.Parameters.Add(new MySqlParameter("data_evento", data_evento));
                }
                if (observacao.Equals("") == false)
                {
                    comando.CommandText += $"and observacao LIKE @observacao";
                    comando.Parameters.Add(new MySqlParameter("observacao", $"%{observacao}%"));
                }

                var reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    var evento = new Modelo.Evento();
                    evento.IdCliente = reader.GetInt32("id_cliente");
                    evento.Cliente = new Negócio.Cliente().Read("", "", "", evento.IdCliente).FirstOrDefault();
                    evento.IdPacote = reader.GetInt32("id_pacotes");
                    evento.Pacotes = new Negócio.Pacotes().Read("", "", evento.IdPacote).FirstOrDefault();
                    evento.Id = reader.GetInt32("id");
                    evento.Valor = reader.GetFloat("valor");
                    evento.Quantidade = reader.GetInt32("quantidade");
                    evento.Data_evento = reader.GetDateTime("data_evento");
                    evento.Observacao = reader.GetString("observacao");

                    packs.Add(evento);
                }
                connection.Close();
            }
            catch (Exception erro)
            {
            }
            return packs;
        }
        public bool Update(Modelo.Evento evento)
        {
            try
            {
                connection.Open();
                var comando = new MySqlCommand($@"UPDATE eventos SET id_cliente = @id_cliente, id_pacotes = @id_pacotes, quantidade = @quantidade, valor = @valor, data_evento = @data_evento, observacao = @observacao WHERE id = @id", connection);
                comando.Parameters.Add(new MySqlParameter("id_cliente", evento.IdCliente));
                comando.Parameters.Add(new MySqlParameter("id_pacotes", evento.IdPacote));
                comando.Parameters.Add(new MySqlParameter("quantidade", evento.Quantidade));
                comando.Parameters.Add(new MySqlParameter("valor", evento.Valor));                
                comando.Parameters.Add(new MySqlParameter("data_evento", evento.Data_evento));
                comando.Parameters.Add(new MySqlParameter("observacao", evento.Observacao));
                comando.Parameters.Add(new MySqlParameter("id", evento.Id));
                comando.ExecuteNonQuery();
                connection.Close();
            }

            catch(Exception err)
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
                var comando = new MySqlCommand("DELETE FROM eventos WHERE id = " + id, connection);
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