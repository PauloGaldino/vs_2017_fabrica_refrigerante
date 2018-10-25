using System.Collections.Generic;

namespace SistemaRefrigerante.Domain.Entities
{
    public class Operacao
    {
        public Operacao()
        {
            Pedido = new HashSet<Pedido>();
            Situacao = new HashSet<Situacao>();
        }

        public int OperacaoId { get; set; }
        public string Descricao { get; set; }

        public ICollection<Pedido> Pedido { get; set; }
        public ICollection<Situacao> Situacao { get; set; }
    }
}