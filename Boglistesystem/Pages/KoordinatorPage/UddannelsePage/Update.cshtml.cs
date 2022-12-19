using Boglistesystem.Interfaces;
using Boglistesystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Boglistesystem.Pages.KoordinatorPage.UddannelsePage
{
    public class UpdateModel : PageModel
    {
        public IEnumerable<Uddannelse> uddannelses { get; set; }
        [BindProperty]
        public Uddannelse Uddannelse { get; set; }

        IUddannelseService service;

        public UpdateModel(IUddannelseService service)
        {
            this.service = service;
        }

        public IActionResult OnGet(int id)
        {

            Uddannelse = service.GetUddannelseById(id);

            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            service.UpdateUddannelse(Uddannelse);
            return RedirectToPage("/KoordinatorPage/UddannelsePage/Index");
        }
    }
}
