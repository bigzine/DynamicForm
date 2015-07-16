using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyform
{
    public abstract  class ACompositeQuestion
   {
        public string Title;
       public abstract QuestionBase AddNewQuestions(string name, bool typeQuestion);

        public abstract QuestionBase AddNewQuestions(Type composite, bool typeQuestion);
   }
}
