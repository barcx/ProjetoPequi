using Microsoft.EntityFrameworkCore;
using Pequi.Dominio.Interfaces;
using Pequi.Dominio.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;
using Pequi.Dominio.Exceptions;

namespace Pequi.Infra.Dados.EF.Repositorio
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        private readonly PequiContext _context;

        public ClienteRepositorio(PequiContext context)
        {
            _context = context;
        }
        public async Task Adicionar(Cliente cliente)
        {
            _context.Cliente.Add(cliente);
            await _context.SaveChangesAsync();
        }

        public async Task Atualizar(Cliente cliente)
        {
            _context.Cliente.Update(cliente);
            await _context.SaveChangesAsync();
        }

        public async Task Excluir(int id)
        {
            var cliente = await _context.Cliente.FindAsync(id);
            if (cliente == null)
            {
                throw new PequiException("Registro inexistente!");
            }

            _context.Cliente.Remove(cliente);
            await _context.SaveChangesAsync();
        }

        public async Task<Cliente> ObterPorId(int id)
        {
            return await _context.Cliente.FindAsync(id);
        }

        public async Task<IEnumerable<Cliente>> ObterTodos()
        {
            return await _context.Cliente.ToListAsync();
        }
    }
}
