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

        public Dictionary<QuestionBase, AnswerBase> answers;

        internal FormAnswer(string key)
        {
            uniqueName = key;
            answers = new Dictionary<QuestionBase, AnswerBase>();
        }

        public AnswerBase FindAnswer(QuestionBase q)
        {
            return answers[q];
        }

        public AnswerBase AddAnswerFor(OpenQuestion qOpen, string label)
        {
            OpenAnswer answer = new OpenAnswer(qOpen, label);

            answers.Add(qOpen, answer);

            return answer;
        }
    }
}
