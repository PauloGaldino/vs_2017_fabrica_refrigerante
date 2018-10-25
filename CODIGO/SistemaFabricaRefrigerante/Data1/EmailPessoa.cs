namespace Data1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmailPessoa")]
    public partial class EmailPessoa
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmailPessoaID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string EnderecoEmail { get; set; }

        public virtual Pessoa Pessoa { get; set; }
    }
}
