using System;
using System.Collections.Generic;

namespace ReverseCof
{
    public partial class EnderecoPessoa
    {
        public int EnderecoPessoaId { get; set; }
        public int EnderecoId { get; set; }
        public string Rua { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }

        public Pessoa EnderecoPessoaNavigation { get; set; }
    }
}
