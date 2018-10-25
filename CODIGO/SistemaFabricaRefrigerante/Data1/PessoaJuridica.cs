namespace Data1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PessoaJuridica")]
    public partial class PessoaJuridica
    {
        [Key]
        [Column("pessoaJuridica")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int pessoaJuridica1 { get; set; }

        [Required]
        [StringLength(50)]
        public string nomeFantasia { get; set; }

        [Required]
        [StringLength(50)]
        public string razaoSocial { get; set; }

        [Required]
        [StringLength(20)]
        public string cnpj { get; set; }

        [Required]
        [StringLength(25)]
        public string InscricaoEstadual { get; set; }

        [Column(TypeName = "date")]
        public DateTime dataFundacao { get; set; }

        public virtual Pessoa Pessoa { get; set; }
    }
}
