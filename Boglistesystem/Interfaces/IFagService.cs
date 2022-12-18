using Boglistesystem.Models;
using System.Collections.Generic;

namespace Boglistesystem.Interfaces

{
    public interface IFagService
    {
        public IEnumerable<Fag> GetFags();

        void CreateFag(Fag fag);
        void DeleteFag(int id);
        Fag GetFagById(int id);

        void UpdateFag(Fag fag);

        void DeleteFag(Fag fag);
    }
}
