using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dyform
{
  public   class QuestionRoot:QuestionBase
    {
      public Form Form1 { get;  set; }
      public string Label { get; set; }
      private int _counter;


      
    


      public override QuestionBase AddNewQuestion(Type composite)
      {
          var composit = new CompositeQuestion();
          var question = Activator.CreateInstance(composite) as QuestionBase;
          if (question != null)
          {
              question.Index = _counter;
              question.Parent = this;
        
              SubQuestions.Add(question);
              return question;
          }
          return null;
      }
    }
}
