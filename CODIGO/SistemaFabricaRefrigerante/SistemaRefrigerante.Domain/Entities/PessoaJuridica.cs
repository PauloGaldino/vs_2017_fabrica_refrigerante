﻿using System;

namespace SistemaRefrigerante.Domain.Entities
{
    public class PessoaJuridica
    {
        public int PessoaJuridica1 { get; set; }
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public string InscricaoEstadual { get; set; }
        public DateTime DataFundacao { get; set; }

        public Pessoa PessoaJuridica1Navigation { get; set; }
    }
}
