using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoPets.Models
{
    public class ProdutoDoPedido
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        [ForeignKey("Produto")]
        public int IdProduto { get; set; }
        [ForeignKey("Pedido")]
        public int IdPedido { get; set; }
        public Pedido Pedido { get; set; }
        public Produto Produto { get; set; }
    }
}