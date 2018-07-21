using Study.Training.Model.Entities.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Study.Training.Model.Entities.Concrete
{
    public class Subject : IEntity, IRootAggregate
    {
        public Guid Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public IEnumerable<Question> Questions { get; private set; }

        public Subject() { }

        public Subject(Guid id, string title, string description, IEnumerable<Question> questions)
        {
            this.Id = id;
            this.Title = title;
            this.Description = description;
            this.Questions = questions;
        }

        public void Update(string title, string description, IEnumerable<Question> questions)
        {
            this.Title = title;
            this.Description = description;
            this.Questions = questions;
        }
    }
}
