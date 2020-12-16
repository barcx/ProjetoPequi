using AutoMapper;
using Pequi.Aplicacao.ViewModels;
using Pequi.Dominio.Entidades;

namespace Pequi.Aplicacao.AutoMapper
{
    public class DominioParaViewModelMappingProfile : Profile
    {

        public DominioParaViewModelMappingProfile()
        {
            CreateMap<Cliente, ClienteViewModel>();
        }
    }
}
