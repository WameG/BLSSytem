using Boglistesystem.Interfaces;
using Boglistesystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Boglistesystem.Pages.KoordinatorPage
{
    public class DeleteModel : PageModel
    {
        private IKoordinatorService service;
        [BindProperty]
        public Koordinator Koordinator { get; set; }

        public string ErrorMessage { get; set; }

        public DeleteModel(IKoordinatorService service)
        {
            this.service = service;
        }
        public IActionResult OnGet(int id)
        {
            Koordinator = service.GetKoordinatorById(id);
            return Page();
        }

        public IActionResult OnPost(int id)
        {

            try
            {
                this.service.DeleteKoordinator(id);
                return RedirectToPage("/KoordinatorPage/AlleKoordinator");
            }
            catch
            {
                Koordinator = service.GetKoordinatorById(id);
                ErrorMessage = "Du skal først fjerne koordinatoren fra det tilkynttet hold og underviser før du kan slette koordinatoren.";
                return Page();
            }


        }
    }
}
