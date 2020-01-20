using System;

namespace DevIO.Business.Models
{
    public class Endereco : Entity
    {
        /* O EF entende que quando colocamos o nome da table antes do Id que isso é um FK */
        public Guid FornecedorId { get; set; }

        public string Logradouro { get; set; }

 
        public string Numero { get; set; }
        public string Complemento { get; set; }

        
        public string Cep { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        /* Relação 1:1 | 1 Fornecedor possui 1 Endereço*/
        public Fornecedor Fornecedor { get; set; }
    }
}