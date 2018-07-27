using System;
using System.Collections.Generic;
using System.Text;
using Study.Training.Message.Messages;
using Study.Training.Message.Operations;

namespace Study.Training.Message.Operations
{
    public class OperationResponse<T>
    {
        public OperationResponse(Guid protocol)
        {
            this.Protocol = protocol;
        }

        public Guid Protocol { get; set; }
        public T Data { get; set; }
        public IEnumerable<string> Messages { get; set; }
        public OperationStatusType Status { get; set; }
    }
}
