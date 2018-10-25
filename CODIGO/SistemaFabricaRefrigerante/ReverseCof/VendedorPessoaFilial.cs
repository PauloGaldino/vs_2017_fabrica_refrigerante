using System;
using System.Collections.Generic;

namespace ReverseCof
{
    public partial class VendedorPessoaFilial
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
