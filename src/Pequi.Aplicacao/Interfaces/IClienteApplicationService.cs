using Pequi.Aplicacao.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pequi.Aplicacao.Interfaces
{
    public interface IClienteApplicationService
    {
        Task<ClienteViewModel> ObterPorId(int id);
        Task<IEnumerable<ClienteViewModel>> ObterTodos();
        Task Adicionar(ClienteViewModel cliente);
        Task Atualizar(ClienteViewModel cliente);
        Task Excluir(int id);
    }
}
