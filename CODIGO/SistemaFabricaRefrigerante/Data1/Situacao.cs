namespace Data1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Situacao")]
    public partial class Situacao
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Situacao()
        {
            Pedido = new HashSet<Pedido>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SituacaoId { get; set; }

        [Required]
        [StringLength(20)]
        public string Descricao { get; set; }

        public int? OperacaoId { get; set; }

        public virtual Operacao Operacao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pedido> Pedido { get; set; }
    }
}
