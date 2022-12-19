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

        public string ErrorMessage { get; set; }

        public string Navn { get; set; }

        public DeleteFagModel(IFagService service)
        {
            this.service = service;
        }
        public IActionResult OnGet(int id, string navn)
        {
            Navn = navn;
            Fag = service.GetFagById(id);
            return Page();
        }

        public IActionResult OnPost(int id)
        {

            try
            {
                this.service.DeleteFag(id);
                return RedirectToPage("/KoordinatorPage/FagPage/Index");
            }
            catch
            {
                Fag = service.GetFagById(id);
                ErrorMessage = "Du skal først fjerne faget fra det tilkynttet hold før du kan slette faget.";
                return Page();
            }


        }
    }
}
