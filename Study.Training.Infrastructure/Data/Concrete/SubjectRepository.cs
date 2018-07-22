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
    public class SubjectRepository : Repository<Subject>, ISubjectRepository
    {
        public SubjectRepository(TrainingDbContext context) : base(context) {}

        public IEnumerable<Subject> Read(SubjectFilter filter)
        {
            IEnumerable<Subject> subjects = this.Context.Set<Subject>()
                                                        .Include("Question")
                                                        .Where(x => x.Id == filter.Id || 
                                                                    x.Description.Contains(filter.Description))
                                                        .Skip(filter.Skip)
                                                        .Take(filter.Take);

            return subjects;
        }
    }
}
