using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cfshotelaria.Models
{
    public class Entrada
    {
        public long EntradaId { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataVencimento { get; set; }
        public int Quantidade { get; set; }

        public long ProdutoId { get; set; }
        public Produto Produto { get; set; }

    }
}