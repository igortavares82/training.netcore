using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Study.Training.Infrastructure.Mappings;
using Study.Training.Model.Entities.Concrete;

namespace Study.Training.Infrastructure.Data.Context
{
    public class TrainingDbContext : DbContext
    {
        //https://www.learnentityframeworkcore.com/walkthroughs/console-application
        private IConfigurationRoot config;

        public TrainingDbContext() { }

        public TrainingDbContext(IConfigurationRoot config, DbContextOptions<TrainingDbContext> options) : base(options)
        {
            this.config = config;
        }

        public DbSet<Answer> Answers { get; set; }
        public DbSet<Question> Quations { get; set; }
        public DbSet<Subject> Subjects { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.HasDefaultSchema("StudyTraining");

            AnswerMapping.Configure(builder);
            QuestionMapping.Configure(builder);
            SubjectMapping.Configure(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=LUCIVAR-PC\\SQLEXPRESS;Initial Catalog=Training;Integrated Security=True");
        }
             
    }
}
