using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "hello";
            string s2 = "hell0o";

            if (s1.ToString().Equals(s2))
            {
                Console.WriteLine("s1 equals s2...");
            }
        }
    }
}
