using Boglistesystem.Interfaces;
using Boglistesystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Boglistesystem.Pages.Boghandler
{
    public class IndexModel : PageModel
    {
        public IEnumerable<BogHold> BogHolds { get; set; }

        IBogHold service;
        public IndexModel(IBogHold service)
        {

            this.service = service;
        }
        public void OnGet()
        {
            BogHolds = service.GetBogHold();
        }
    }
}
