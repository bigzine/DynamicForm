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
        private QuestionBase _parent;
        public bool AllowEmptyAnswer;
        public QuestionBase Parent
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

        public Form _form 
        {
            virtual get { return _parent._form; }
            private set;
        }

        private void SwitchIndex(int value)
        {
            Parent.SubQuestions.Remove(this);
            Parent.SubQuestions.Insert(value, this);

        }

        public QuestionBase()
        {
            SubQuestions=new List<QuestionBase>();
        }
        
        public IList<QuestionBase> SubQuestions { get; set; }

        public abstract QuestionBase AddNewQuestion(Type composite);

        public bool Countains(QuestionBase q1)
        {
            QuestionBase questionParent = q1.Parent;
            while (questionParent != null)
            {
                if (questionParent.Equals(this))
                {
                    return true;
                }
                questionParent = questionParent.Parent;
            }
            return false;
        }

   }
}
