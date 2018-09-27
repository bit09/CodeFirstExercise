using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstExercise
{
        public class Video
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public DateTime ReleaseDate { get; set; }

            public VideoClassification Classification { get; set; }

            public virtual Genre Genre { get; set; }

            public int GenreId { get; set; }

            public IList<Genre> Genres { get; set; }

        public enum VideoClassification : byte
        {
                Silver = 1,
                Gold = 2,
                Platinum = 3
        }
    }
}   

