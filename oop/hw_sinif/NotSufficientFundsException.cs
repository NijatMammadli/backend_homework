using System;
using System.Collections.Generic;
using System.Text;

namespace hw_sinif
{
    class NotSufficientFundsException : Exception
    {
        public NotSufficientFundsException(string message) : base(message)
        {

        }
    }
}
