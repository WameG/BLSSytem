using Boglistesystem.Interfaces;
using Boglistesystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Boglistesystem.Pages.KoordinatorPage.FagPage
{
    public class DeleteFagModel : PageModel
    {
        private IFagService service;
        [BindProperty]
        public Fag Fag { get; set; }
        public DeleteFagModel(IFagService service)
        {
            this.service = service;
        }
        public IActionResult OnGet(int id)
        {
            Fag = service.GetFagById(id);
            return Page();
        }

        public IActionResult OnPost(int id)
        {

            this.service.DeleteFag(id);
            return RedirectToPage("/KoordinatorPage/FagPage/Index");

        }
    }
}
