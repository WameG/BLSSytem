using Boglistesystem.Interfaces;
using Boglistesystem.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Boglistesystem.Services
{
    public class FagService : IFagService
    {
        BLSystemContext context;

            public FagService(BLSystemContext service)
        {
            context = service;
        }
        public void CreateFag(Fag fag)
        {
            context.Fags.Add(fag);
            context.SaveChanges();
        }

        public void DeleteFag(int id)
        {
            Fag fag = GetFagById(id);
            context.Fags.Remove(fag);
            context.SaveChanges();
        }

        public IEnumerable<Fag> GetFags()
        {
            return context.Fags;
        }
        public Fag GetFagById(int id)
        {
            return context.Fags.Find(id);
        }

        public void UpdateFag(Fag fag)
        {
            context.Fags.Update(fag);
            context.SaveChanges();
        }

        public void DeleteFag(Fag fag)
        {
            context.Fags.Remove(fag);
            context.SaveChanges(true);
        }
    }
}

