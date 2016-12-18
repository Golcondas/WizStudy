using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDelegateYouHua2
{
    class Program
    {
        static void Main(string[] args)
        {
            GreetingManager gm = new GreetingManager();
            gm.GreetPeople("小王",ChineseGreeting);
            gm.GreetPeople("neil", EnglishGreeting);
            Console.ReadKey();
        }

        public static void ChineseGreeting(string name)
        {
            Console.WriteLine("早上好" + name);
        }

        public static void EnglishGreeting(string name)
        {
            Console.WriteLine("Good Morning " + name);
        }
    }

    public class GreetingManager
    {
        public delegate void MarkGreeting(string name);

        //public MarkGreeting delegate1;
        public void GreetPeople(string name,MarkGreeting delegate1)
        {
            //如果有方法注册委托变量
            if (delegate1 != null)
            {
                delegate1(name);//通过委托调用方法
            }
        }
    }
}
