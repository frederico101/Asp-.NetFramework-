using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EP.CursoMVC.Domain.Entities;

namespace EP.CursoMVC.Infra.Data.Contexts
{
    class CursoMvcContext : DbContext
    {

        public CursoMvcContext() 
            : base("DefaultConnection")
        {

        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Endereços { get; set; }
    }
}
