using Boglistesystem.Interfaces;
using Boglistesystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Boglistesystem.Pages.KoordinatorPage.HoldPage
{
    public class DeleteHoldModel : PageModel
    {
        private IHoldService service;
        [BindProperty]
        public Hold Hold { get; set; }
        public DeleteHoldModel(IHoldService service)
        {
            this.service = service;
        }
        public IActionResult OnGet(int id)
        {
            Hold = service.GetHoldById(id);
            return Page();
        }

        public IActionResult OnPost(int id)
        {

            this.service.DeleteHold(id);
            return RedirectToPage("/KoordinatorPage/HoldPage/Index");

        }
    }
}
