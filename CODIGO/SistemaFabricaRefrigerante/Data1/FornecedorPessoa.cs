namespace Data1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FornecedorPessoa")]
    public partial class FornecedorPessoa
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FornecedorPessoaId { get; set; }

        public virtual Pessoa Pessoa { get; set; }
    }
}
