using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Pequi.Interface.RazorPages.Pages
{
    public class LogoutModel : PageModel
    {  
        public IActionResult OnGet()
        {
            return SignOut("Cookies", "oidc");
        }
    }
}
