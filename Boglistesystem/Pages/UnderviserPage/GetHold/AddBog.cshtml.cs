using Boglistesystem.Interfaces;
using Boglistesystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Boglistesystem.Pages.UnderviserPage.GetHold
{
    public class AddBogModel : PageModel
    {
        public IEnumerable<SelectListItem> BogList { get; set; }

        IBogHold Service { get; set; }

        [BindProperty]
        public BogHold BogHold { get; set; }
 

        public AddBogModel(IBogHold service)
        {
            Service = service;
        }

        public void OnGet(int id)
        {
            BogHold = new BogHold();

            BogHold.Hold_id = id;

            BogList = Service.GetSelectListItems();
        }
       
        public IActionResult OnPost(int id, string navn)
        {
            BogList = Service.GetSelectListItems();
            Service.AddBogHold(BogHold);
            return RedirectToPage("/UnderviserPage/GetHold/Index", new {navn = navn });
        }
    }
}
