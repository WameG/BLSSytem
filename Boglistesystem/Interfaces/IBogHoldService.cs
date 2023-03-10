using Boglistesystem.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections;
using System.Collections.Generic;

namespace Boglistesystem.Interfaces
{
    public interface IBogHoldService
    {
        public IEnumerable<BogHold> GetBogHold(string FilterHold, string FilterTitle);

        public IEnumerable<SelectListItem> GetSelectListItems();

        public IEnumerable<SelectListItem> GetBogHoldSelectListItems(int holdId);

        void AddBogHold(BogHold bogHold);
        IEnumerable<BogHold> GetBogHoldByHoldIdAndBogID(int holdId, int bogId);
        void UpdateBogHold(BogHold bogHold);
        
         void DeleteBogHold(int holdId, int bogId);
    }
}
