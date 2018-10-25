namespace Data1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VendedorPessoaFlilalTipo")]
    public partial class VendedorPessoaFlilalTipo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VendedorPessoaFlilalTipo()
        {
            VendedorPessoaFilial = new HashSet<VendedorPessoaFilial>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VendedorPessoaTipoFilialId { get; set; }

        [Required]
        [StringLength(30)]
        public string descricao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VendedorPessoaFilial> VendedorPessoaFilial { get; set; }
    }
}
