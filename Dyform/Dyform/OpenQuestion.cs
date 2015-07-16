using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyform
{
    public class OpenQuestion:QuestionBase
    {
        string labelQuestion;
        QuestionBase _parent;

        public override QuestionBase AddNewQuestion(Type composite)
        {
            throw new NotImplementedException();
        }
    }
}
