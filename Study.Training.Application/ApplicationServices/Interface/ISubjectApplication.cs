using M = Study.Training.Message.Messages;
using Study.Training.Message.Operations;
using System;
using System.Collections.Generic;
using System.Text;
using Study.Training.Model.Filters;
using Study.Training.Message.Messages;

namespace Study.Training.Application.ApplicationServices.Interface
{
    public interface ISubjectApplication
    {
        OperationResponse<M.SubjectMessage> Create(SubjectMessage subject);
        OperationResponse<M.SubjectMessage> Update(SubjectMessage subject);
        PageOperationResponse<M.SubjectMessage> Read(SubjectFilter filter);
        OperationResponse<M.SubjectMessage> Delete(Guid subject);
    }
}
