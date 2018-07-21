using Microsoft.EntityFrameworkCore;
using Study.Training.Model.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Study.Training.Infrastructure.Mappings
{
    public static class QuestionMapping 
    {
        public static void Configure(ModelBuilder builder)
        {
            builder.Entity<Question>(x => 
            {
                x.ToTable("Question");
                x.HasKey(y => y.Id).HasName("QuestionId");
                x.Property(y => y.Id).HasColumnName("QuestionId").ValueGeneratedOnAdd();
                x.Property(y => y.Description).HasColumnName("Description").HasMaxLength(200).IsRequired();
                x.HasOne(y => y.Subject).WithMany(y => y.Questions);
            });
        }
    }
}
