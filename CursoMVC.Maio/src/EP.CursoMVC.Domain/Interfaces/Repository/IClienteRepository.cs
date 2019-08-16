using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EP.CursoMVC.Domain.Entities;
using EP.CursoMVC.Domain.Interfaces.Repository;

namespace EP.CursoMVC.Infra.Data.Repository
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        Cliente ObterPorCpf(string cpf);

        Cliente ObterPorEmail(string email);
    }
}
