using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyform
{
  public   class CompositeQuestion :QuestionBase
  {
      public IList<QuestionBase> SubQuestions { get; set; }

      public CompositeQuestion()
      {
          SubQuestions = new List<QuestionBase>();
      }

   

      public override QuestionBase AddNewQuestion(Type composite)
      {
          throw new NotImplementedException();
      }

      public bool Countains(CompositeQuestion question)
      {
          return false;
      }

     
  }
}
