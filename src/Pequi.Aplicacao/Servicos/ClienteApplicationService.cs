using AutoMapper;
using Pequi.Aplicacao.Interfaces;
using Pequi.Aplicacao.ViewModels;
using Pequi.Dominio.Entidades;
using Pequi.Dominio.Negocio;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pequi.Aplicacao.Servicos
{
    public class ClienteApplicationService : IClienteApplicationService
    {
        private readonly IClienteDomainService _servico;
        private readonly IMapper _mapper;

        public ClienteApplicationService(IMapper mapper, IClienteDomainService servico)
        {
            _mapper = mapper;
            _servico = servico;
        }

        public async Task Adicionar(ClienteViewModel cliente)
        {
            var entidade = _mapper.Map<Cliente>(cliente);
            await _servico.Adicionar(entidade);
        }

        public async Task Atualizar(ClienteViewModel cliente)
        {
            var entidade = _mapper.Map<Cliente>(cliente);
            await _servico.Atualizar(entidade);
        }

        public async Task Excluir(int id)
        {
            await _servico.Excluir(id);
        }

        public async Task<ClienteViewModel> ObterPorId(int id)
        {
            return _mapper.Map<ClienteViewModel>(await _servico.ObterPorId(id));
        }

        public async Task<IEnumerable<ClienteViewModel>> ObterTodos()
        {
            return _mapper.Map<IEnumerable<ClienteViewModel>>(await _servico.ObterTodos());
        }
    }
}
