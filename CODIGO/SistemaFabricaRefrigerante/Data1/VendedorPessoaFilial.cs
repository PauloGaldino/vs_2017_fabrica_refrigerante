namespace Data1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VendedorPessoaFilial")]
    public partial class VendedorPessoaFilial
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VendedorPessoaFilial()
        {
            EstoqueMovimentado = new HashSet<EstoqueMovimentado>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VendedorPessoaId { get; set; }

        public int VendedorPessoaFilialTipoId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EstoqueMovimentado> EstoqueMovimentado { get; set; }

        public virtual Pessoa Pessoa { get; set; }

        public virtual VendedorPessoaFlilalTipo VendedorPessoaFlilalTipo { get; set; }
    }
}
