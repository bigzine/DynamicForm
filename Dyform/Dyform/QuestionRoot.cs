using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dyform
{
  public   class QuestionRoot:QuestionBase
    {

      private Form _Formulaire;
      public Form _form
      {
          override get { return _Formulaire; }
 
      }
      public string Label { get; set; }
      private QuestionRoot _subQuestions;
      private int _counter;


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
