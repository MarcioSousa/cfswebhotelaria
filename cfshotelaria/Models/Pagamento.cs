using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cfshotelaria.Models
{
    public class Pagamento
    {
        public long PagamentoId { get; set; }
        public String Forma { get; set; }
        public DateTime DataPagamento { get; set; }

        public long ClienteId { get; set; }
        public Cliente Cliente { get; set; }

    }
}