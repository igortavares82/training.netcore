using M = Study.Training.Message.Messages;
using Study.Training.Message.Operations;
using System;
using System.Collections.Generic;
using System.Text;
using Study.Training.Model.Filters;

namespace Study.Training.Application.ApplicationServices.Interface
{
    public interface SubjectApplication
    {
        OperationResponse<M.Message> Create(Subject subject);
        OperationResponse<M.Message> Update(Subject subject);
        PageOperationResponse<IEnumerable<M.Message>> Read(SubjectFilter filter);
        OperationResponse<Message> Delete(Subject subject);


    }
}
