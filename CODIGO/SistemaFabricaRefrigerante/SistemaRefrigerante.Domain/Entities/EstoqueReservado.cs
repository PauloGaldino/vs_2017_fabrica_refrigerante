namespace SistemaRefrigerante.Domain.Entities
{
    public class EstoqueReservado
    {
        public int PessoaFilialId { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public Estoque P { get; set; }
    }
}