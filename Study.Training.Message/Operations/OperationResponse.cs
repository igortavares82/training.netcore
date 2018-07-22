using System;
using System.Collections.Generic;
using System.Text;
using Study.Training.Message.Messages;
using Study.Training.Message.Operations;

namespace Study.Training.Message.Operations
{
    public class OperationResponse<T> where T : Study.Training.Message.Messages.Message
    {
        public Guid Protocol { get; set; }
        public T Data { get; set; }
        public string[] Messages { get; set; }
        public OperationStatusType Status { get; set; }
    }
}
