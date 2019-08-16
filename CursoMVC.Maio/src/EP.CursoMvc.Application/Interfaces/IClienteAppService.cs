using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EP.CursoMvc.Application.ViewModels;

namespace EP.CursoMvc.Application.Interfaces
{
    public interface IClienteAppService
    {

        ClienteEnderecoViewModel Adicionar(ClienteEnderecoViewModel clienteEnderecoViewModel);

        ClienteViewModel ObterPorId(Guid id);

        IEnumerable<ClienteViewModel> ObterTodos();
        ClienteViewModel ObterPorCpf(string cpf);

        ClienteViewModel ObterPorEmail(string email);

        ClienteViewModel Atualizar(ClienteViewModel clienteViewModel);
        void Remover(Guid id);

      
    }
}
