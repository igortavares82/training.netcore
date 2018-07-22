using Study.Training.Model.Entities.Concrete;
using Study.Training.Model.Filters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Study.Training.Service.EntityServices.Interface
{
    public interface ISubjectEntityService
    {
        void Create(Subject subject);
        void Update(Subject subject);
        IEnumerable<Subject> Read(SubjectFilter filter);
        void Delete(Subject subject);
    }
}
