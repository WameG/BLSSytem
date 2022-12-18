using Boglistesystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Boglistesystem.Pages
{
    public class koordinatorModel : PageModel
    {

        [BindProperty]
        public Koordinator Koordinator { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            return RedirectToPage("Admin", new {navn = Koordinator.Navn });
        }
    }
}
