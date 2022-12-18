using Boglistesystem.Interfaces;
using Boglistesystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Boglistesystem.Pages.UnderviserPage.GetHold
{
    public class IndexModel : PageModel
    {
        public IEnumerable<Hold> holds { get; set; }

        IHoldService service;
        public IndexModel(IHoldService service)
        {

            this.service = service;
        }
        public void OnGet(string navn)
        {
            holds = service.GetHoldByUnderviserNavn(navn);
        }
    }
}
