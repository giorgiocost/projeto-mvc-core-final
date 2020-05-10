using System.Collections.Generic;

namespace projeto_mvc_core_basico.Models
{
    public class Fornecedor : Entity
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
        public TipoFornecedor TipoFornecedor { get; set; }
        public Endereco Endereco { get; set; }
        public bool Ativo { get; set; }

        /* EF relacionamento de 1 para N*/
        public IEnumerable<Produto> Produtos { get; set; }
    }
}