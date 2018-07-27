using System;
using System.Collections.Generic;
using System.Linq;

namespace Study.Training.Model.Models
{
    public class ModelResult<T>
    {
        public ModelResult()
        {
            this.Messages = new List<string>();
        }

        public Guid Protocol { get; set; }
        public T Data { get; set; }
        public IEnumerable<string> Messages { get; set; }

        public bool IsValid()
        {
            return this.Messages.Count() > 0;
        }
    }
}
