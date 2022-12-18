using Boglistesystem.Interfaces;
using Boglistesystem.Models;
using System.Collections.Generic;

namespace Boglistesystem.Services
{
    public class UddannelseService : IUddannelseService

    {
        BLSystemContext context;

        public UddannelseService(BLSystemContext service)
        {
            context = service;
        }


        public IEnumerable<Uddannelse> GetUddannelse()
        {
            return context.Uddannelses;
        }

        public void AddUddannelse(Uddannelse uddannelse)
        {
            context.Uddannelses.Add(uddannelse);
            context.SaveChanges();
        }

        public void DeleteUddannelse(Uddannelse uddannelse)
        {
            if (uddannelse != null)
            {
                context.Uddannelses.Remove(uddannelse);
            }
        }

        public Uddannelse GetUddannelseById(int id)
        {
            return context.Uddannelses.Find(id);
        }

        public void DeleteUddannelse(int id)
        {
            Uddannelse uddannelse = GetUddannelseById(id);
            context.Uddannelses.Remove(uddannelse);
            context.SaveChanges(true);
        }
    }
}
