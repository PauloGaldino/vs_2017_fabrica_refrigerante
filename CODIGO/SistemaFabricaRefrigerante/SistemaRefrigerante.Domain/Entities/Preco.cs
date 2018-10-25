namespace SistemaRefrigerante.Domain.Entities
{
    public class Preco
    {
        public int ProdutoId { get; set; }
        public decimal Preco1 { get; set; }

        public Produto Produto { get; set; }
    }
}