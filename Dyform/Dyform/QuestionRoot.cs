using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dyform
{
  public   class QuestionRoot:QuestionBase
    {
      public int Index { get; set; }
      private Form _form;

      public override QuestionBase AddNewQuestions(string name)
      {
          throw new NotImplementedException();
      }

      public override QuestionBase AddNewQuestions(Type composite)
      {
          throw new NotImplementedException();
      }


    }
}
