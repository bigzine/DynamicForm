using System;
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

 public QuestionBaseContainer AddNewQuestionBaseContainer(Type composite)
        {
            var question = Activator.CreateInstance(composite) as QuestionBaseContainer;
            if (question != null)
            {
                question.Parent = this;

                SubQuestions.Add(question);
                return question;
            }
            return null;
        }

        {
   public bool RemoveQuestion(QuestionBase questionRemoved)
        {
            if (Contains(questionRemoved))
            {
                QuestionBaseContainer parent = questionRemoved.Parent;
                parent.SubQuestions.Remove(questionRemoved);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Contains(QuestionBase q1)
        {
            QuestionBaseContainer questionParent = q1.Parent;
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
