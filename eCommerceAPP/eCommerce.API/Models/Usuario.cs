using System;
using System.Collections.Generic;

namespace eCommerce.API.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Sexo { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string NomeMae { get; set; }
        public string SituacaoCadastro { get; set; }
        public DateTimeOffset DataCadastro { get; set; }

        //Relacionamentos
        public Contato Contato { get; set; } // 1 usuario tem 1 contato
        public ICollection<EnderecoEntrega> EnderecosEntrega { get; set; } // 1 usuario tem muitos endereços
        public ICollection<Departamento> Departamentos { get; set; } // n / n
    }
}
