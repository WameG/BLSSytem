using Boglistesystem.Interfaces;
using Boglistesystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Boglistesystem.Pages.KoordinatorPage
{
    public class UnderviserModel : PageModel
    {
        public IEnumerable<Underviser> undervisers { get; set; }

        IUnderviseService service;
        public UnderviserModel(IUnderviseService service)
        {

            this.service = service;
        }
        public void OnGet()
        {
            undervisers = service.GetUndervisers();
        }
    }
}
