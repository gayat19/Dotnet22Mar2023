using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingApp
{
    public class MyNUmberExceptioncs:Exception
    {
        string msg;
        public MyNUmberExceptioncs()
        {
            msg = "Thenumber has to greater than 5";
        }
        public override string Message => msg;
    }
}
