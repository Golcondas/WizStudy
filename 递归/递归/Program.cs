using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 递归
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Foo(9));
            Console.ReadKey();
        }

        public static int Foo(int n) 
        {
            if (n <= 0)
            {
                return 0;
            }
            else if (n > 0 && n <= 2)
            {
                return 1;
            }
            else 
            {
                return Foo(n - 1) + Foo(n-2);
            }
        }
    }
}
