using Boglistesystem.Interfaces;
using Boglistesystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Boglistesystem.Pages.Boghandler
{
    public class IndexModel : PageModel
    {
        public IEnumerable<BogHold> BogHolds { get; set; }
        [BindProperty(SupportsGet = true)]
        public string FilterHold { get; set; }
        [BindProperty(SupportsGet = true)]
        public string FilterTitle { get; set; }

        IBogHoldService service;
        public IndexModel(IBogHoldService service)
        {

            this.service = service;
        }
        public void OnGet()
        {
            BogHolds = service.GetBogHold(FilterHold, FilterTitle);
        }
    }
}
