using Boglistesystem.Interfaces;
using Boglistesystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections;
using System.Collections.Generic;

namespace Boglistesystem.Pages.KoordinatorPage.SemestrePage
{
    public class CreateSemestreModel : PageModel
    {
        public IEnumerable<Semestre> semestres { get; set; }

        ISemestreService Service { get; set; }

        [BindProperty]
        public Semestre Semestre { get; set; }

        public CreateSemestreModel(ISemestreService service)
        {
            Service = service;
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Service.CreateSemestre(Semestre);
            return RedirectToPage("/KoordinatorPage/SemestrePage/Index");
        }
    }
}
