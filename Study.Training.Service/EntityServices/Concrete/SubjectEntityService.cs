using Study.Training.Infrastructure.Data.Interface;
using Study.Training.Model.Entities.Concrete;
using Study.Training.Model.Filters;
using Study.Training.Model.Models;
using Study.Training.Service.EntityServices.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Study.Training.Service.EntityServices.Concrete
{
    public class SubjectEntityService : ISubjectEntityService
    {
        private ISubjectRepository repository;

        public SubjectEntityService(ISubjectRepository repository)
        {
            this.repository = repository;
        }

        public void Create(Subject subject)
        {
            this.repository.Create(subject);
        }

        public void Delete(Subject subject)
        {
            this.repository.Delete(subject);
        }

        public PageModelResult<Subject> Read(SubjectFilter filter)
        {
            PageModelResult<Subject> model = new PageModelResult<Subject>();
            IEnumerable<Subject> subjects = this.repository.Read(filter);

            model.RowCount = subjects.Count();
            model.PageIndex = filter.PageIndex;
            model.Data = subjects.Skip(filter.Skip).Take(filter.Take);

            return model;
        }

        public void Update(Subject subject)
        {
            this.repository.Update(subject);
        }
    }
}
