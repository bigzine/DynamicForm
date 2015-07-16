using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyform
{
    public abstract  class QuestionBase

   {
        public string Title { get; set; }
        public QuestionBase Parent;
        public int Index;


       public abstract QuestionBase AddNewQuestions(string name);

        public abstract QuestionBase AddNewQuestions(Type composite);

        public bool Countains(QuestionBase q1)
        {
            throw new NotImplementedException();
        }
   }
}
