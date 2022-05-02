using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoPets.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        [ForeignKey("Cliente")]
        public int IdCliente { get; set; }
        public DateTime DataDoPedido { get; set; }
        public DateTime? DataDeEntregaDoPedido { get; set; }
        public Cliente Cliente { get; set; }
        public ICollection<ProdutoDoPedido> ProdutosDoPedido { get; set; }
    }
}