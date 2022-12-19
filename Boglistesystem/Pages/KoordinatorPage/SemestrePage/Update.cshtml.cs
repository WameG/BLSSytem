using Boglistesystem.Interfaces;
using Boglistesystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Boglistesystem.Pages.KoordinatorPage.SemestrePage
{
    public class UpdateModel : PageModel
    {
        public IEnumerable<Semestre> semestres { get; set; }
        [BindProperty]
        public Semestre Semestre { get; set; }

        ISemestreService service;

        public UpdateModel(ISemestreService service)
        {
            this.service = service;
        }

        public IActionResult OnGet(int id)
        {

            Semestre = service.GetSemestreById(id);

            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            service.UpdateSemestre(Semestre);
            return RedirectToPage("/KoordinatorPage/SemestrePage/Index");
        }
    }
}
