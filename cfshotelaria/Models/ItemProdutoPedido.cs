using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cfshotelaria.Models
{
    public class ItemProdutoPedido
    {
        public long ItemProdutoPedidoId { get; set; }
        public int Qtde { get; set; }

        public long PedidoId { get; set; }
        public long ProdutoId { get; set; }

        public Pedido Pedido { get; set; }
        public Produto Produto { get; set; }

    }
}