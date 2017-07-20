using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 多线程2
{
    class Program
    {
        const int repetitions = 100;
        static void Main(string[] ages) 
        {
            ThreadStart threadStart = DoWork;
            Thread thread = new Thread(threadStart);
            thread.Start();
            thread.Join();
            for (int i = 0; i < repetitions; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("主线程跑结束了");
            Console.ReadKey();
        }
        static void DoWork() 
        {
            for (int i = 0; i < repetitions; i++)
            {
                Console.Write("+");
            }
        }
        //const int Repetitions = 100;
        //static int index_thread = 0;
        //static int index_main = 0;
        //static void Main(string[] args)
        //{
        //    WaitCallback waitCallback = DoWork;
        //    ThreadPool.QueueUserWorkItem(waitCallback,"+");
        //    for (int i = 0; i < Repetitions; i++)
        //    {
        //        index_main++;
        //        Console.Write("-");
        //    }
        //    Console.WriteLine(string.Format("\nindex_thread:{0}", index_thread));
        //    Console.WriteLine(string.Format("index_main:{0}", index_main));
        //    Console.ReadKey();
        //}
        //static void DoWork(object ob)
        //{
        //    for (int count = 0; count < Repetitions; count++)
        //    {
        //        index_thread++;
        //        Console.Write(ob);
        //        if (count == Repetitions - 1)
        //        {
        //            Console.Write("我创建的线程执行完成了.....................................\n");
        //        }
        //    }
        //}
    }
}
