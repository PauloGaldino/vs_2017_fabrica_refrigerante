
using System.Collections.Generic;

namespace SistemaRefrigerante.Domain.Entities
{
    public class FilialPessoa
    {
        public FilialPessoa()
        {
            Estoque = new HashSet<Estoque>();
            EstoqueMovimentado = new HashSet<EstoqueMovimentado>();
        }

        public int PessoaFilialId { get; set; }

        public Pessoa PessoaFilial { get; set; }
        public ICollection<Estoque> Estoque { get; set; }
        public ICollection<EstoqueMovimentado> EstoqueMovimentado { get; set; }
    }
}
