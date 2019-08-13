using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using EP.CursoMVC.Domain.Entities;
using System.Data.Entity.Infrastructure.Annotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EP.CursoMVC.Infra.Data.entityConfig
{
    class ClienteConfig : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfig()
        {
            HasKey(c => c.ClienteId);

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnType("varchar")
                .HasColumnName("str_Name");


            Property(c => c.Email)
           .IsRequired()
           .HasMaxLength(100);

            Property(c => c.CPF)
               .IsRequired()
               .HasMaxLength(11)
               .IsFixedLength()
               .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute() { IsUnique = true }));

            Property(c => c.DataNascimento)
           .IsRequired();

            Property(c => c.Ativo)
           .IsRequired();
         



        }
    }
}
