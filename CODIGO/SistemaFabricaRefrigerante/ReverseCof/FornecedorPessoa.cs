using System;
using System.Collections.Generic;

namespace ReverseCof
{
    public partial class FornecedorPessoa
    {
        public int FornecedorPessoaId { get; set; }

        public Pessoa FornecedorPessoaNavigation { get; set; }
    }
}
