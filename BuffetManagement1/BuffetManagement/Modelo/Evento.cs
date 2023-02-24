using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuffetManagement.Modelo
{
    public class Evento
    {
        public int Id { get; set; }
        public string Cliente { get; set; }
        public int Pacote { get; set; }
        public int Quantidade { get; set; }
    }
}