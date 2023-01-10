using Boglistesystem.Models;
using System.Collections;
using System.Collections.Generic;

namespace Boglistesystem.Interfaces
{
    public interface ISemestreService
    {
        public IEnumerable<Semestre> GetSemestre();

        void CreateSemestre(Semestre semestre);
        void DeleteSemestre (int id);
          
        Semestre GetSemestreById (int id);
        void UpdateSemestre(Semestre semestre);
    }
}
