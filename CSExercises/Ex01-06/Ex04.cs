﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex04
    {
        public static void Main(string[] args)
        {
            double Number;
            double SqrtNumber;
            Console.WriteLine("Please enter a number:");
            String c = Console.ReadLine();
            Number = Convert.ToDouble(c); 
            SqrtNumber = Math.Sqrt(Number);
            Console.WriteLine("Square root of {0} is {1}.", Number, SqrtNumber);
            
        }
    }
}
