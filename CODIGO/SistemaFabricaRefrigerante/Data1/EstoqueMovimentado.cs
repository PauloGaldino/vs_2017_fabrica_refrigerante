namespace Data1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EstoqueMovimentado")]
    public partial class EstoqueMovimentado
    {
        [Key]
        public int ExtoqueMovimentadoId { get; set; }

        public int PessoaFilialId { get; set; }

        public int ProdutoId { get; set; }

        public int VendedorPessoaFilailId { get; set; }

        public DateTime DataHora { get; set; }

        [Required]
        [StringLength(1)]
        public string EntrouSaiu { get; set; }

        public virtual FilialPessoa FilialPessoa { get; set; }

        public virtual ProdutoTipo ProdutoTipo { get; set; }

        public virtual VendedorPessoaFilial VendedorPessoaFilial { get; set; }
    }
}
