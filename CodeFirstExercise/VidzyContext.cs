using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstExercise.EntityConfigurations;

namespace CodeFirstExercise
{
    public class VidzyContext : DbContext
    {
        public VidzyContext()
            : base("name=DefaultConnection")
        {

        }

        public DbSet<Video> Videos { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new VideosConfiguration());
            modelBuilder.Configurations.Add(new GenresConfiguration());
        }
    }
}
