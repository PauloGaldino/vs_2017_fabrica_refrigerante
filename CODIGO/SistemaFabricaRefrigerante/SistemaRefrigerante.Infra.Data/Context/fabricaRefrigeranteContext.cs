

using SistemaRefrigerante.Domain.Entities;
using System.Data.Entity;

namespace SistemaRefrigerante.Infra.Data.Context
{
    public class fabricaRefrigeranteContext : DbContext
    {
        public fabricaRefrigeranteContext() : base("FabricaRefrigerante")
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

       

    }
}