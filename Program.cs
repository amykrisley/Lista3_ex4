using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b;
            do
            {
                a++;
                b = 5 * a;
                Console.WriteLine("5 * {0} = {1}", a, b);
            }
            while (a < 10);
        }
    }
}
