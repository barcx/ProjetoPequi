using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Pequi.Aplicacao.Interfaces;
using Pequi.Aplicacao.ViewModels;

namespace Pequi.Interface.RazorPages.Pages.Cliente
{
    public class EditModel : PageModel
    {
        private readonly IClienteApplicationService _servico;

        public EditModel(IClienteApplicationService servico)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            } 
            
            await _servico.Atualizar(Cliente);
            return RedirectToPage("./Index");
        }
    }
}

