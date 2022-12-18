using Boglistesystem.Interfaces;
using Boglistesystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Boglistesystem.Pages.KoordinatorPage.SemestrePage
{
    public class DeleteSemestreModel : PageModel
    {
        private ISemestreService service;
        [BindProperty]
        public Semestre semestre { get; set; }
        public DeleteSemestreModel(ISemestreService service)
        {
            this.service = service;
        }
        public IActionResult OnGet(int id)
        {
            semestre = service.GetSemestreById(id);
            return Page();
        }

        public IActionResult OnPost(int id)
        {

            this.service.DeleteSemestre(id);
            return RedirectToPage("/KoordinatorPage/SemestrePage/Index");

        }
    }
}
