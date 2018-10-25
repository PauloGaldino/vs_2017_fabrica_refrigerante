using System;
using System.Collections.Generic;

namespace ReverseCof
{
    public partial class Preco
    {
        public int ProdutoId { get; set; }
        public decimal Preco1 { get; set; }

        public Produto Produto { get; set; }
    }
}
