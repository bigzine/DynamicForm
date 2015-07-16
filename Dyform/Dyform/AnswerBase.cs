using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyform
{
    public class AnswerBase
    {
        public QuestionBase question;

        public AnswerBase(QuestionBase q)
        {
            question = q;
        }
    }
}
