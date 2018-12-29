using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCustomExcept
{
    class ImpementMyException
    {
        public void GetItem()
        {
            //try
            //{
                int[] arr = new int[5] { 1, 2, 3, 4, 5 };
                
                if(arr.Length < 6)
                //throw new IndexOutOfRangeException();
                throw (new MyException("Hey there is one exception. you are trying to insert element more than size of array"));
            //}
            //catch(MyException ex)
            //{ }
        }
    }
}
