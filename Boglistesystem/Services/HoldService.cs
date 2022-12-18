using Boglistesystem.Interfaces;
using Boglistesystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.Identity.Client;
using System.Collections.Generic;
using System.Linq;

namespace Boglistesystem.Services
{
    public class HoldService : IHoldService
    {
        BLSystemContext context;
        [BindProperty]
        public Semestre semestre { get; set; }
        [BindProperty]
        public Uddannelse uddannelse { get; set; }

        public HoldService(BLSystemContext service)
        {
            context = service;
        }

        public void AddHold(Hold hold)
        {
            context.Holds.Add(hold);
            context.SaveChanges();
        }

        public void DeleteHold(int id)
        {
            Hold hold = GetHoldById(id);
            context.Holds.Remove(hold);
            context.SaveChanges();

        }

        public void DeleteHold(Hold hold)
        {
            context.Holds.Remove(hold);
            context.SaveChanges();
        }



        public Hold GetHoldById(int id)
        {
            return context.Holds.Find(id);
        }

        public IEnumerable<Hold> GetHoldByUnderviserNavn(string navn)
        {
            return context.Holds.Include(h => h.Koordinator)
                .Include(h => h.Uddannelse)
                .Include(h => h.Semestre)
                .Include(h => h.Fag)
                .Include(h => h.Underviser).Where(item => item.Underviser.Navn.ToLower() == navn.ToLower());
        }

        public IEnumerable<Hold> GetHolds()
        {

            // var holds = context.Holds.AsNoTracking();
            var holds = context.Holds
                .Include(h => h.Koordinator)
                .Include(h => h.Uddannelse)
                .Include(h => h.Semestre)
                .Include(h => h.Fag)
                .Include(h => h.Underviser)
                .AsNoTracking();
            return holds;
        }

        public IEnumerable<SelectListItem>? GetSelectListItems(string name)
        {
            List<SelectListItem> List = new List<SelectListItem>();

            if (name == "Uddannelse")
            {
                foreach (var item in context.Uddannelses)
                {
                    List.Add(new SelectListItem { Text = item.Uddannelse_navn, Value = item.Uddannelse_id.ToString() });
                };
            }

            if (name == "Semestre")
            {
                foreach (var item in context.Semestres)
                {
                    List.Add(new SelectListItem { Text = item.Navn, Value = item.Semestre_id.ToString() });
                };
            }

            if (name == "Fag")
            {
                foreach (var item in context.Fags)
                {
                    List.Add(new SelectListItem { Text = item.Fag_navn, Value = item.Fag_id.ToString() });
                };
            }

            if (name == "Underviser")
            {
                foreach (var item in context.Undervisers)
                {
                    List.Add(new SelectListItem { Text = item.Navn, Value = item.Underviser_id.ToString() });
                };
            }

            return List;
        }

        public void UpdateHold(Hold hold)
        {
            context.Holds.Update(hold);
            context.SaveChanges();
        }
    }
}
