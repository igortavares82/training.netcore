using Study.Training.Message.Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Study.Training.Message.Operations
{
    public class PageOperationResponse<T> : OperationResponse<IEnumerable<T>>
    {
        public PageOperationResponse(Guid protocol) : base (protocol) { }

        public PageOperationResponse(Guid protocol, OperationStatusType status) : this(protocol)
        {
            base.Status = status;
        }

        public int PageIndex { get; set; }
        public int PageCount { get; set; }
        public int RowCount { get; set; }
        public int PageSize { get; set; }
    }
}
