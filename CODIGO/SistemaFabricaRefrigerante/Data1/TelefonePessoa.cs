namespace Data1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TelefonePessoa")]
    public partial class TelefonePessoa
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TelefonePessoaId { get; set; }

        public int TelefonePessoaTipoId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(25)]
        public string telefoneNumero { get; set; }

        public virtual Pessoa Pessoa { get; set; }

        public virtual TelefonePessoaTipo TelefonePessoaTipo { get; set; }
    }
}
