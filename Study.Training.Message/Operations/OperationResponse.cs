using System;
using System.Collections.Generic;
using System.Linq;
using Study.Training.Message.Messages;
using Study.Training.Message.Operations;

namespace Study.Training.Message.Operations
{
    public class OperationResponse<T>
    {
        public OperationResponse(Guid protocol)
        {
            this.Protocol = protocol;
            this.Messages = new List<string>();
        }

        public OperationResponse(Guid protocol, OperationStatusType status) : this(protocol)
        {
            this.Status = status;
        }

        public Guid Protocol { get; set; }
        public T Data { get; set; }
        public IList<string> Messages { get; set; }
        public OperationStatusType Status { get; protected set; }
    }
}
