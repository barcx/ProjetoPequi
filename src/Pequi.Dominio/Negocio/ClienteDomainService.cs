using Pequi.Dominio.Interfaces;
using Pequi.Dominio.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;
using Pequi.Dominio.Exceptions;

namespace Pequi.Dominio.Negocio
{
    public class ClienteDomainService : IClienteDomainService
    {
        private readonly IClienteRepositorio _repositorio;

        public ClienteDomainService(IClienteRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public async Task Adicionar(Cliente cliente)
        {
            if (!cliente.IsValid())
            {
                throw new PequiException($"Erro ao salvar novo cliente. Mensagem: {cliente.ValidationResult.Errors[0].ErrorMessage}");
            }

            await _repositorio.Adicionar(cliente);
        }

        public async Task Atualizar(Cliente cliente)
        {
            await _repositorio.Atualizar(cliente);
        }

        public async Task Excluir(int id)
        {
            await _repositorio.Excluir(id);
        }

        public async Task<Cliente> ObterPorId(int id)
        {
            return await _repositorio.ObterPorId(id);
        }

        public async Task<IList<Cliente>> ObterTodos()
        {
            return await _repositorio.ObterTodos();
        }
    }
}
