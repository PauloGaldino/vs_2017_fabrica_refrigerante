namespace Data1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EnderecoPessoa")]
    public partial class EnderecoPessoa
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EnderecoPessoaId { get; set; }

        [Key]
        [Column(Order = 1)]
        public int EnderecoId { get; set; }

        [Required]
        [StringLength(100)]
        public string Rua { get; set; }

        [Required]
        [StringLength(50)]
        public string Complemento { get; set; }

        [Required]
        [StringLength(100)]
        public string Bairro { get; set; }

        [StringLength(15)]
        public string CEP { get; set; }

        [Required]
        [StringLength(100)]
        public string Cidade { get; set; }

        [Required]
        [StringLength(3)]
        public string UF { get; set; }

        public virtual Pessoa Pessoa { get; set; }
    }
}
