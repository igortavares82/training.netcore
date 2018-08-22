using System;
using System.Collections.Generic;
using System.Text;

namespace Study.Training.Model.Filters
{
    public class Filter
    {
        public Guid Id { get; set; }
        public Guid Protocol { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }

        public int Skip { get { return this.PageSize * (this.PageIndex - 1); } }
        public int Take { get { return this.PageSize * this.PageIndex; } }
    }
}
