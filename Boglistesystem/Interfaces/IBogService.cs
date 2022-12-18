using Boglistesystem.Models;
using System.Collections.Generic;

namespace Boglistesystem.Interfaces
{
    public interface IBogService
    {
        public IEnumerable<Bog> GetBogs();
        
        void AddBog(Bog bog);
        Bog GetBogById(int id);
        void DeleteBog(Bog bog);
        void DeleteBog(int id);
        void UpdateBog(Bog bog);
        Task<string> UploadImage(IFormFile File);

    }
}
