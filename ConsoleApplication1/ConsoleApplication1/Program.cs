using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intergers = { 90, 60, 40, 20, 77 };
            for (int i = 0; i < intergers.Length; i++)
            {
             
                Array.Sort(intergers);
                Array.Reverse(intergers);
                Console.WriteLine("{0}", intergers[i]);
            }
        }
    }
}
