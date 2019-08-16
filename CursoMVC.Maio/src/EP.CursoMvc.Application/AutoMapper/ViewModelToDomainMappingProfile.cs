using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using EP.CursoMvc.Application.ViewModels;
using EP.CursoMVC.Domain.Entities;

namespace EP.CursoMvc.Application.AutoMapper
{
    class ViewModelToDomainMappingProfile : Profile
    {
       // [Obsolete]
        protected override void Configure()
        {
            CreateMap<ClienteViewModel, Cliente>();
            CreateMap<ClienteEnderecoViewModel, Cliente>();
            CreateMap<EnderecoViewModel, Endereco>();
            CreateMap<ClienteEnderecoViewModel, Endereco>();

        }
    }
}
