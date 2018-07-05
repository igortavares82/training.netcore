using Study.Training.Model.Entities.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Study.Training.Model.Entities.Concrete
{
    public class Question : IEntity, IRootAggregate
    {
        public Guid Id { get; private set; }
        public string Description { get; private set; }
        public IEnumerable<Answer> Answers { get; private set; }
        public Subject Subject { get; private set; }

        public Question(Guid id, string description, IEnumerable<Answer> answers, Subject subject)
        {
            this.Id = id;
            this.Description = description;
            this.Answers = answers;
            this.Subject = subject;
        }

        public void Update(string description, IEnumerable<Answer> answers, Subject subject)
        {
            this.Description = description;
            this.Answers = answers;
            this.Subject = subject;
        }

        public Answer GetAnswer() => this.Answers.FirstOrDefault(x => x.IsCorrect);
    }
}
