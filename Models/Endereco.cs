using System;

namespace projeto_mvc_core_basico.Models
{
    public class Endereco : Entity
    {
        public Guid FornecedorId { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        /* EF relacionamento de 1 para 1*/
        public Fornecedor Fornecedor { get; set; }        
    }
}