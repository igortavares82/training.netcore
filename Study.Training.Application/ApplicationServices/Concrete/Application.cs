using Study.Training.Message.Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Study.Training.Application.ApplicationServices.Concrete
{
    public class Application
    {
        protected OperationResponse<T> CreateErrorResponse<T>(Exception ex, Guid protocol, OperationStatusType status) where T : Message.Messages.Message 
        {
            OperationResponse<T> response = new OperationResponse<T>(protocol, status);
            response.Messages.Add(ex.Message);

            return response;
        }

        protected PageOperationResponse<T> CreatePageErrorResponse<T>(Exception ex, Guid protocol, OperationStatusType status) where T : Message.Messages.Message
        {
            PageOperationResponse<T> response = new PageOperationResponse<T>(protocol, status);
            response.Messages.Add(ex.Message);

            return response;
        }
    }
}
