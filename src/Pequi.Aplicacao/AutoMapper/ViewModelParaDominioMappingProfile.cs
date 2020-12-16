using AutoMapper;
using Pequi.Aplicacao.ViewModels;
using Pequi.Dominio.Entidades;

namespace Pequi.Aplicacao.AutoMapper
{
    public class ViewModelParaDominioMappingProfile : Profile
    {
        public ViewModelParaDominioMappingProfile()
        {

            CreateMap<ClienteViewModel, Cliente>();
        }
    }
}
