using Boglistesystem.Interfaces;
using Boglistesystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Boglistesystem.Pages.KoordinatorPage
{
    public class HoldModel : PageModel
    {
        public IEnumerable<Hold> holds { get; set; }

        IHoldService service;
        public HoldModel(IHoldService service)
        {

            this.service = service;
        }
        public void OnGet()
        {
            holds = service.GetHolds();
        }
    }
}
