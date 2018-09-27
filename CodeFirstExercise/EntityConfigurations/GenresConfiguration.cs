using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstExercise.EntityConfigurations
{
    public class GenresConfiguration : EntityTypeConfiguration<Genre>
    {
        public GenresConfiguration()
        {
            Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(255);

            Property(c => c.VideoID)
                .IsOptional();
        }
    }
}
