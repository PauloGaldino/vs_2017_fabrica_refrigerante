using System;
using System.Collections.Generic;

namespace ReverseCof
{
    public partial class Produto
    {
        public Produto()
        {
            Estoque = new HashSet<Estoque>();
            PedidoItem = new HashSet<PedidoItem>();
        }

        public int ProdutoId { get; set; }
        public int ProdutoTipoId { get; set; }
        public string Descricao { get; set; }
        public string Lote { get; set; }
        public DateTime DataFabricacao { get; set; }
        public DateTime DataValidade { get; set; }

        public ProdutoTipo ProdutoTipo { get; set; }
        public Preco Preco { get; set; }
        public ICollection<Estoque> Estoque { get; set; }
        public ICollection<PedidoItem> PedidoItem { get; set; }
    }
}
