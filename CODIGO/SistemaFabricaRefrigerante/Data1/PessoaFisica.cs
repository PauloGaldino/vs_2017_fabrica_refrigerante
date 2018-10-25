namespace Data1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PessoaFisica")]
    public partial class PessoaFisica
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int pessoaFisicaId { get; set; }

        [Required]
        [StringLength(100)]
        public string nome { get; set; }

        [Required]
        [StringLength(15)]
        public string cpf { get; set; }

        [StringLength(20)]
        public string rg { get; set; }

        public DateTime dataNascimento { get; set; }

        public virtual Pessoa Pessoa { get; set; }
    }
}
