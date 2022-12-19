using Boglistesystem.Interfaces;
using Boglistesystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Boglistesystem.Pages.KoordinatorPage
{
    public class FagModel : PageModel
    {
        public IEnumerable<Fag> fags { get; set; }

        public string Navn { get; set; }

        IFagService service;
        public FagModel(IFagService service)
        {

            this.service = service;
        }
        public void OnGet(string navn)
        {
            Navn = navn;
            fags = service.GetFags();
        }
    }
}
