using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 10 Zip Codes that range from 0-1000:");
            int[] zip = new int[10];
            for (int i = 0; i < zip.Length; i++)
            {
                zip[i] = Convert.ToInt32(Console.ReadLine());

                if (zip[i] > 500)
                {
                    Console.WriteLine("We deliver there!");
                }
                else
                {
                    Console.WriteLine("We don't deliver there...");
                }
            }

         }
    }
}
