using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dyform
{
  public   class QuestionBase :ACompositeQuestion
    {
      public int Index { get; set; }
      public QuestionBase Parent { get; set; }

      public override QuestionBase AddNewQuestions(string name, bool typeQuestion)
      {
          throw new NotImplementedException();
      }

      public override QuestionBase AddNewQuestions(Type composite, bool typeQuestion)
      {
          throw new NotImplementedException();
      }
    }
}
