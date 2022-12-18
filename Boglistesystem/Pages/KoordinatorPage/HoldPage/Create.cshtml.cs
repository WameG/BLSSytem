using Boglistesystem.Interfaces;
using Boglistesystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections;
using System.Collections.Generic;

namespace Boglistesystem.Pages.KoordinatorPage.HoldPage
{
    public class CreateHoldModel : PageModel
    {
        public IEnumerable<Hold> holds { get; set; }
        public IEnumerable<SelectListItem> UddannelseList { get; set; }
        public IEnumerable<SelectListItem> SemestreList { get; set; }
        public IEnumerable<SelectListItem> FagList { get; set; }
        public IEnumerable<SelectListItem> UnderviserList { get; set; }


        IHoldService Service { get; set; }

        [BindProperty]
        public Hold Hold { get; set; }

        public CreateHoldModel(IHoldService service)
        {
            this.Service = service;
        }

        public void OnGet()
        {
            UddannelseList = Service.GetSelectListItems("Uddannelse");
            SemestreList = Service.GetSelectListItems("Semestre");
            FagList = Service.GetSelectListItems("Fag");
            UnderviserList = Service.GetSelectListItems("Underviser");
        }

        public IActionResult OnPost()
        {
            UddannelseList = Service.GetSelectListItems("Uddannelse");
            SemestreList = Service.GetSelectListItems("Semestre");
            FagList = Service.GetSelectListItems("Fag");
            UnderviserList = Service.GetSelectListItems("Underviser");

            if (!ModelState.IsValid)
            {
                return Page();
            }
            Service.AddHold(Hold);
            return RedirectToPage("/KoordinatorPage/HoldPage/Index");
        }
    }
}
