using Boglistesystem.Interfaces;
using Boglistesystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Boglistesystem.Pages.KoordinatorPage
{
    public class UddannelseModel : PageModel
    {
        public IEnumerable<Uddannelse> uddannelses { get; set; }

        IUddannelseService service;
        public UddannelseModel(IUddannelseService service)
        {

            this.service = service;
        }
        public void OnGet()
        {
            uddannelses = service.GetUddannelse();
        }
    }
}
