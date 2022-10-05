using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork.Exceptions
{
    class CustomException : Exception
    {
        public CustomException(string msg) : base(msg)
        {

        }

        //public CustomException(string msg,CustomException innnerCustom ) : base(msg, innnerCustom)
        //{

        //}
    }
}
