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
        public string ErrorMessage { get; set; }
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
            try
            {
            this.service.DeleteSemestre(id);
            return RedirectToPage("/KoordinatorPage/SemestrePage/Index");
            }
            catch
            {
                semestre = service.GetSemestreById(id);
                ErrorMessage = "Du skal først fjerne semester fra det tilkynttet hold før du kan slette semesteret.";
                return Page();
            }


        }
    }
}
