using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cfshotelaria.Models
{
    public class Quarto
    {
        public long QuartoId { get; set; }
        public int Numero { get; set; }
        public double ValorDiaria { get; set; }

        public virtual ICollection<Pedido> Pedidos { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }

    }
}