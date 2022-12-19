using Boglistesystem.Interfaces;
using Boglistesystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Boglistesystem.Pages.KoordinatorPage.UnderviserPage
{
    public class DeleteUnderviserModel : PageModel
    {
        private IUnderviseService service;
        [BindProperty]
        public Underviser underviser { get; set; }
        public string ErrorMessage { get; set; }
        public DeleteUnderviserModel(IUnderviseService service)
        {
            this.service = service;
        }
        public IActionResult OnGet(int id)
        {
            underviser = service.GetUnderviserId(id);
            return Page();
        }

        public IActionResult OnPost(int id)
        {
            try
            {
                this.service.DeleteUnderviser(id);
                return RedirectToPage("/KoordinatorPage/UnderviserPage/Index");
            }
            catch
            {
                underviser = service.GetUnderviserId(id);
                ErrorMessage = "Du skal først fjerne underviseren fra det tilkynttet hold før du kan slette underviser.";
                return Page();
            }
        }
    }
}
