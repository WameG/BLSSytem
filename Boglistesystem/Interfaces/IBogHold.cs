using Boglistesystem.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections;
using System.Collections.Generic;

namespace Boglistesystem.Interfaces
{
    public interface IBogHold
    {
        public IEnumerable<BogHold> GetBogHold();

        public IEnumerable<SelectListItem> GetSelectListItems();

        void AddBogHold(BogHold bogHold);
        BogHold GetBogHoldById(int id);
        void UpdateBogHold(BogHold bogHold);
        
         void DeleteBogHold(int id);
    }
}
