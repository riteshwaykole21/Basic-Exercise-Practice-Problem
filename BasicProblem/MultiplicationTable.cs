﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem
{
    public class MultiplicationTable
    {
        public void Multiply()
        {
            Console.WriteLine("Enter A Number ");
            int Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Given Number Table Is");
            Console.WriteLine(Number * 1);
            Console.WriteLine(Number * 2);
            Console.WriteLine(Number * 3);
            Console.WriteLine(Number * 4);
            Console.WriteLine(Number * 5);
            Console.WriteLine(Number * 6);
            Console.WriteLine(Number * 7);
            Console.WriteLine(Number * 8);
            Console.WriteLine(Number * 9);
            Console.WriteLine(Number * 10);
        }
    }
}
