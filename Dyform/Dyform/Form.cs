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
        Dictionary<string, FormAnswer> Answers; 

        public Form()
        {

        }

        public FormAnswer FindOrCreateAnswer(string fName, string name)
        {
            var newKey = fName + "/" + name;
            if( Answers[newKey] == null){
                AnswerCount++;
                return new FormAnswer(newKey);
            }
            else{
                return Answers[newKey];
            }
        }

    }
}
