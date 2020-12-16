using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pequi.Aplicacao.Interfaces;
using Pequi.Aplicacao.ViewModels;

namespace Pequi.Interface.RazorPages.Pages.Cliente
{
    public class CreateModel : PageModel
    {
        private readonly IClienteApplicationService _servico;

        public CreateModel(IClienteApplicationService servico)
        {
            _servico = servico;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ClienteViewModel Cliente { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _servico.Adicionar(Cliente);

            return RedirectToPage("./Index");
        }
    }
}