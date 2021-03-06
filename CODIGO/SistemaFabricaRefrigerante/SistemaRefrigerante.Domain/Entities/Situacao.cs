﻿using System.Collections.Generic;

namespace SistemaRefrigerante.Domain.Entities
{
    public class Situacao
    {
        public Situacao()
        {
            Pedido = new HashSet<Pedido>();
        }

        public int SituacaoId { get; set; }
        public string Descricao { get; set; }
        public int? OperacaoId { get; set; }

        public Operacao Operacao { get; set; }
        public ICollection<Pedido> Pedido { get; set; }
    }
}