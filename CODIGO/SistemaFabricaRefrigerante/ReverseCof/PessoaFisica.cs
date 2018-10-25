using System;
using System.Collections.Generic;

namespace ReverseCof
{
    public partial class PessoaFisica
    {
        public int PessoaFisicaId { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public DateTime DataNascimento { get; set; }

        public Pessoa PessoaFisicaNavigation { get; set; }
    }
}
