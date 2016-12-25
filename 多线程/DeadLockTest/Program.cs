using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadLockTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //new Program().DeadLockTest(100);
            new Program().TestThread();
            Console.ReadKey();
        }

        void DeadLockTest(int i)
        {
            lock (this)
            {
                if (i > 10)
                {
                    Console.WriteLine(i--);
                    DeadLockTest(i);
                }
            }
        }

        public void TestThread()
        {
            decimal a = 0;
            //System.Threading.Tasks.Parallel.For(0, 100000, (i) =>
            //{
            //    a++;
            //});
            for (int i = 0; i < 100000; i++)
            {
                a+=i;
                Console.WriteLine(a);
            }
            
        }
    }
}
