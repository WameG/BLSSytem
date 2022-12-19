using Boglistesystem.Interfaces;
using Boglistesystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Boglistesystem.Pages.KoordinatorPage.UddannelsePage
{
    public class DeleteUddannelseModel : PageModel
    {
        private IUddannelseService service;
        [BindProperty]
        public Uddannelse uddannelse { get; set; }
        public string ErrorMessage { get; set; }
        public DeleteUddannelseModel(IUddannelseService service)
        {
            this.service = service;
        }
        public IActionResult OnGet(int id)
        {
            uddannelse = service.GetUddannelseById(id);
            return Page();
        }

        public IActionResult OnPost(int id)
        {
            try
            {
            this.service.DeleteUddannelse(id);
            return RedirectToPage("/KoordinatorPage/UddannelsePage/Index");
            }
            catch
            {
                uddannelse = service.GetUddannelseById(id);
                ErrorMessage = "Du skal først fjerne uddannelse fra det tilkynttet hold før du kan slette uddannelsen.";
                return Page();
            }


        }
    }
}
