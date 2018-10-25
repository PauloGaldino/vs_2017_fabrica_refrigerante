namespace SistemaRefrigerante.Domain.Entities
{
    public class EmailPessoa
    {
        public int EmailPessoaId { get; set; }
        public string EnderecoEmail { get; set; }

        public Pessoa EmailPessoaNavigation { get; set; }
    }
}
