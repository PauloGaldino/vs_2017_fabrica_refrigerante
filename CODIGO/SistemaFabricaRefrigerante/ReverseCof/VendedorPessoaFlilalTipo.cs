using System;
using System.Collections.Generic;

namespace ReverseCof
{
    public partial class VendedorPessoaFlilalTipo
    {
        public VendedorPessoaFlilalTipo()
        {
            VendedorPessoaFilial = new HashSet<VendedorPessoaFilial>();
        }

        public int VendedorPessoaTipoFilialId { get; set; }
        public string Descricao { get; set; }

        public ICollection<VendedorPessoaFilial> VendedorPessoaFilial { get; set; }
    }
}
