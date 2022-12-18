using Boglistesystem.Interfaces;
using Boglistesystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Boglistesystem.Pages.UnderviserPage.BogPage
{
    public class UpdateBogModel : PageModel
    {
        public IEnumerable<Bog> Bøger { get; set; }

        IBogService service;
        [BindProperty]
        public Bog Bog { get; set; }

        public UpdateBogModel(IBogService service)
        {
            this.service = service;
        }

        public IActionResult OnGet(int id)
        {
            Bog = service.GetBogById(id);
            return Page();
        }

        public async Task<IActionResult> OnPost(IFormFile file)
        {

            if (file != null)
            {
                await service.UploadImage(file);
                Bog.Billede = file.FileName;
                service.UpdateBog(Bog);
                return RedirectToPage("/UnderviserPage/BogPage/Index");
            }

            return Page();
        }
    }
}
