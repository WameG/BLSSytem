using Boglistesystem.Interfaces;
using Boglistesystem.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Boglistesystem.Services
{
    public class BogHoldService : IBogHold
    {



        BLSystemContext context;

        public BogHoldService(BLSystemContext context)
        {
            this.context = context;
        }
        public IEnumerable<BogHold> GetBogHold()
        {
            var bogholds = context.BogHolds
                 .Include(bh => bh.Bog)
                 .Include(bh => bh.Hold.Uddannelse)
                 .Include(bh => bh.Hold.Fag)
                 .Include(bh => bh.Hold.Underviser)
                 .Include(bh => bh.Hold.Semestre)
                 .AsNoTracking();
            return bogholds;
        }

        public IEnumerable<SelectListItem> GetSelectListItems()
        {
            List<SelectListItem> List = new List<SelectListItem>();

            foreach (var item in context.Bøger)
            {
                List.Add(new SelectListItem { Text = item.Titel, Value = item.Bog_id.ToString() });
            };

            return List;
        }

        public IEnumerable<SelectListItem> GetBogHoldSelectListItems(int holdId)
        {
            List<SelectListItem> List = new List<SelectListItem>();

            foreach (var item in context.BogHolds.Include(bh => bh.Bog))
            {
                if(holdId == item.Hold_id)
                {
                List.Add(new SelectListItem { Text = item.Bog.Titel, Value = item.Bog_id.ToString() });
                }
            };

            return List;
        }

        public void AddBogHold(BogHold bogHold)
        {
            context.BogHolds.Add(bogHold);
            context.SaveChanges();
        }

        public IEnumerable<BogHold> GetBogHoldByHoldIdAndBogID(int holdId, int bogId)
        {
            return context.BogHolds.Where(x => x.Hold_id == holdId && x.Bog_id == bogId);
        }

        public void UpdateBogHold(BogHold bogHold)
        {
            context.BogHolds.Update(bogHold);
            context.SaveChanges();
        }

        public void DeleteBogHold(int holdId, int bogId)
        {
            IEnumerable<BogHold> bogHold = GetBogHoldByHoldIdAndBogID(holdId, bogId);
            context.BogHolds.Remove(bogHold.First());
            context.SaveChanges(true);
        }
    }
}