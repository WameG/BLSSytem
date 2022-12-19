using Boglistesystem.Interfaces;
using Boglistesystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Boglistesystem.Pages.KoordinatorPage
{
    public class UpdateModel : PageModel
    {
        public IEnumerable<Koordinator> koordinators { get; set; }
        [BindProperty]
        public Koordinator Koordinator { get; set; }

        IKoordinatorService service;

        public UpdateModel(IKoordinatorService service)
        {
            this.service = service;
        }

        public IActionResult OnGet(int id)
        {

            Koordinator = service.GetKoordinatorById(id);

            return Page();
        }
        public IActionResult OnPost()
        {
            service.UpdateKoordinator(Koordinator);
            return RedirectToPage("/KoordinatorPage/AlleKoordinator");
        }
    }
}
