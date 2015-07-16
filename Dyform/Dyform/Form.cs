using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dyform
{
    public class Form
    {
        public string Title { get; set; }
        public int AnswerCount { get; private set; }
        public ACompositeQuestion Questions { get; set; }

        Dictionary<string, FormAnswer> Answers; 

        public Form()
        {
            Answers = new Dictionary<string, FormAnswer>();
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
