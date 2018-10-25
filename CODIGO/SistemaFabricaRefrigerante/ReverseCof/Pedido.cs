using System;
using System.Collections.Generic;

namespace ReverseCof
{
    public partial class Pedido
    {
        public Pedido()
        {
            PedidoItem = new HashSet<PedidoItem>();
        }

        public int PedidoId { get; set; }
        public DateTime DataHora { get; set; }
        public int OperacaoId { get; set; }
        public int SituacaoId { get; set; }
        public int PessoaEmitenteId { get; set; }
        public int PessoaDestinatarioId { get; set; }

        public Operacao Operacao { get; set; }
        public Pessoa PessoaDestinatario { get; set; }
        public Pessoa PessoaEmitente { get; set; }
        public Situacao Situacao { get; set; }
        public ICollection<PedidoItem> PedidoItem { get; set; }
    }
}
