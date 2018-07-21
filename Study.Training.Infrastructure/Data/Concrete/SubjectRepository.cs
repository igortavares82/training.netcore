using Study.Training.Infrastructure.Data.Context;
using Study.Training.Infrastructure.Data.Interface;
using Study.Training.Model.Entities.Concrete;
using Study.Training.Model.Filters;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Study.Training.Infrastructure.Data.Concrete
{
    public class SubjectRepository<T> : Repository<T>, ISubjectRepository<T> where T : Subject
    {
        public SubjectRepository(TrainingDbContext context) : base(context) {}

        public IEnumerable<T> Read(SubjectFilter filter)
        {
            IEnumerable<T> subjects = this.context.Set<T>()
                                                  .Include("Question")
                                                  .Include("Answer")
                                                  .Where(x => x.Id == filter.Id || x.Description.Contains(filter.Description))
                                                  .Skip(filter.Skip)
                                                  .Take(filter.Take);

            return subjects;
        }
    }
}
