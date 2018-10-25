using System;
using System.Collections.Generic;

namespace ReverseCof
{
    public partial class Pessoa
    {
        public Pessoa()
        {
            EmailPessoa = new HashSet<EmailPessoa>();
            EnderecoPessoa = new HashSet<EnderecoPessoa>();
            PedidoPessoaDestinatario = new HashSet<Pedido>();
            PedidoPessoaEmitente = new HashSet<Pedido>();
            TelefonePessoa = new HashSet<TelefonePessoa>();
        }

        public int PessoaId { get; set; }
        public int PessoaTipoId { get; set; }

        public PessoaTipo PessoaTipo { get; set; }
        public ClientePessoa ClientePessoa { get; set; }
        public FilialPessoa FilialPessoa { get; set; }
        public FornecedorPessoa FornecedorPessoa { get; set; }
        public PessoaFisica PessoaFisica { get; set; }
        public PessoaJuridica PessoaJuridica { get; set; }
        public VendedorPessoaFilial VendedorPessoaFilial { get; set; }
        public ICollection<EmailPessoa> EmailPessoa { get; set; }
        public ICollection<EnderecoPessoa> EnderecoPessoa { get; set; }
        public ICollection<Pedido> PedidoPessoaDestinatario { get; set; }
        public ICollection<Pedido> PedidoPessoaEmitente { get; set; }
        public ICollection<TelefonePessoa> TelefonePessoa { get; set; }
    }
}
