using Study.Training.Model.Entities.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Study.Training.Model.Entities.Concrete
{
    public class Answer : IEntity
    {
        public Guid Id { get; private set; }
        public string Text { get; private set; }
        public bool IsCorrect { get; private set; }
        public Question Question { get; private set; }

        public Answer(Guid id, string text, bool isCorrect, Question question)
        {
            this.Id = id;
            this.Text = text;
            this.IsCorrect = isCorrect;
            this.Question = question;
        }

        public void Update(string text, bool isCorrect, Question question)
        {
            this.Text = text;
            this.IsCorrect = isCorrect;
            this.Question = question;
        }
    }
}
