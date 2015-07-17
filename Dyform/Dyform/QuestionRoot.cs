using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dyform
{
    public class QuestionRoot:QuestionBaseContainer
    {   
        public string Label { get; set; }
        private int _counter;
        public override Form _form
        {
            get
            {
                return _form;
            }
        }

        public QuestionRoot(Form f)
           :base()
        {
           _form = f;
        }
    }
}
