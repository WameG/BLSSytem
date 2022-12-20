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
            if (Underviser.Navn == null)
            {
                ErrorMessage = "Indsat navn på underviser !";
                return Page();
            }
            else
            {


                foreach (var item in this.service.GetUndervisers())
                {

                    if (Underviser.Navn.ToLower() == item.Navn.ToLower())

                    {
                        return RedirectToPage("/UnderviserPage/GetHold/Index", new { navn = Underviser.Navn });

                    }
                }
            }
            ErrorMessage = "Der findes ikke nogen Underviser med dette navn!";
            return Page();
        }
    }
}
