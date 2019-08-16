using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace EP.CursoMvc.Application.ViewModels
{
    public class ClienteViewModel
    {
        public ClienteViewModel()
        {
            ClienteId = Guid.NewGuid();
            Enderecos = new List<EnderecoViewModel>();

        }
        [Key]
        public Guid ClienteId { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }

        public DateTime DataNascimento { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

      //  public ICollection<EnderecoViewModel> Enderecos { get; set; }
    }
}
