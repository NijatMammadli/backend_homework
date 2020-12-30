using System;
using System.Collections.Generic;
using System.Text;

namespace hw_exceptions_1
{
    class  PersonException : Exception
    {
        public int K { get; }
        public PersonException(string message, int k) : base(message)
        {
            K = k;

        }
    }
}
