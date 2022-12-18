using Boglistesystem.Interfaces;
using Boglistesystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Boglistesystem.Pages.UnderviserPage.BogPage
{
    public class IndexModel : PageModel
    {
        public IEnumerable<Bog> Bogs { get; set; }

        IBogService service;
        public IndexModel(IBogService service)
        {

            this.service = service;
        }
        public void OnGet()
        {
            Bogs = service.GetBogs();
        }
    }
}
