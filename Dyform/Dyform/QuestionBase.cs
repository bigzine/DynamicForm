using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyform
{
    public abstract  class QuestionBase

   {
        public string Title { get; set; }
        public QuestionBase Parent;

        public int Index
        {
            get { return _index; }
            set
            {
                _index = value;
                if (Parent!=null)
                SwitchIndex(value);
            }
        }

        private void SwitchIndex(int value)
        {
            var i = value;
          
            Parent.SubQuestions.RemoveAt(_index);
            Parent.SubQuestions.Insert(value, this);

        }

        public QuestionBase()
        {
            SubQuestions=new List<QuestionBase>();
        }
        
        public IList<QuestionBase> SubQuestions { get; set; }
        private int _index;

       public abstract QuestionBase AddNewQuestions(string name);

        public abstract QuestionBase AddNewQuestions(Type composite);

        public bool Countains(QuestionBase q1)
        {
            throw new NotImplementedException();
        }

   }
}
