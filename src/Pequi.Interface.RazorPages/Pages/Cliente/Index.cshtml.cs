using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pequi.Aplicacao.Interfaces;
using Pequi.Aplicacao.ViewModels;

namespace Pequi.Interface.RazorPages.Pages.Cliente
{
    public class IndexModel : PageModel
    {
        private readonly IClienteApplicationService _servico;

        public IndexModel(IClienteApplicationService servico)
        {
            _servico = servico;
        }

        public IEnumerable<ClienteViewModel> Cliente { get; set; }

        public async Task OnGetAsync()
        {
            Cliente = await _servico.ObterTodos();
        }
    }
}
