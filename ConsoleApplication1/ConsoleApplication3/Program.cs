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
            
            int[] zip = new int[10] { 50535, 30523, 59201, 10234, 02934, 92855, 20203, 72045, 30919, 40404 };
            float[] charge = new float[10] { 0.10f, 0.20f, 0.30f, 0.40f, 0.50f, 0.60f, 0.70f, 0.80f, 0.90f, 1.0f };

            Console.WriteLine("Enter your zip (61235, 30523, 59245, 10234, 02934, 92855, 51235, 72045, 30919, 40404):");
            int zipinput = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < zip.Length; i++)
            {
                if (zipinput == zip[i])
                {
                    Console.WriteLine("The cost to deliver to your house is ${0}!", charge[i]);
                    
                }

                else
                {
                    Console.WriteLine("We don't deliver there.");
                    
                }
            }
        }
    }
}
