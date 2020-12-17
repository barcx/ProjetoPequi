using System;
using Microsoft.Extensions.DependencyInjection;
using Pequi.Aplicacao.Servicos;
using Pequi.Aplicacao.Interfaces;
using Pequi.Dominio.Negocio;
using Pequi.Dominio.Interfaces;
using Pequi.Infra.Dados.EF.Repositorio;

namespace Pequi.Aplicacao.Configuracao
{
    public static class DependencyInjectionConfig
    {
        public static void AddDependencyInjectionConfiguration(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            // Domínio
            services.AddScoped(typeof(IClienteDomainService), typeof(ClienteDomainService));

            // Infra - Dados
            services.AddScoped(typeof(IClienteRepositorio), typeof(ClienteRepositorio));

            // Aplicação
            services.AddScoped(typeof(IClienteApplicationService), typeof(ClienteApplicationService));
        }
    }
}
