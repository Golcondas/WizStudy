using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDelegate
{
    /// <summary>
    /// 简单的委托1
    /// </summary>
    class Program
    {
        public delegate void MarkGreeting(string name);

        public static void ChineseGreeting(string name)
        {
            Console.WriteLine("早上好" + name);
        }

        public static void EnglishGreeting(string name)
        {
            Console.WriteLine("Good Morning " + name);
        }

        public static void GreetPeople(string name, MarkGreeting markGreeting)
        {
            markGreeting(name);
        }

        static void Main(string[] args)
        {
            GreetPeople("小张", ChineseGreeting);
            GreetPeople("Neil", EnglishGreeting);
            Console.ReadKey();
        }
    }
}
