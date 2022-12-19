using Boglistesystem.Interfaces;
using Boglistesystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Boglistesystem.Pages.KoordinatorPage.FagPage
{
    public class UpdateModel : PageModel
    {
        public IEnumerable<Fag> fags { get; set; }
        [BindProperty]
        public Fag Fag { get; set; }

        IFagService service;

        public UpdateModel(IFagService service)
        {
            this.service = service;
        }

        public IActionResult OnGet(int id)
        {

            Fag = service.GetFagById(id);

            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            service.UpdateFag(Fag);
            return RedirectToPage("/KoordinatorPage/FagPage/Index");
        }
    }
}
