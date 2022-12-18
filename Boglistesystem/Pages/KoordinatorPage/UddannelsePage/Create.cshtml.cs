using Boglistesystem.Interfaces;
using Boglistesystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections;
using System.Collections.Generic;

namespace Boglistesystem.Pages.KoordinatorPage.UddannelsePage
{
    public class CreateUddannelseModel : PageModel
    {
        public IEnumerable<Uddannelse> uddannelses { get; set; }

        IUddannelseService Service { get; set; }

        [BindProperty]
        public Uddannelse Uddannelse { get; set; }

        public CreateUddannelseModel(IUddannelseService service)
        {
            Service = service;
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Service.AddUddannelse(Uddannelse);
            return RedirectToPage("/KoordinatorPage/UddannelsePage/Index");
        }
    }
}
