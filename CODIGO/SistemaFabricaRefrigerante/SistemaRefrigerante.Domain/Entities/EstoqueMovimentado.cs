using System;

namespace SistemaRefrigerante.Domain.Entities
{
   public class EstoqueMovimentado
    {
        public int ExtoqueMovimentadoId { get; set; }
        public int PessoaFilialId { get; set; }
        public int ProdutoId { get; set; }
        public int VendedorPessoaFilailId { get; set; }
        public DateTime DataHora { get; set; }
        public string EntrouSaiu { get; set; }

        public FilialPessoa PessoaFilial { get; set; }
        public ProdutoTipo Produto { get; set; }
        public VendedorPessoaFilial VendedorPessoaFilial { get; set; }
    }
}
