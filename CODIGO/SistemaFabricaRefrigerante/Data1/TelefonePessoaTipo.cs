namespace Data1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TelefonePessoaTipo")]
    public partial class TelefonePessoaTipo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TelefonePessoaTipo()
        {
            TelefonePessoa = new HashSet<TelefonePessoa>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TelefonePessoaTipoId { get; set; }

        [Required]
        [StringLength(20)]
        public string Descricao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TelefonePessoa> TelefonePessoa { get; set; }
    }
}
