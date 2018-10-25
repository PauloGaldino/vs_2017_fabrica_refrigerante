namespace Data1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1teste : DbContext
    {
        public Model1teste()
            : base("name=Model1teste")
        {
        }

        public virtual DbSet<ClientePessoa> ClientePessoa { get; set; }
        public virtual DbSet<EmailPessoa> EmailPessoa { get; set; }
        public virtual DbSet<EnderecoPessoa> EnderecoPessoa { get; set; }
        public virtual DbSet<Estoque> Estoque { get; set; }
        public virtual DbSet<EstoqueMovimentado> EstoqueMovimentado { get; set; }
        public virtual DbSet<EstoqueReservado> EstoqueReservado { get; set; }
        public virtual DbSet<FilialPessoa> FilialPessoa { get; set; }
        public virtual DbSet<FornecedorPessoa> FornecedorPessoa { get; set; }
        public virtual DbSet<Operacao> Operacao { get; set; }
        public virtual DbSet<Pedido> Pedido { get; set; }
        public virtual DbSet<PedidoItem> PedidoItem { get; set; }
        public virtual DbSet<Pessoa> Pessoa { get; set; }
        public virtual DbSet<PessoaFisica> PessoaFisica { get; set; }
        public virtual DbSet<PessoaJuridica> PessoaJuridica { get; set; }
        public virtual DbSet<PessoaTipo> PessoaTipo { get; set; }
        public virtual DbSet<Preco> Preco { get; set; }
        public virtual DbSet<Produto> Produto { get; set; }
        public virtual DbSet<ProdutoTipo> ProdutoTipo { get; set; }
        public virtual DbSet<Situacao> Situacao { get; set; }
        public virtual DbSet<TelefonePessoa> TelefonePessoa { get; set; }
        public virtual DbSet<TelefonePessoaTipo> TelefonePessoaTipo { get; set; }
        public virtual DbSet<VendedorPessoaFilial> VendedorPessoaFilial { get; set; }
        public virtual DbSet<VendedorPessoaFlilalTipo> VendedorPessoaFlilalTipo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmailPessoa>()
                .Property(e => e.EnderecoEmail)
                .IsUnicode(false);

            modelBuilder.Entity<EnderecoPessoa>()
                .Property(e => e.Rua)
                .IsUnicode(false);

            modelBuilder.Entity<EnderecoPessoa>()
                .Property(e => e.Complemento)
                .IsUnicode(false);

            modelBuilder.Entity<EnderecoPessoa>()
                .Property(e => e.Bairro)
                .IsUnicode(false);

            modelBuilder.Entity<EnderecoPessoa>()
                .Property(e => e.CEP)
                .IsUnicode(false);

            modelBuilder.Entity<EnderecoPessoa>()
                .Property(e => e.Cidade)
                .IsUnicode(false);

            modelBuilder.Entity<EnderecoPessoa>()
                .Property(e => e.UF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Estoque>()
                .HasOptional(e => e.EstoqueReservado)
                .WithRequired(e => e.Estoque);

            modelBuilder.Entity<EstoqueMovimentado>()
                .Property(e => e.EntrouSaiu)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FilialPessoa>()
                .HasMany(e => e.Estoque)
                .WithRequired(e => e.FilialPessoa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FilialPessoa>()
                .HasMany(e => e.EstoqueMovimentado)
                .WithRequired(e => e.FilialPessoa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Operacao>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<Operacao>()
                .HasMany(e => e.Pedido)
                .WithRequired(e => e.Operacao)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pedido>()
                .HasMany(e => e.PedidoItem)
                .WithRequired(e => e.Pedido)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PedidoItem>()
                .Property(e => e.PercentualDesconto)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Pessoa>()
                .HasOptional(e => e.ClientePessoa)
                .WithRequired(e => e.Pessoa);

            modelBuilder.Entity<Pessoa>()
                .HasMany(e => e.EmailPessoa)
                .WithRequired(e => e.Pessoa)
                .HasForeignKey(e => e.EmailPessoaID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pessoa>()
                .HasMany(e => e.EnderecoPessoa)
                .WithRequired(e => e.Pessoa)
                .HasForeignKey(e => e.EnderecoPessoaId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pessoa>()
                .HasOptional(e => e.FilialPessoa)
                .WithRequired(e => e.Pessoa);

            modelBuilder.Entity<Pessoa>()
                .HasOptional(e => e.FornecedorPessoa)
                .WithRequired(e => e.Pessoa);

            modelBuilder.Entity<Pessoa>()
                .HasMany(e => e.Pedido)
                .WithRequired(e => e.Pessoa)
                .HasForeignKey(e => e.PessoaDestinatarioId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pessoa>()
                .HasMany(e => e.Pedido1)
                .WithRequired(e => e.Pessoa1)
                .HasForeignKey(e => e.PessoaEmitenteId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pessoa>()
                .HasOptional(e => e.PessoaFisica)
                .WithRequired(e => e.Pessoa);

            modelBuilder.Entity<Pessoa>()
                .HasOptional(e => e.PessoaJuridica)
                .WithRequired(e => e.Pessoa);

            modelBuilder.Entity<Pessoa>()
                .HasMany(e => e.TelefonePessoa)
                .WithRequired(e => e.Pessoa)
                .HasForeignKey(e => e.TelefonePessoaId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pessoa>()
                .HasOptional(e => e.VendedorPessoaFilial)
                .WithRequired(e => e.Pessoa);

            modelBuilder.Entity<PessoaFisica>()
                .Property(e => e.nome)
                .IsUnicode(false);

            modelBuilder.Entity<PessoaFisica>()
                .Property(e => e.cpf)
                .IsUnicode(false);

            modelBuilder.Entity<PessoaFisica>()
                .Property(e => e.rg)
                .IsUnicode(false);

            modelBuilder.Entity<PessoaJuridica>()
                .Property(e => e.nomeFantasia)
                .IsUnicode(false);

            modelBuilder.Entity<PessoaJuridica>()
                .Property(e => e.razaoSocial)
                .IsUnicode(false);

            modelBuilder.Entity<PessoaJuridica>()
                .Property(e => e.cnpj)
                .IsUnicode(false);

            modelBuilder.Entity<PessoaJuridica>()
                .Property(e => e.InscricaoEstadual)
                .IsUnicode(false);

            modelBuilder.Entity<PessoaTipo>()
                .Property(e => e.descricao)
                .IsUnicode(false);

            modelBuilder.Entity<PessoaTipo>()
                .HasMany(e => e.Pessoa)
                .WithRequired(e => e.PessoaTipo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Produto>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<Produto>()
                .Property(e => e.Lote)
                .IsUnicode(false);

            modelBuilder.Entity<Produto>()
                .HasMany(e => e.Estoque)
                .WithRequired(e => e.Produto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Produto>()
                .HasMany(e => e.PedidoItem)
                .WithRequired(e => e.Produto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Produto>()
                .HasOptional(e => e.Preco)
                .WithRequired(e => e.Produto);

            modelBuilder.Entity<ProdutoTipo>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<ProdutoTipo>()
                .HasMany(e => e.EstoqueMovimentado)
                .WithRequired(e => e.ProdutoTipo)
                .HasForeignKey(e => e.ProdutoId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProdutoTipo>()
                .HasMany(e => e.Produto)
                .WithRequired(e => e.ProdutoTipo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Situacao>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<Situacao>()
                .HasMany(e => e.Pedido)
                .WithRequired(e => e.Situacao)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TelefonePessoa>()
                .Property(e => e.telefoneNumero)
                .IsUnicode(false);

            modelBuilder.Entity<TelefonePessoaTipo>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<TelefonePessoaTipo>()
                .HasMany(e => e.TelefonePessoa)
                .WithRequired(e => e.TelefonePessoaTipo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VendedorPessoaFilial>()
                .HasMany(e => e.EstoqueMovimentado)
                .WithRequired(e => e.VendedorPessoaFilial)
                .HasForeignKey(e => e.VendedorPessoaFilailId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VendedorPessoaFlilalTipo>()
                .Property(e => e.descricao)
                .IsUnicode(false);

            modelBuilder.Entity<VendedorPessoaFlilalTipo>()
                .HasMany(e => e.VendedorPessoaFilial)
                .WithRequired(e => e.VendedorPessoaFlilalTipo)
                .HasForeignKey(e => e.VendedorPessoaFilialTipoId)
                .WillCascadeOnDelete(false);
        }
    }
}
