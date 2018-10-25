namespace Data1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Preco")]
    public partial class Preco
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProdutoId { get; set; }

        [Column("Preco")]
        public decimal Preco1 { get; set; }

        public virtual Produto Produto { get; set; }
    }
}
