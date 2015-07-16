using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dyform
{
    public class FormAnswer
    {
        public string uniqueName {get; private set;}

        internal FormAnswer(string key)
        {
            uniqueName = key;
        }
    }
}
