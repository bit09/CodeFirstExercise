using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstExercise.EntityConfigurations
{
    public class VideosConfiguration : EntityTypeConfiguration<Video>
    {
        public VideosConfiguration()
        {
            Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(255);
            
            Property(c => c.GenreId)
                .IsRequired();

            Property(c => c.Classification)
                .HasColumnType("tinyint");

            HasMany(c => c.Genres)
                .WithOptional(c => c.Video)
                .HasForeignKey(c => c.VideoID);
        }
    }
}
