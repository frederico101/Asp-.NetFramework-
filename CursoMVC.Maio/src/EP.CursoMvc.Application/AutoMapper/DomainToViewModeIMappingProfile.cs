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
    class DomainToViewModeIMappingProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<Cliente, ClienteViewModel>();
            CreateMap<Cliente, ClienteEnderecoViewModel>();
            CreateMap<Endereco, EnderecoViewModel>();
            CreateMap<Endereco, ClienteEnderecoViewModel>();

        }
    }
}
