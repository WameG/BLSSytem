using Boglistesystem.Interfaces;
using Boglistesystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Boglistesystem.Pages.UnderviserPage.GetHold
{
    public class DeleteBogModel : PageModel
    {
        public IEnumerable<SelectListItem> BogList { get; set; }

        IBogHold Service { get; set; }

        [BindProperty]
        public BogHold BogHold { get; set; }


        public DeleteBogModel(IBogHold service)
        {
            this.Service = service;
        }

        public void OnGet(int id)
        {
            BogHold = new BogHold();

            BogHold.Hold_id = id;

            BogList = Service.GetBogHoldSelectListItems(BogHold.Hold_id);
        }

        public IActionResult OnPost(string navn)
        {
            BogList = Service.GetBogHoldSelectListItems(BogHold.Hold_id);
            Service.DeleteBogHold(BogHold.Hold_id, BogHold.Bog_id);
            return RedirectToPage("/UnderviserPage/GetHold/Index", new { navn = navn });
        }
    }
}
