using Study.Training.Model.Entities.Concrete;
using Study.Training.Model.Filters;
using Study.Training.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Study.Training.Service.EntityServices.Interface
{
    public interface ISubjectEntityService
    {
        void Create(Subject subject);
        void Update(Subject subject);
        PageModelResult<Subject> Read(SubjectFilter filter);
        void Delete(Subject subject);
    }
}
