using Study.Training.Message.Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Study.Training.Message.Operations
{
    public class PageOperationResponse<T> : OperationResponse<T> where T : Study.Training.Message.Messages.Message
    {
        public int PageIndex { get; set; }
        public int PageCount { get { return (int) Math.Ceiling(Convert.ToDecimal(this.RowCount / this.PageSize)); } }
        public int RowCount { get; set; }
        public int PageSize { get; set; }
        new IEnumerable<T> Data { get; set; }
    }
}
