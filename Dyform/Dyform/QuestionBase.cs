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
        private QuestionBaseContainer _parent;
        public bool AllowEmptyAnswer;
        public QuestionBaseContainer Parent
        {
            get { return _parent; }
            set
            {
                if (value == null)
                {
                    Parent.SubQuestions.Remove(this);
                }
                _parent = value;
            }
        }

        public int Index
        {
            get { return Parent.SubQuestions.IndexOf(this); }
            set
            {
                if (Parent!=null)
                    SwitchIndex(value);
            }
        }

        public virtual Form _form 
        {
             get { return _parent._form; }
             protected set { _form = value;  }

        }

        private void SwitchIndex(int value)
        {
            Parent.SubQuestions.Remove(this);
            Parent.SubQuestions.Insert(value, this);

        }

        public QuestionBase()
        {
          
        }
        
      

   }
}
