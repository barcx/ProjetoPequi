using Microsoft.Extensions.DependencyInjection;
using Pequi.Aplicacao.AutoMapper;
using System;
using AutoMapper;

namespace Pequi.Aplicacao.Configuracao
{
    public static class AutoMapperConfig
    {
        public static void AddAutoMapperConfiguration(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            services.AddAutoMapper(typeof(DominioParaViewModelMappingProfile), typeof(ViewModelParaDominioMappingProfile));
        }
    }
}
