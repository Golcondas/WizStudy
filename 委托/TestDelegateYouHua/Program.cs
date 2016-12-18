using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDelegateYouHua
{
    /// <summary>
    /// 对委托进行进度2
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

        static void Main(string[] args)
        {
            string chineseName = "小王";
            string englishName = "neil";
            MarkGreeting markGreeting1 = ChineseGreeting;
            MarkGreeting markGreeting2 = EnglishGreeting;
            //MarkGreeting mark2Greeting2 = EnglishGreeting;
            markGreeting1(chineseName);
            markGreeting2(englishName);
            //markGreeting1(englishName);
            Console.ReadKey();
        }
    }
}
