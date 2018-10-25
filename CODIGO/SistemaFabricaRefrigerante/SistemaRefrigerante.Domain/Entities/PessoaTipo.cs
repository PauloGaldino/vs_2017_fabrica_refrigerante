using System.Collections.Generic;

namespace SistemaRefrigerante.Domain.Entities
{
    public class PessoaTipo
    {
        public PessoaTipo()
        {
            Pessoa = new HashSet<Pessoa>();
        }

        public int PessoaTipoId { get; set; }
        public string Descricao { get; set; }

        public ICollection<Pessoa> Pessoa { get; set; }
    }
}
