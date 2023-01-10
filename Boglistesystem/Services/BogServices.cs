using Boglistesystem.Interfaces;
using Boglistesystem.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Boglistesystem.Services
{
    public class BogServices : IBogService
    {
        BLSystemContext context;

        private IWebHostEnvironment webHostEnvironment;

        public BogServices(BLSystemContext service)
        {
            context = service;
        }

        public IEnumerable<Bog> GetBogs()
        {
            return context.Bøger;
        }

        public void AddBog(Bog bog)
        {
            context.Bøger.Add(bog);
            context.SaveChanges();
        }
        public Bog GetBogById(int id)
        {
            return context.Bøger.Find(id);
        }

        public void DeleteBog(int id)
        {

            Bog Bog = GetBogById(id);
            context.Bøger.Remove(Bog);
            context.SaveChanges(true);
        }
        public void UpdateBog(Bog bog)
        {
            context.Bøger.Update(bog);
            context.SaveChanges();
        }
        public BogServices(BLSystemContext context, IWebHostEnvironment webHostEnvironment) : this(context)
        {
            this.webHostEnvironment = webHostEnvironment;
        }

        public async Task<string> UploadImage(IFormFile File)
        {
            var filePath = Path.Combine(webHostEnvironment.ContentRootPath, @"wwwroot/image", File.FileName);
            using var fileStream = new FileStream(filePath, FileMode.Create);
            await File.CopyToAsync(fileStream);
            return filePath;
        }

    }
}
