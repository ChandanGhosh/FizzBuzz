﻿using FizzBuzz.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                System.Console.WriteLine(FizzBuzzer.GetValue(i));
            }

            System.Console.ReadLine();
        }
    }
}