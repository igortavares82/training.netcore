﻿using Study.Training.Model.Entities.Concrete;
using Study.Training.Model.Filters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Study.Training.Infrastructure.Data.Interface
{
    public interface ISubjectRepository : IRepository<Subject>
    {
        IEnumerable<Subject> Read(SubjectFilter filter);
    }
}
