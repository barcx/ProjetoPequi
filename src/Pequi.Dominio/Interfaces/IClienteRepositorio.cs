﻿using Pequi.Dominio.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pequi.Dominio.Interfaces
{
    public interface IClienteRepositorio
    {
        Task<Cliente> ObterPorId(int id);
        Task<IEnumerable<Cliente>> ObterTodos();
        Task Adicionar(Cliente cliente);
        Task Atualizar(Cliente cliente);
        Task Excluir(int id);
    }
}
