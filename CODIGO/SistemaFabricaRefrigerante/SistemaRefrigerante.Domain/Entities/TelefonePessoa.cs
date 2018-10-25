using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRefrigerante.Domain.Entities
{
   public class TelefonePessoa
    {
        public int TelefonePessoaId { get; set; }
        public int TelefonePessoaTipoId { get; set; }
        public string TelefoneNumero { get; set; }

        public Pessoa TelefonePessoaNavigation { get; set; }
        public TelefonePessoaTipo TelefonePessoaTipo { get; set; }
    }
}
