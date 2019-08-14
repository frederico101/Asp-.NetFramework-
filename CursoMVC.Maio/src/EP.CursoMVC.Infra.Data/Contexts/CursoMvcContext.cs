using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EP.CursoMVC.Domain.Entities;
using EP.CursoMVC.Infra.Data.entityConfig;

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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p=>p.Name == p.ReflectedType.Name + "Id" )
                .Configure(p=>p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new ClienteConfig());
            modelBuilder.Configurations.Add(new EnderecoConfig());

            base.OnModelCreating(modelBuilder);

        }
    }
}
