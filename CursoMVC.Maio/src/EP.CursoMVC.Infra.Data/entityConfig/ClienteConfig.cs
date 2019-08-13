using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using EP.CursoMVC.Domain.Entities;

namespace EP.CursoMVC.Infra.Data.entityConfig
{
    class ClienteConfig : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfig()
        {
            HasKey(c => c.ClienteId);

            Property(c=>c.Nome)
                .Is


        }
    }
}
