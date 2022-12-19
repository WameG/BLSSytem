using Boglistesystem.Interfaces;
using Boglistesystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Boglistesystem.Pages.KoordinatorPage
{
    public class AlleKoordinatorModel : PageModel
    {
        public IEnumerable<Koordinator> koordinators { get; set; }

        IKoordinatorService service;
        public AlleKoordinatorModel(IKoordinatorService service)
        {

            this.service = service;
        }
        public void OnGet()
        {
            koordinators = service.GetKoordinators();
        }
    }
}
