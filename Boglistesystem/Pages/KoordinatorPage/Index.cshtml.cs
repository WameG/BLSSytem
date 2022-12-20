using Boglistesystem.Interfaces;
using Boglistesystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Boglistesystem.Pages
{
    public class koordinatorModel : PageModel
    {

        [BindProperty]
        public Koordinator Koordinator { get; set; }

        public string ErrorMessage { get; set; }

        IKoordinatorService service;
        public koordinatorModel(IKoordinatorService service)
        {

            this.service = service;
        }

        public IActionResult OnPost()
        {
            if (Koordinator.Navn == null)
            {
                ErrorMessage = "Indsat navn på underviser !";
                return Page();
            }
            else
            {


                foreach (var item in service.GetKoordinators())
                {
                    if (Koordinator.Navn.ToLower() == item.Navn.ToLower())
                    {
                        return RedirectToPage("/KoordinatorPage/Admin");

                    }
                    ErrorMessage = "Der findes ikke nogen Koordinator med dette navn!";
                }
            }
            return Page();
        }
    }
}
