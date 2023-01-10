using Boglistesystem.Models;
using System.Collections.Generic;

namespace Boglistesystem.Interfaces
{
    public interface IUddannelseService
    {
        public IEnumerable<Uddannelse> GetUddannelse();
        void AddUddannelse(Uddannelse uddannelse);
        
        Uddannelse GetUddannelseById(int id);
        void DeleteUddannelse(int id);

        void UpdateUddannelse(Uddannelse uddannelse);
    }

}

