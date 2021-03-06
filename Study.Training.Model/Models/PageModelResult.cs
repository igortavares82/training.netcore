﻿using Study.Training.Model.Filters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Study.Training.Model.Models
{
    public class PageModelResult<T> : ModelResult<IEnumerable<T>>
    {
        public PageModelResult(Filter filter)
        {
            PageIndex = filter.PageIndex;
            PageSize = filter.PageSize;
        }

        public int PageIndex { get; set; }
        public int PageCount { get { return (int)Math.Ceiling(Convert.ToDecimal(this.RowCount / this.PageSize)); } }
        public int RowCount { get; set; }
        public int PageSize { get; set; }
    }
}
