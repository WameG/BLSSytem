using Boglistesystem.Interfaces;
using Boglistesystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Boglistesystem.Pages.UnderviserPage.GetHold
{
    public class IndexModel : PageModel
    {
        public IEnumerable<Hold> holds { get; set; }

        public string Navn { get; set; }

        IHoldService service;
        public IndexModel(IHoldService service)
        {

            this.service = service;
        }
        public void OnGet(string navn)
        {
            Navn = navn;
            holds = service.GetHoldByUnderviserNavn(navn);
        }
    }
}
