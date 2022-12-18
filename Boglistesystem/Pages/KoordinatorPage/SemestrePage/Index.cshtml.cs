using Boglistesystem.Interfaces;
using Boglistesystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Boglistesystem.Pages.KoordinatorPage
{
    public class SemestreModel : PageModel
    {
        public IEnumerable<Semestre> semestres { get; set; }

        ISemestreService service;
        public SemestreModel(ISemestreService service)
        {

            this.service = service;
        }
        public void OnGet()
        {
            semestres = service.GetSemestre();
        }
    }
}
