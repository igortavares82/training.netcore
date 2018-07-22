using Study.Training.Infrastructure.Data.Interface;
using Study.Training.Model.Entities.Concrete;
using Study.Training.Model.Filters;
using Study.Training.Service.EntityServices.Interface;
using System;
using System.Collections.Generic;
using System.Text;

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

        public IEnumerable<Subject> Read(SubjectFilter filter)
        {
            return this.repository.Read(filter);
        }

        public void Update(Subject subject)
        {
            this.repository.Update(subject);
        }
    }
}
