﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int s = 0;
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("Квадрат числа {0} равен {1}", i, s = s + (2 * i - 1));
            }
            Console.ReadKey();
        }
    }
}
