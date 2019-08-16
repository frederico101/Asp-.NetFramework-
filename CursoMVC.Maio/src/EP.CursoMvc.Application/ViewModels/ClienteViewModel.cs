using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using EP.CursoMVC.Domain.Entities;
using System.ComponentModel.Design;

namespace EP.CursoMvc.Application.ViewModels
{
    public class ClienteViewModel
    {
        public ClienteViewModel()
        {
            ClienteId = Guid.NewGuid();
        }
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
