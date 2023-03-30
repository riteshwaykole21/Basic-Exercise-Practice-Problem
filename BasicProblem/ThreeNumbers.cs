using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem
{
    public class ThreeNumbers
    {
        public void Three()
        {
            Console.WriteLine("Enter First Number");
            int X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number ");
            int Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third Number ");
            int Z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((X + Y)*Z);
            Console.WriteLine(X*Y+Y*Z);
        }
    }
}
