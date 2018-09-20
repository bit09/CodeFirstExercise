using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstExercise
{
    class Program
    {
        public class Video
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public DateTime ReleaseDate { get; set; }
            public VideoClassification Classification { get; set; }
        }

        public class Genre
        {
            public byte Id { get; set; }
            public string Name { get; set; }
            public IList<Video> Videos { get; set; }
        }

        public enum VideoClassification
        {
            Silver = 1,
            Gold = 2,
            Platinum = 3
        }

        public class VidzyContext:DbContext
        {
            public DbSet<Video> Videos { get; set; }
            public DbSet<Genre> Genres { get; set; }

            public VidzyContext()
                :base("name=DefaultConnection")
            {
                
            }
        }
        static void Main(string[] args)
        {

        }
    }
}
