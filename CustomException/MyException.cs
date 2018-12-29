using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCustomExcept
{
    class MyException : Exception
    {
        public MyException(string msg) :base(msg)
        { }
        public MyException():base()
        { }
        public MyException(string message, Exception innermsg): base(message,innermsg)
        { }
    }
}
