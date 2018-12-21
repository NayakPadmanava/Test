using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOverride
{
    class MasterBase
    {
        public virtual void Add()
        {
            Console.WriteLine("Base Method");
        }
    }

    class studentChild :MasterBase
    {
        public  void Add()
        {
            Console.WriteLine("Derived Method");
        }

    }
}
