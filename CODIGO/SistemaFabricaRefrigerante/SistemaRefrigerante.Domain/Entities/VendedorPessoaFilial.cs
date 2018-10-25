using System.Collections.Generic;

namespace SistemaRefrigerante.Domain.Entities
{
    public class VendedorPessoaFilial
    {
        public VendedorPessoaFilial()
        {
            EstoqueMovimentado = new HashSet<EstoqueMovimentado>();
        }

        public int VendedorPessoaId { get; set; }
        public int VendedorPessoaFilialTipoId { get; set; }

        public Pessoa VendedorPessoa { get; set; }
        public VendedorPessoaFlilalTipo VendedorPessoaFilialTipo { get; set; }
        public ICollection<EstoqueMovimentado> EstoqueMovimentado { get; set; }
    }
}