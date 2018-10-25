using System;
using System.Collections.Generic;

namespace ReverseCof
{
    public partial class TelefonePessoa
    {
        public int TelefonePessoaId { get; set; }
        public int TelefonePessoaTipoId { get; set; }
        public string TelefoneNumero { get; set; }

        public Pessoa TelefonePessoaNavigation { get; set; }
        public TelefonePessoaTipo TelefonePessoaTipo { get; set; }
    }
}
