using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cfshotelaria.Models
{
    public class Cliente
    {
        public long ClienteId { get; set; }
        public string Nome { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string Contato { get; set; }
        public DateTime DataOcupacao { get; set; }

        public long QuartoId { get; set; }
        public Quarto Quarto { get; set; }
        public virtual ICollection<Pagamento> Pagamentos { get; set; }

    }
}