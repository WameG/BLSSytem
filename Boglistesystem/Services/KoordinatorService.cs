using Boglistesystem.Interfaces;
using Boglistesystem.Models;
using System.Collections.Generic;

namespace Boglistesystem.Services
{
    public class KoordinatorService : IKoordinatorService
    {
        BLSystemContext context;

        public KoordinatorService(BLSystemContext serivce) {
            context = serivce;
        }

        public IEnumerable<Koordinator> GetKoordinators() 
        {
            return context.Koordinators;
            
        }


        public void AddKoordinator(Koordinator koordinator)
        {
           context.Koordinators.Add(koordinator);

        context.SaveChanges();
        }

        public void DeleteKoordinator(int id)
        {
            Koordinator koordinnator = GetKoordinatorById(id);

            context.Koordinators.Remove(koordinnator);
            context.SaveChanges(true);
        }

        public void UpdateKoordinator(Koordinator koordinnator) {
            context.Koordinators.Update(koordinnator);
            context.SaveChanges();
        }

        public Koordinator GetKoordinatorById(int id)
        {
            return context.Koordinators.Find(id);
        }

        public void DeleteKoordinator(Koordinator koordinnator)
        {
            context.Koordinators.Remove(koordinnator);
            context.SaveChanges(true);
        }
    }
}
