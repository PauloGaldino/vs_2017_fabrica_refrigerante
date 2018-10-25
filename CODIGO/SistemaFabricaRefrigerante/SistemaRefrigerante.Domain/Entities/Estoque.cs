
namespace SistemaRefrigerante.Domain.Entities
{
    public class Estoque
    {
        public int PessoaFilialId { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public FilialPessoa PessoaFilial { get; set; }
        public Produto Produto { get; set; }
        public EstoqueReservado EstoqueReservado { get; set; }
    }
}
