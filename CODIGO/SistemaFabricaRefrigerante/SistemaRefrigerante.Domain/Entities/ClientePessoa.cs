using System;

namespace SistemaRefrigerante.Domain.Entities
{
    public class ClientePessoa
    {

        public int ClientePessoaId { get; set; }
        public DateTime DataCadatro { get; set; }

        public Pessoa ClientePessoaNavigation { get; set; }
    }
}
