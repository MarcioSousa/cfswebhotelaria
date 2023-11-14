using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cfshotelaria.Models
{
    public class Pedido
    {
        public long PedidoId { get; set; }
        public DateTime DataPedido { get; set; }


        public long QuartoId { get; set; }
        public Quarto Quarto { get; set; }

    }
}