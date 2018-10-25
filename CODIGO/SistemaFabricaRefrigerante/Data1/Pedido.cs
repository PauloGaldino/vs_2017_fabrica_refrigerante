namespace Data1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pedido")]
    public partial class Pedido
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pedido()
        {
            PedidoItem = new HashSet<PedidoItem>();
        }

        public int PedidoID { get; set; }

        public DateTime DataHora { get; set; }

        public int OperacaoId { get; set; }

        public int SituacaoId { get; set; }

        public int PessoaEmitenteId { get; set; }

        public int PessoaDestinatarioId { get; set; }

        public virtual Operacao Operacao { get; set; }

        public virtual Pessoa Pessoa { get; set; }

        public virtual Pessoa Pessoa1 { get; set; }

        public virtual Situacao Situacao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PedidoItem> PedidoItem { get; set; }
    }
}
