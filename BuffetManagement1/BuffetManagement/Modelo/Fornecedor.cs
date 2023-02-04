using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuffetManagement.Modelo
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
        public DateTime Vencimento { get; set; }
    }
}