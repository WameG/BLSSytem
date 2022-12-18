using Boglistesystem.Interfaces;
using Boglistesystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Boglistesystem.Pages.UnderviserPage.BogPage
{
    public class CreateBogModel : PageModel
    {
        public IEnumerable<Bog> Bogs { get; set; }

        IBogService Service { get; set; }

        [BindProperty]
        public Bog Bog { get; set; }

        public CreateBogModel(IBogService service)
        {
            Service = service;
        }
        public async Task<IActionResult> OnPost(IFormFile file)
        {

            if (file != null)
            {
                await Service.UploadImage(file);
                Bog.Billede = file.FileName;
                Service.AddBog(Bog);
                return RedirectToPage("/UnderviserPage/BogPage/Index");
            }

            return Page();
        }
    }
}
