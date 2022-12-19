using Boglistesystem.Interfaces;
using Boglistesystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections;
using System.Collections.Generic;

namespace Boglistesystem.Pages.KoordinatorPage.UnderviserPage
{
    public class CreateUnderviserModel : PageModel
    {
        public IEnumerable<Underviser> underviserer { get; set; }

        IUnderviseService Service { get; set; }

        [BindProperty]
        public Underviser Underviser { get; set; }

        public CreateUnderviserModel(IUnderviseService service)
        {
            Service = service;
        }
        public IActionResult OnPost()
        {
            Service.AddUnderviser(Underviser);
            return RedirectToPage("/KoordinatorPage/UnderviserPage/Index");
        }
    }
}
