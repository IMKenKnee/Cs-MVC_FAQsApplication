// Kenny Hedlund
// Chapter 6 FAQ App
// COP.4813
// This handles database connection and schema injection

using Microsoft.EntityFrameworkCore;
using _6_1_FAQs.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace _6_1_FAQs.Data
{
    public class FaqContext : DbContext
    {
        // Configures the DbContext options.
        public FaqContext(DbContextOptions<FaqContext> options) : base(options) { }

        // Parameterless constructor
        public FaqContext() { }

        // FAQs, Topics, and Categories tables.
        public DbSet<FAQ> FAQs { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seeding topics, categories, and FAQs using modelBuilder
            modelBuilder.Entity<Topic>().HasData(
                new Topic { Id = "bootstrap", Name = "Bootstrap" },
                new Topic { Id = "csharp", Name = "C#" },
                new Topic { Id = "javascript", Name = "JavaScript" }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = "general", Name = "General" },
                new Category { Id = "history", Name = "History" }
            );

            modelBuilder.Entity<FAQ>().HasData(
                new FAQ { Id = 1, Question = "What is Bootstrap?", Answer = "A CSS framework for responsive design.", TopicId = "bootstrap", CategoryId = "general" },
                new FAQ { Id = 2, Question = "What is C#?", Answer = "A general-purpose object-oriented language.", TopicId = "csharp", CategoryId = "general" },
                new FAQ { Id = 3, Question = "What is JavaScript?", Answer = "A general-purpose scripting language that executes in a web browser.", TopicId = "javascript", CategoryId = "general" },
                new FAQ { Id = 4, Question = "When was Bootstrap first released?", Answer = "In 2011.", TopicId = "bootstrap", CategoryId = "history" },
                new FAQ { Id = 5, Question = "When was C# first released?", Answer = "In 2002.", TopicId = "csharp", CategoryId = "history" },
                new FAQ { Id = 6, Question = "When was JavaScript first released?", Answer = "In 1995.", TopicId = "javascript", CategoryId = "history" }
            );
        }
    }
}
