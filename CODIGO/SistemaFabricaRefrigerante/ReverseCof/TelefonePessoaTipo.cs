using System;
using System.Collections.Generic;

namespace ReverseCof
{
    public partial class TelefonePessoaTipo
    {
        public TelefonePessoaTipo()
        {
            TelefonePessoa = new HashSet<TelefonePessoa>();
        }

        public int TelefonePessoaTipoId { get; set; }
        public string Descricao { get; set; }

        public ICollection<TelefonePessoa> TelefonePessoa { get; set; }
    }
}
