using System;
using System.Collections.Generic;

namespace ReverseCof
{
    public partial class EstoqueReservado
    {
        public int PessoaFilialId { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public Estoque P { get; set; }
    }
}
