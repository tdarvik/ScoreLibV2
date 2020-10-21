using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Configuration
{
    class ScoreConfiguration : IEntityTypeConfiguration<Score>
    {
        public void Configure(EntityTypeBuilder<Score> builder)
        {
            builder.HasData(
                new Score
                {
                    Id = Guid.Parse("d214e4d3-0519-48a1-a055-1b35cf369451"),
                    Title = "Beethoven",
                    OpusNr = "84",
                    PhysicalForm = "Paperback",
                    Location = "Folder 1",
                    Published = 2004,
                    Bind = "",
                    Version = "1",
                    Type = "Opera"
                });
        }
    }
}
