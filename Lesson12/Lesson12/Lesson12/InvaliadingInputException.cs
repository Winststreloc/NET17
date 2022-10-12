using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson12
{
    public class InvaliadingInputException : Exception
    {
        public InvaliadingInputException(string message): base(message) { }
    }
}
