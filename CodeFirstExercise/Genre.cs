﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstExercise
{
        public class Genre
        {
            public byte Id { get; set; }

            public string Name { get; set; }

            public IList<Video> Videos { get; set; }

            public virtual Video Video { get; set; }

            public int? VideoID { get; set; }
    }   
}
