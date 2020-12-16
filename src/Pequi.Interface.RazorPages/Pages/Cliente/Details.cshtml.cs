using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pequi.Aplicacao.Interfaces;
using Pequi.Aplicacao.ViewModels;

namespace Pequi.Interface.RazorPages.Pages.Cliente
{
    public class DetailsModel : PageModel
    {
        private readonly IClienteApplicationService _servico;

        public DetailsModel(IClienteApplicationService servico)
        {
            _servico = servico;
        }

        public ClienteViewModel Cliente { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cliente = await _servico.ObterPorId(id.Value);

            if (Cliente == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}