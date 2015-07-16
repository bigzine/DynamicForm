using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dyform
{
    public class Form
    {
        public string Title
        {
            get{
                if (Questions.Title != null)
                {
                   return Questions.Title;
                }

                return _title;
            }
            set { _title = value; }}

        public int AnswerCount { get; private set; }
        public QuestionRoot Questions { get; set; }

        Dictionary<string, FormAnswer> Answers;
        private string _title;

        public Form()
        {
            Answers = new Dictionary<string, FormAnswer>();
            Questions = new QuestionRoot();
        }

        public FormAnswer FindOrCreateAnswer(string fName, string name)
        {
            var newKey = fName + "/" + name;

            if ( !Answers.ContainsKey(newKey) )
            {
                Answers[newKey] = new FormAnswer(newKey);
                AnswerCount++;
            }
            
            return Answers[newKey];
        }

    }
}
