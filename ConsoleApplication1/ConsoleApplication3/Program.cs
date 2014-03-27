using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] zip = new int[10];
            Console.WriteLine("Enter 10 Zip Codes between 1-1000");
            for (int i = 0; i < zip.Length; i++)
            {
                zip[i] = Convert.ToInt32(Console.ReadLine());
                float[] charge = new float[10] { 0.10f, 0.20f, 0.30f, 0.40f, 0.50f, 0.60f, 0.70f, 0.80f, 0.90f, 1.0f };
                if (zip[i] >= 0 && zip[i] < 50)
                {
                    Console.WriteLine("The cost to deliver to your location is ${0}", charge[0]);
                }
                if (zip[i] >= 50 && zip[i] < 100)
                {
                    Console.WriteLine("The cost to deliver to your location is ${0}", charge[1]);
                }
                if (zip[i] >= 100 && zip[i] < 150)
                {
                    Console.WriteLine("The cost to deliver to your location is ${0}", charge[2]);
                }
                if (zip[i] >= 150 && zip[i] < 200)
                {
                    Console.WriteLine("The cost to deliver to your location is ${0}", charge[3]);
                }
                if (zip[i] >= 200 && zip[i] < 250)
                {
                    Console.WriteLine("The cost to deliver to your location is ${0}", charge[4]);
                }
                if (zip[i] >= 250 && zip[i] < 300)
                {
                    Console.WriteLine("The cost to deliver to your location is ${0}", charge[5]);
                }
                if (zip[i] >= 300 && zip[i] < 350)
                {
                    Console.WriteLine("The cost to deliver to your location is ${0}", charge[6]);
                }
                if (zip[i] >= 350 && zip[i] < 400)
                {
                    Console.WriteLine("The cost to deliver to your location is ${0}", charge[7]);
                }
                if (zip[i] >= 400 && zip[i] < 450)
                {
                    Console.WriteLine("The cost to deliver to your location is ${0}", charge[8]);
                }
                if (zip[i] >= 450 && zip[i] < 500)
                {
                    Console.WriteLine("The cost to deliver to your location is ${0}", charge[9]);
                }

                if (zip[i] > 501)
                {
                    Console.WriteLine("Your location is too far to deliver");
                }

            }
        }
    }
}
