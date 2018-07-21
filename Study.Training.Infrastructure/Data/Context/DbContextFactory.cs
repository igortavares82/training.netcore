using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Study.Training.Infrastructure.Data.Context
{
    public class DbContextFactory : IDesignTimeDbContextFactory<TrainingDbContext>
    {
        private const string CONNECTION_STRING = @"Data Source=IGORTB\SQLEXPRESS;Initial Catalog=Training;Integrated Security=True";

        public TrainingDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<TrainingDbContext> training = new DbContextOptionsBuilder<TrainingDbContext>();
            training.UseSqlServer(CONNECTION_STRING);

            return new TrainingDbContext(training.Options);
        }
    }
}
