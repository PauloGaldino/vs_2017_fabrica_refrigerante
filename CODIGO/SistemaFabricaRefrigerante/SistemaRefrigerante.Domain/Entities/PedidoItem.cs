

namespace SistemaRefrigerante.Domain.Entities
{
    public class PedidoItem
    {
        public int PedidoId { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUntario { get; set; }
        public decimal PercentualDesconto { get; set; }
        public decimal ValorDesconto { get; set; }
        public decimal ValorTotal { get; set; }

        public Pedido Pedido { get; set; }
        public Produto Produto { get; set; }
    }
}
