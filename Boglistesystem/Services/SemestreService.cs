using Boglistesystem.Interfaces;
using Boglistesystem.Models;
using System.Collections.Generic;
using System.Linq;

namespace Boglistesystem.Services
{
    public class SemestreService : ISemestreService
    {
        BLSystemContext context;
        public SemestreService(BLSystemContext service)
        {
            context = service;
        }

        public IEnumerable<Semestre> GetSemestre()
        {
            return context.Semestres;
        }

        public void CreateSemestre(Semestre semestre)
        {

            context.Semestres.Add(semestre);
            context.SaveChanges();
        }
        public Semestre GetSemestreById(int id)
        {
            return context.Semestres.Find(id);
        }

        public void DeleteSemestre(int id)
        {
            Semestre semestre = GetSemestreById(id);
            context.Semestres.Remove(semestre);
            context.SaveChanges(true);

        }

        public void UpdateSemestre(Semestre semestre)
        {
            context.Semestres.Update(semestre);
            context.SaveChanges();
        }
    }
}
