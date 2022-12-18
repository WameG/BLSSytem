using Boglistesystem.Interfaces;
using Boglistesystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections;
using System.Collections.Generic;

namespace Boglistesystem.Pages.KoordinatorPage.FagPage
{
    public class CreateFagModel : PageModel
    {
        public IEnumerable<Fag> fags { get; set; }

        IFagService Service { get; set; }

        [BindProperty]
        public Fag Fag { get; set; }

        public CreateFagModel(IFagService service)
        {
            Service = service;
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Service.CreateFag(Fag);
            return RedirectToPage("/KoordinatorPage/FagPage/Index");
        }
    }
}
