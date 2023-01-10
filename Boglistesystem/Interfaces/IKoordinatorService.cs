using Boglistesystem.Models;
using System.Collections;
using System.Collections.Generic;

namespace Boglistesystem.Interfaces
{
    public interface IKoordinatorService
    {
        public IEnumerable<Koordinator> GetKoordinators();

        Koordinator GetKoordinatorById(int id);

        void AddKoordinator(Koordinator koordinator);

        void DeleteKoordinator(int id);

      

        void UpdateKoordinator(Koordinator koordinnator);
    }
}
