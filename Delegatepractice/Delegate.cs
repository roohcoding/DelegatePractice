using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegatepractice
{
          //public void Add(int x, int y)
          //public delegate void AddDelegate()
        public delegate void AddDelegate(int a, int b);
        public delegate string GreetingsDelegate(string name);

        public class Delegate
        {
           
            public void Add(int x, int y)
            {
                Console.WriteLine(@"The Sum of {0} and {1}, is {2} ", x, y, (x + y));
            }

            public static string Greetings(string name)
            {
                return "Hello @" + name;
            }

                         
        }
}
