using Boglistesystem.Models;
using Microsoft.EntityFrameworkCore;

namespace Boglistesystem.Models
{
    public class BLSystemContext : DbContext
    {
        public BLSystemContext(DbContextOptions<BLSystemContext> options) : base(options)
        {
        }

        public virtual DbSet<Bog> Bøger { get; set; }
        public virtual DbSet<BogHold> BogHolds { get; set; }
        public virtual DbSet<Fag> Fags { get; set; }
        public virtual DbSet<Hold> Holds { get; set; }
        public virtual DbSet<Koordinator> Koordinators { get; set; }
        public virtual DbSet<Semestre> Semestres { get; set; }
        public virtual DbSet<Uddannelse> Uddannelses { get; set; }
        public virtual DbSet<Underviser> Undervisers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BLSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }
    }
}
