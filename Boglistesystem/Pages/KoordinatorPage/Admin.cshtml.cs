using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Boglistesystem.Interfaces;
using System.Collections;
using Boglistesystem.Models;
using System.Collections.Generic;
using System.Globalization;

namespace Boglistesystem.Pages.KoordinatorPage
{
    public class AdminModel : PageModel
    {
        public string Navn { get; set; }

        public void OnGet(string navn)
        {
            Navn = navn;
        }
    }
}
