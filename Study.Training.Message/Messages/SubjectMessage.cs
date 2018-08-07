using System;
using System.Collections.Generic;
using System.Text;

namespace Study.Training.Message.Messages
{ 
    public class SubjectMessage : Message
    {
        public SubjectMessage() : base() { }

        public Guid Id { get; set; }
        public string Description { get; set; }
    }
}
