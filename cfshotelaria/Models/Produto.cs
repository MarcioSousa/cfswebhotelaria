using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cfshotelaria.Models
{
    public class Produto
    {
        public long ProdutoId { get; set; }
        public String Nome { get; set; }
        public Double Valor { get; set; }

        public virtual ICollection<Entrada> Entradas { get; set; }

    }
}