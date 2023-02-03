using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuffetManagement.Modelo
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
    }
}