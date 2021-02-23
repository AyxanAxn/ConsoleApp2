using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatAndEvent
{
    class MyClass
    {
        public void Space(string data) {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sb.Append(data[i]);


                if (i<data.Length-1)
                sb.Append('_');
            }
            Console.WriteLine(sb);
        }
        public void Reverse(string data) {
                StringBuilder sb = new StringBuilder();
            for (int i = data.Length-1; i >=0; i--)
            {
               
                sb.Append(data[i]);

            }
            Console.WriteLine(sb);
        }
    }
}
