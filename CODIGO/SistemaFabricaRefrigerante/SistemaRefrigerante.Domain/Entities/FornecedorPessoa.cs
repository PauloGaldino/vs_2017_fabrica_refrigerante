namespace SistemaRefrigerante.Domain.Entities
{
    public class FornecedorPessoa
    {
        public int FornecedorPessoaId { get; set; }

        public Pessoa FornecedorPessoaNavigation { get; set; }
    }
}