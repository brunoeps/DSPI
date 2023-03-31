using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuffetManagement.Modelo
{
    public class Evento
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; }
        public int IdPacote { get; set; }
        public Pacotes Pacotes { get; set; }
        public int Quantidade { get; set; }
        public float Valor { get; set; }
        public string Observacao { get; set; }
        public DateTime Data_evento { get; set; }
    }
}