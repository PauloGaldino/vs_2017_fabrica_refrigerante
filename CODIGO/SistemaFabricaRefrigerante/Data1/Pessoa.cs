namespace Data1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pessoa")]
    public partial class Pessoa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pessoa()
        {
            EmailPessoa = new HashSet<EmailPessoa>();
            EnderecoPessoa = new HashSet<EnderecoPessoa>();
            Pedido = new HashSet<Pedido>();
            Pedido1 = new HashSet<Pedido>();
            TelefonePessoa = new HashSet<TelefonePessoa>();
        }

        public int pessoaId { get; set; }

        public int pessoaTipoId { get; set; }

        public virtual ClientePessoa ClientePessoa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmailPessoa> EmailPessoa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EnderecoPessoa> EnderecoPessoa { get; set; }

        public virtual FilialPessoa FilialPessoa { get; set; }

        public virtual FornecedorPessoa FornecedorPessoa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pedido> Pedido { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pedido> Pedido1 { get; set; }

        public virtual PessoaTipo PessoaTipo { get; set; }

        public virtual PessoaFisica PessoaFisica { get; set; }

        public virtual PessoaJuridica PessoaJuridica { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TelefonePessoa> TelefonePessoa { get; set; }

        public virtual VendedorPessoaFilial VendedorPessoaFilial { get; set; }
    }
}
