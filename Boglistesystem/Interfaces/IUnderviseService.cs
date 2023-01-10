using Boglistesystem.Models;
using System.Collections.Generic;

namespace Boglistesystem.Interfaces
{
    public interface IUnderviseService
    {
        public IEnumerable<Underviser> GetUndervisers(string Filter);

        public IEnumerable<Underviser> GetUndervisers();
        
        void AddUnderviser(Underviser underviser);

       
        
        Underviser GetUnderviserId(int id);
        
       public void DeleteUnderviser(int id);

        void UpdateUnderviser(Underviser underviser);
    }
}
