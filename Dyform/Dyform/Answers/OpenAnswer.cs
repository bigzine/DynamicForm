using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyform
{
    public class OpenAnswer:AnswerBase
    {
        public string openLabel;
        private OpenQuestion qOpen;

        public OpenAnswer(OpenQuestion qOpen, String response) : base()
        {
            // TODO: Complete member initialization
            this.qOpen = qOpen;
            this.openLabel = response;
        }
    }
}
