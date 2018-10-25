using System;
using System.Collections.Generic;

namespace ReverseCof
{
    public partial class ClientePessoa
    {
        public int ClientePessoaId { get; set; }
        public DateTime DataCadatro { get; set; }

        public Pessoa ClientePessoaNavigation { get; set; }
    }
}
