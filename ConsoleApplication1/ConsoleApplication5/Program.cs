using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            double minutes, totalcost = 0;
            int[] area = new int[6] { 262, 414, 608, 715, 815, 920 };
            double[] cost = new double[6] { 0.07d, 0.10d, 0.05d, 0.16d, 0.24d, 0.14d };
            bool isareainput = false;
            Console.WriteLine("Enter your area code (262, 414, 608, 715, 815, 920):");
            int areainput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the minutes that you've used.");
             minutes = Convert.ToInt32(Console.ReadLine());
            
            

            for (int i = 0; i <= area.Length; i++)
            {
                if (areainput == area[i])
                {
                    isareainput = true;
                    totalcost = cost[i];
                }
                if (isareainput)
                {
                    Console.WriteLine("The cost is ${0}", totalcost)
            }
        }
    }
}
