using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.CursoMvc.Application.ViewModels
{
   public class ClienteEnderecoViewModel
    {

        public ClienteEnderecoViewModel()
        {
            ClienteId = Guid.NewGuid();
            EnderecoId = Guid.NewGuid();
        }
  
        [Key]
        public Guid EnderecoId { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
      
        [Key]
        public Guid ClienteId { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }

        public DateTime DataNascimento { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

    }
}
