using System;
using System.Collections.Generic;
using System.Text;

namespace Study.Training.Model.Dtos
{
    public class Dto
    {
        public Guid Id { get; set; }
        public Guid Protocol { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }
}
