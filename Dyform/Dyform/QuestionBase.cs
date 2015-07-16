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

      public override QuestionBase AddNewQuestion(string name)
      {
          throw new NotImplementedException();
      }

      public override QuestionBase AddNewQuestion(Type composite)
      {
          throw new NotImplementedException();
      }


    }
}
