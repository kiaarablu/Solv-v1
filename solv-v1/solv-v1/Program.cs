using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solv_v1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Process a = new Process();
            a.AddFirst(1);
            a.AddLast(2);
            a.AddLast(3);
            a.AddLast(4);
            a.AddLast(5);
            a.AddLast(6);
            a.printsolv();
            Console.ReadKey();
        }
    }
}
