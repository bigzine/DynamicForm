﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dyform
{
    public abstract class QuestionBaseContainer : QuestionBase
    {
        public IList<QuestionBase> SubQuestions { get; set; }

        public QuestionBaseContainer()
        {
            SubQuestions = new List<QuestionBase>();
        }

        public QuestionBase AddNewQuestion(Type composite)
        {
            var question = Activator.CreateInstance(composite) as QuestionBase;
            if (question != null)
            {
                question.Parent = this;

                SubQuestions.Add(question);
                return question;
            }
            return null;
        }

        public bool Contains(QuestionBase q1)
        {
            QuestionBase questionParent = (QuestionBaseContainer)q1.Parent;
            while (questionParent != null)
            {
                if (questionParent.Equals(this))
                {
                    return true;
                }
                questionParent = questionParent.Parent;
            }
            return false;
        }
    }
}
