﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program3
{
	class Program
	{
		static void Main(string[] args)
		{

            int a, b, c;
            Console.Write("Enter the value of A:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of B:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of C:");
            c = Convert.ToInt32(Console.ReadLine());
            if (a > b && a > c)
                Console.WriteLine("A is Largest");
            else if (b > a && b > c)
                Console.WriteLine("B is Largest");
            else if (c > a && c > b)
                Console.WriteLine("C is Largest");
            else
                Console.WriteLine("equals");

            Console.ReadKey();
        }
	}
}
