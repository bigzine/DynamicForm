using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace Dyform.ViewModel
{
  public   class BooleanViewModel:ViewModelBase
  {
      public string Label { get { return _booleanQuestion.QuestionLabel; } }
      private BooleanQuestion _booleanQuestion;

      public BooleanViewModel()
      {
          _booleanQuestion=new BooleanQuestion();
      }

  }
}
