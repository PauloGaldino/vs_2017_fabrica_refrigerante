namespace Data1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ClientePessoa")]
    public partial class ClientePessoa
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ClientePessoaId { get; set; }

        public DateTime DataCadatro { get; set; }

        public virtual Pessoa Pessoa { get; set; }
    }
}
