using Boglistesystem.Interfaces;
using Boglistesystem.Models;
using Boglistesystem.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Boglistesystem.Pages.KoordinatorPage.HoldPage
{
    public class UpdateHoldModel : PageModel
    {
        public IEnumerable<Hold> holds { get; set; }
        public IEnumerable<SelectListItem> UddannelseList { get; set; }
        public IEnumerable<SelectListItem> SemestreList { get; set; }
        public IEnumerable<SelectListItem> FagList { get; set; }
        public IEnumerable<SelectListItem> UnderviserList { get; set; }
        [BindProperty]
        public Hold Hold { get; set; }

        IHoldService service;

        public UpdateHoldModel(IHoldService service)
        {
            this.service = service;
        }

        public IActionResult OnGet(int id)
        {

            Hold = service.GetHoldById(id);

            UddannelseList = service.GetSelectListItems("Uddannelse");
            SemestreList = service.GetSelectListItems("Semestre");
            FagList = service.GetSelectListItems("Fag");
            UnderviserList = service.GetSelectListItems("Underviser");

            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            service.UpdateHold(Hold);
            return RedirectToPage("/KoordinatorPage/HoldPage/Index");
        }
    }
}
