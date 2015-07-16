using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dyform
{
    public class FormAnswer
    {
        public string uniqueName {get; private set;}
        public Form owner;

        public List<AnswerBase> answers;

        internal FormAnswer(string key)
        {
            uniqueName = key;
            answers = new List<AnswerBase>();
        }

        public AnswerBase FindAnswer(QuestionBase q)
        {
            foreach(AnswerBase ab in answers)
            {
                if (ab.question.Equals(q))
                {
                    return ab;
                }
            }
            return null;
        }

        public AnswerBase AddAnswerFor(OpenQuestion qOpen)
        {
            OpenAnswer answer = new OpenAnswer(qOpen);

            return answer;
        }
    }
}
