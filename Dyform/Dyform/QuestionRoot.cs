using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dyform
{
    public class QuestionRoot:QuestionBaseContainer
    {   
        public string Label { get; set; }
     
        public QuestionRoot(Form f)
           :base()
        {
           Form = f;
        }
    }
}
