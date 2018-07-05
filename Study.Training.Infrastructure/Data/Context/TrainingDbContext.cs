using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Study.Training.Infrastructure.Mappings;
using Study.Training.Model.Entities.Concrete;

namespace Study.Training.Infrastructure.Data.Context
{
    public class TrainingDbContext : DbContext
    {
        public TrainingDbContext() { }

        public TrainingDbContext(DbContextOptions<TrainingDbContext> options) : base(options) { }

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
    }
}
