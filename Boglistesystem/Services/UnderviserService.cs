using Boglistesystem.Interfaces;
using Boglistesystem.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Boglistesystem.Services
{
    public class UnderviserService : IUnderviseService
    {
        BLSystemContext context;

        public UnderviserService(BLSystemContext service)
            {
            context = service;
        }



        public IEnumerable<Underviser> GetUndervisers(string Filter) {
            if(Filter == null)
            {
                return context.Undervisers;
            }
            return context.Set<Underviser>().Where(u => u.Navn.ToLower().StartsWith(Filter));
        }

        public IEnumerable<Underviser> GetUndervisers() {
            return context.Undervisers;
        }


        public void AddUnderviser(Underviser underviser) {
           
            context.Undervisers.Add(underviser);
            context.SaveChanges();
        }

        public Underviser GetUnderviserId(int id) {
            return context.Undervisers.Find(id);
        }
        public void DeleteUnderviser(int id) {
            Underviser underviser = GetUnderviserId(id);
            context.Undervisers.Remove(underviser);
            context.SaveChanges(true);
        }

        public void UpdateUnderviser(Underviser underviser) {
            context.Undervisers.Update(underviser);
            context.SaveChanges();
        }
    }
}
