using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Pequi.Aplicacao.Interfaces;
using Pequi.Aplicacao.ViewModels;

namespace Pequi.Interface.RazorPages.Pages.Cliente
{
    public class DeleteModel : PageModel
    {
        private readonly IClienteApplicationService _servico;

        public DeleteModel(IClienteApplicationService servico)
        {
            _servico = servico;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            try
            {
                await _servico.Excluir(id.Value);
                return RedirectToPage("./Index");
            }
            catch (DbUpdateConcurrencyException)
            {
                return NotFound();
            }
        }
    }
}

