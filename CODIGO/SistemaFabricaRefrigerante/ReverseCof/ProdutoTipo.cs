﻿using System;
using System.Collections.Generic;

namespace ReverseCof
{
    public partial class ProdutoTipo
    {
        public ProdutoTipo()
        {
            EstoqueMovimentado = new HashSet<EstoqueMovimentado>();
            Produto = new HashSet<Produto>();
        }

        public int ProdutoTipoId { get; set; }
        public string Descricao { get; set; }

        public ICollection<EstoqueMovimentado> EstoqueMovimentado { get; set; }
        public ICollection<Produto> Produto { get; set; }
    }
}
