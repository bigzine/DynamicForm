using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyform
{
    public class OpenQuestion:QuestionBase
    {
        public QuestionBase _parent;
        public Form _form
        {
            get
            {
                return _parent._form;
            }
        }
    }
}
