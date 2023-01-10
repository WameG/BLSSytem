using Boglistesystem.Models;
using System.Collections.Generic;

namespace Boglistesystem.Interfaces

{
    public interface IFagService
    {
        public IEnumerable<Fag> GetFags();

        public void CreateFag(Fag fag);
        public void DeleteFag(int id);
        Fag GetFagById(int id);

       public void UpdateFag(Fag fag);

        
    }
}
