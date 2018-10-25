using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ReverseCof
{
    public class ProjetorefrigerantedbContext : DbContext
    {
        public ProjetorefrigerantedbContext()
        {
        }

        public ProjetorefrigerantedbContext(DbContextOptions<ProjetorefrigerantedbContext> options)
            : base(options)
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=paulogaldino;Initial Catalog=ProjetoRefrigeranteDB;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClientePessoa>(entity =>
            {
                entity.Property(e => e.ClientePessoaId).ValueGeneratedNever();

                entity.Property(e => e.DataCadatro).HasColumnType("datetime");

                entity.HasOne(d => d.ClientePessoaNavigation)
                    .WithOne(p => p.ClientePessoa)
                    .HasForeignKey<ClientePessoa>(d => d.ClientePessoaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientePessoa_Pessoa");
            });

            modelBuilder.Entity<EmailPessoa>(entity =>
            {
                entity.HasKey(e => new { e.EmailPessoaId, e.EnderecoEmail });

                entity.Property(e => e.EmailPessoaId).HasColumnName("EmailPessoaID");

                entity.Property(e => e.EnderecoEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.EmailPessoaNavigation)
                    .WithMany(p => p.EmailPessoa)
                    .HasForeignKey(d => d.EmailPessoaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmailPessoa_Pessoa");
            });

            modelBuilder.Entity<EnderecoPessoa>(entity =>
            {
                entity.HasKey(e => new { e.EnderecoPessoaId, e.EnderecoId });

                entity.Property(e => e.EnderecoId).ValueGeneratedOnAdd();

                entity.Property(e => e.Bairro)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cep)
                    .HasColumnName("CEP")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Cidade)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Complemento)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rua)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Uf)
                    .IsRequired()
                    .HasColumnName("UF")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.EnderecoPessoaNavigation)
                    .WithMany(p => p.EnderecoPessoa)
                    .HasForeignKey(d => d.EnderecoPessoaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EnderecoPessoa_Pessoa");
            });

            modelBuilder.Entity<Estoque>(entity =>
            {
                entity.HasKey(e => new { e.PessoaFilialId, e.ProdutoId });

                entity.HasOne(d => d.PessoaFilial)
                    .WithMany(p => p.Estoque)
                    .HasForeignKey(d => d.PessoaFilialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Estoque_FililalPessoa");

                entity.HasOne(d => d.Produto)
                    .WithMany(p => p.Estoque)
                    .HasForeignKey(d => d.ProdutoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Estoque_Produto");
            });

            modelBuilder.Entity<EstoqueMovimentado>(entity =>
            {
                entity.HasKey(e => e.ExtoqueMovimentadoId);

                entity.Property(e => e.DataHora)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntrouSaiu)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.PessoaFilial)
                    .WithMany(p => p.EstoqueMovimentado)
                    .HasForeignKey(d => d.PessoaFilialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EstoqueMovimentado_FililalPessoa");

                entity.HasOne(d => d.Produto)
                    .WithMany(p => p.EstoqueMovimentado)
                    .HasForeignKey(d => d.ProdutoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EstoqueMovimentado_ProdutoTipo");

                entity.HasOne(d => d.VendedorPessoaFilail)
                    .WithMany(p => p.EstoqueMovimentado)
                    .HasForeignKey(d => d.VendedorPessoaFilailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EstoqueMovimentado_VendedorPessoaFilial");
            });

            modelBuilder.Entity<EstoqueReservado>(entity =>
            {
                entity.HasKey(e => new { e.PessoaFilialId, e.ProdutoId });

                entity.HasOne(d => d.P)
                    .WithOne(p => p.EstoqueReservado)
                    .HasForeignKey<EstoqueReservado>(d => new { d.PessoaFilialId, d.ProdutoId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EstoqueReservado_Estoque");
            });

            modelBuilder.Entity<FilialPessoa>(entity =>
            {
                entity.HasKey(e => e.PessoaFilialId);

                entity.Property(e => e.PessoaFilialId).ValueGeneratedNever();

                entity.HasOne(d => d.PessoaFilial)
                    .WithOne(p => p.FilialPessoa)
                    .HasForeignKey<FilialPessoa>(d => d.PessoaFilialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FililalPessoa_Pessoa");
            });

            modelBuilder.Entity<FornecedorPessoa>(entity =>
            {
                entity.Property(e => e.FornecedorPessoaId).ValueGeneratedNever();

                entity.HasOne(d => d.FornecedorPessoaNavigation)
                    .WithOne(p => p.FornecedorPessoa)
                    .HasForeignKey<FornecedorPessoa>(d => d.FornecedorPessoaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FornecedorPessoa_Pessoa");
            });

            modelBuilder.Entity<Operacao>(entity =>
            {
                entity.Property(e => e.OperacaoId).ValueGeneratedNever();

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Pedido>(entity =>
            {
                entity.Property(e => e.PedidoId).HasColumnName("PedidoID");

                entity.Property(e => e.DataHora)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Operacao)
                    .WithMany(p => p.Pedido)
                    .HasForeignKey(d => d.OperacaoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pedido_Operacao");

                entity.HasOne(d => d.PessoaDestinatario)
                    .WithMany(p => p.PedidoPessoaDestinatario)
                    .HasForeignKey(d => d.PessoaDestinatarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pedido_Pessoa_Destinatario");

                entity.HasOne(d => d.PessoaEmitente)
                    .WithMany(p => p.PedidoPessoaEmitente)
                    .HasForeignKey(d => d.PessoaEmitenteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pedido_Pessoa_Emitente");

                entity.HasOne(d => d.Situacao)
                    .WithMany(p => p.Pedido)
                    .HasForeignKey(d => d.SituacaoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pedido_Situacao");
            });

            modelBuilder.Entity<PedidoItem>(entity =>
            {
                entity.HasKey(e => new { e.PedidoId, e.ProdutoId });

                entity.Property(e => e.PedidoId).HasColumnName("PedidoID");

                entity.Property(e => e.PercentualDesconto).HasColumnType("decimal(5, 2)");

                entity.HasOne(d => d.Pedido)
                    .WithMany(p => p.PedidoItem)
                    .HasForeignKey(d => d.PedidoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PedidoItem_Pedido");

                entity.HasOne(d => d.Produto)
                    .WithMany(p => p.PedidoItem)
                    .HasForeignKey(d => d.ProdutoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PedidoItem_Produto");
            });

            modelBuilder.Entity<Pessoa>(entity =>
            {
                entity.Property(e => e.PessoaId).HasColumnName("pessoaId");

                entity.Property(e => e.PessoaTipoId).HasColumnName("pessoaTipoId");

                entity.HasOne(d => d.PessoaTipo)
                    .WithMany(p => p.Pessoa)
                    .HasForeignKey(d => d.PessoaTipoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pessoa_PessoaTipo");
            });

            modelBuilder.Entity<PessoaFisica>(entity =>
            {
                entity.Property(e => e.PessoaFisicaId)
                    .HasColumnName("pessoaFisicaId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cpf)
                    .IsRequired()
                    .HasColumnName("cpf")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DataNascimento)
                    .HasColumnName("dataNascimento")
                    .HasColumnType("datetime");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Rg)
                    .HasColumnName("rg")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.PessoaFisicaNavigation)
                    .WithOne(p => p.PessoaFisica)
                    .HasForeignKey<PessoaFisica>(d => d.PessoaFisicaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PessoaFisica_Pessoa");
            });

            modelBuilder.Entity<PessoaJuridica>(entity =>
            {
                entity.HasKey(e => e.PessoaJuridica1);

                entity.Property(e => e.PessoaJuridica1)
                    .HasColumnName("pessoaJuridica")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cnpj)
                    .IsRequired()
                    .HasColumnName("cnpj")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DataFundacao)
                    .HasColumnName("dataFundacao")
                    .HasColumnType("date");

                entity.Property(e => e.InscricaoEstadual)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.NomeFantasia)
                    .IsRequired()
                    .HasColumnName("nomeFantasia")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RazaoSocial)
                    .IsRequired()
                    .HasColumnName("razaoSocial")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.PessoaJuridica1Navigation)
                    .WithOne(p => p.PessoaJuridica)
                    .HasForeignKey<PessoaJuridica>(d => d.PessoaJuridica1)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PessoaJuridica_Pessoa");
            });

            modelBuilder.Entity<PessoaTipo>(entity =>
            {
                entity.Property(e => e.PessoaTipoId)
                    .HasColumnName("pessoaTipoId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnName("descricao")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Preco>(entity =>
            {
                entity.HasKey(e => e.ProdutoId);

                entity.Property(e => e.ProdutoId).ValueGeneratedNever();

                entity.Property(e => e.Preco1).HasColumnName("Preco");

                entity.HasOne(d => d.Produto)
                    .WithOne(p => p.Preco)
                    .HasForeignKey<Preco>(d => d.ProdutoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Preco_Produto");
            });

            modelBuilder.Entity<Produto>(entity =>
            {
                entity.Property(e => e.DataFabricacao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DataValidade)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lote)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.ProdutoTipo)
                    .WithMany(p => p.Produto)
                    .HasForeignKey(d => d.ProdutoTipoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Produto_ProdutoTipo");
            });

            modelBuilder.Entity<ProdutoTipo>(entity =>
            {
                entity.Property(e => e.ProdutoTipoId).ValueGeneratedNever();

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Situacao>(entity =>
            {
                entity.Property(e => e.SituacaoId).ValueGeneratedNever();

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Operacao)
                    .WithMany(p => p.Situacao)
                    .HasForeignKey(d => d.OperacaoId)
                    .HasConstraintName("FK_Situacao_Operacao");
            });

            modelBuilder.Entity<TelefonePessoa>(entity =>
            {
                entity.HasKey(e => new { e.TelefonePessoaId, e.TelefoneNumero });

                entity.Property(e => e.TelefoneNumero)
                    .HasColumnName("telefoneNumero")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.HasOne(d => d.TelefonePessoaNavigation)
                    .WithMany(p => p.TelefonePessoa)
                    .HasForeignKey(d => d.TelefonePessoaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TelefonePessoa_Pessoa");

                entity.HasOne(d => d.TelefonePessoaTipo)
                    .WithMany(p => p.TelefonePessoa)
                    .HasForeignKey(d => d.TelefonePessoaTipoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TelefonePessoa_TelefonePessoaTipo");
            });

            modelBuilder.Entity<TelefonePessoaTipo>(entity =>
            {
                entity.Property(e => e.TelefonePessoaTipoId).ValueGeneratedNever();

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VendedorPessoaFilial>(entity =>
            {
                entity.HasKey(e => e.VendedorPessoaId);

                entity.Property(e => e.VendedorPessoaId).ValueGeneratedNever();

                entity.HasOne(d => d.VendedorPessoaFilialTipo)
                    .WithMany(p => p.VendedorPessoaFilial)
                    .HasForeignKey(d => d.VendedorPessoaFilialTipoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VendedorPessoaFilial_VendedorPessoaFlilalTipo1");

                entity.HasOne(d => d.VendedorPessoa)
                    .WithOne(p => p.VendedorPessoaFilial)
                    .HasForeignKey<VendedorPessoaFilial>(d => d.VendedorPessoaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VendedorPessoaFilial_Pessoa");
            });

            modelBuilder.Entity<VendedorPessoaFlilalTipo>(entity =>
            {
                entity.HasKey(e => e.VendedorPessoaTipoFilialId);

                entity.Property(e => e.VendedorPessoaTipoFilialId).ValueGeneratedNever();

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnName("descricao")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

          //  OnModelCreatingPartial(modelBuilder);
        }

       // partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
