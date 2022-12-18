using Boglistesystem.Interfaces;
using Boglistesystem.Models;
using Boglistesystem.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections;
using System.Collections.Generic;

namespace Boglistesystem.Pages.KoordinatorPage.UnderviserPage
{
    public class UpdateUnderviserModel : PageModel
    {
        public IEnumerable<Underviser> undervisers { get; set; }
        [BindProperty]
        public Underviser underviser { get; set; }

        IUnderviseService service;

        public UpdateUnderviserModel(IUnderviseService service)
        {
            this.service = service;
        }

        public IActionResult OnGet(int id)
        {

            underviser = service.GetUnderviserId(id);

            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            service.UpdateUnderviser(underviser);
            return RedirectToPage("/KoordinatorPage/UnderviserPage/Index");
        }
    }
}
