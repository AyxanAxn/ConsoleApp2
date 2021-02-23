using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatAndEvent
{

    public delegate void Func(string str);
    class Run
    {
        public void RunFunc(Func func, string str)
        {
            func(str);


        }
    };

}
