using Microsoft.EntityFrameworkCore;
using Study.Training.Model.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Study.Training.Infrastructure.Mappings
{
    public static class AnswerMapping
    {
        public static void Configure(ModelBuilder builder)
        {
            builder.Entity<Answer>(x =>
            {
                x.ToTable("Answer");
                x.HasKey(y => y.Id).HasName("AnswerId");
                x.Property(y => y.Id).HasColumnName("AnswerId").ValueGeneratedOnAdd();
                x.Property(y => y.Text).HasColumnName("Text").HasMaxLength(200).IsRequired();
                x.Property(y => y.IsCorrect).HasColumnName("IsCorrect").IsRequired();
                x.HasOne(y => y.Question).WithMany(y => y.Answers);
            });

        }
    }
}
