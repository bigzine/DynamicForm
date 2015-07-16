using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyform
{
    class OpenQuestion
    {
        string labelQuestion;
        QuestionBase _parent;
        Form _form
        {
            get
            {
                return _parent._form;
            }
        }
    }
}
