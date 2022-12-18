using Boglistesystem.Interfaces;
using Boglistesystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Boglistesystem.Pages.UnderviserPage.BogPage
{
    public class DeleteBogModel : PageModel
    {
        private IBogService service;
        [BindProperty]
        public Bog Bog { get; set; }
        public DeleteBogModel(IBogService service)
        {
            this.service = service;
        }
        public IActionResult OnGet(int id)
        {
            Bog = service.GetBogById(id);
            return Page();
        }

        public IActionResult OnPost(int id)
        {

            this.service.DeleteBog(id);
            return RedirectToPage("/UnderviserPage/BogPage/Index");

        }
    }
}
