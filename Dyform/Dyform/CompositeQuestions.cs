using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyform
{
  public   class CompositeQuestions :ACompositeQuestion
  {
      public IList<ACompositeQuestion> SubQuestions { get; set; }

      public override QuestionBase AddNewQuestions(string name, bool typeQuestion)
      {
          throw new NotImplementedException();
      }

      public override QuestionBase AddNewQuestions(Type composite,bool typeQuestion)
      {
          throw new NotImplementedException();
      }

      public bool Countains(ACompositeQuestion question)
      {
          return false;
      }
    }
}
