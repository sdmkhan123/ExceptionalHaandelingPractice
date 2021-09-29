using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionalHaandelingPractice
{
    public class CustomExceptionHandling : ApplicationException
    {
        public override string Message
        {
            get
            {
                return "Divide by odd num exception happens";
            }
        }
    }
}
