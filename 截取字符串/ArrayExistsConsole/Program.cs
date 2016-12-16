using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExistsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] array = { "cat", "dot", "perls" };

            //// Use Array.Exists in different ways.
            //bool a = Array.Exists(array, element => element == "perls");
            //bool b = Array.Exists(array, element => element == "python");
            //bool c = Array.Exists(array, element => element.StartsWith("d"));
            //bool d = Array.Exists(array, element => element.StartsWith("x"));

            //// Output.
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(d);

            string[] SetSelectIds = { "aa", "bb", "cc" };

            string id = "bb";

            if (Array.Exists(SetSelectIds, element => element.Equals(id)))
            {
                var result=Array.IndexOf(SetSelectIds, id) >= 0;
            }
        }
    }
}
