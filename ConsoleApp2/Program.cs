using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatAndEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            Console.WriteLine("Daxil edin : ");
            var str = Console.ReadLine();
            Func func = mc.Space;
            func += mc.Reverse;
            Run run = new Run();
            run.RunFunc(func,str);

        }

    }
}
