using Microsoft.EntityFrameworkCore;
using Study.Training.Model.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Study.Training.Infrastructure.Mappings
{
    public static class SubjectMapping
    {
        public static void Configure(ModelBuilder builder)
        {
            builder.Entity<Subject>(x =>
            {
                x.ToTable("Subject");
                x.HasKey(y => y.Id).HasName("SubjectId");
                x.Property(y => y.Id).HasColumnName("SubjectId").ValueGeneratedOnAdd();
                x.Property(y => y.Description).HasColumnName("Description").HasMaxLength(200).IsRequired();
            });
        }
    }
}
