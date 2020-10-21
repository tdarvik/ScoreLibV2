using System;
using System.Collections.Generic;
using System.Text;
using Entities.Configuration;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Entities
{
    // COMMENT: This context class is a middleware component for communication with the database.
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
            : base(options)
        {
        }

        // The following method is used to seed the database with data upon creation
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ScoreConfiguration());
        }

        public DbSet<Score> Scores { get; set; }
    }
}
