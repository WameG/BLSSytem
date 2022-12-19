using Boglistesystem.Interfaces;
using Boglistesystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Boglistesystem.Pages.UnderviserPage
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public Underviser Underviser { get; set; }

        public string ErrorMessage { get; set; }

        IUnderviseService service;
        public IndexModel(IUnderviseService service)
        {

            this.service = service;
        }

        public IActionResult OnPost()
        {


            foreach (var item in service.GetUndervisers())
            {
                if (Underviser.Navn == item.Navn)
                {
                    return RedirectToPage("/UnderviserPage/GetHold/Index", new { navn = Underviser.Navn });

                }
            }
                ErrorMessage = "Der findes ikke nogen Underviser med dette navn!";
            return Page();
        }
    }
}
