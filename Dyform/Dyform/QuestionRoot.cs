using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dyform
{
  public   class QuestionRoot:QuestionBase
    {
      private Form _form;
      public string Label { get; set; }
      private QuestionRoot _subQuestions;
      private int _counter;


      
      public override QuestionBase AddNewQuestions(string name)
      {
          var composite = new CompositeQuestion();
          composite.Parent = this;
          SubQuestions.Add(composite);
          _counter++;
          return composite;
      }

      public override QuestionBase AddNewQuestions(Type composite)
      {
          var composit = new CompositeQuestion();
          composit.Index = _counter;
          composit.Parent = this;
          SubQuestions.Add(composit);
          _counter++;

          return composit;
      }


    }
}
