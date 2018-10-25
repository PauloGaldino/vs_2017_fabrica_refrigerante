using System;
using System.Collections.Generic;

namespace ReverseCof
{
    public partial class EmailPessoa
    {
        public int EmailPessoaId { get; set; }
        public string EnderecoEmail { get; set; }

        public Pessoa EmailPessoaNavigation { get; set; }
    }
}
