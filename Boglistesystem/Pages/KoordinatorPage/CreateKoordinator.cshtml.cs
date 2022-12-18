using Boglistesystem.Interfaces;
using Boglistesystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections;
using System.Collections.Generic;

namespace Boglistesystem.Pages.KoordinatorPage
{
    public class CreateKoordinator : PageModel
    {
        public IEnumerable<Koordinator> koordinator { get; set; }

        IKoordinatorService Service { get; set; }

        [BindProperty]
        public Koordinator Koordinator { get; set; }

        public CreateKoordinator(IKoordinatorService service)
        {
            Service = service;
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Service.AddKoordinator(Koordinator);
            return RedirectToPage("KoordinatorPage");
        }
    }
}
