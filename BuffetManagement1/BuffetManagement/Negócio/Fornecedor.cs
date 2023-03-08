using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuffetManagement.Negócio
{
    public class Fornecedor
    {
        private MySqlConnection connection;

        public Fornecedor()
        {
            connection = new MySqlConnection(SiteMaster.ConnectionString);
        }
    }
}