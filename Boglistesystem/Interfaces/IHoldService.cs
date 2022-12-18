using Boglistesystem.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Boglistesystem.Interfaces
{
    public interface IHoldService
    {
       

        //public IEnumerable<Hold> GetHolds(string Filter);
        public IEnumerable<Hold> GetHolds();

        public IEnumerable<SelectListItem> GetSelectListItems(string name);
       
        void AddHold(Hold hold);
       
        public void DeleteHold(Hold hold);
        Hold GetHoldById(int id);
        void UpdateHold(Hold hold);
        public void DeleteHold(int id);

        public IEnumerable<Hold> GetHoldByUnderviserNavn(string navn);

    }
}
