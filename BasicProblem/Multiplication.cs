using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem
{
    public class Multiplication
    {
        public void Three()
        {
            Console.WriteLine("Enter the First Number");
            int FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Second Number");
            int SecondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Third Number");
            int ThirdNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(FirstNumber*SecondNumber*ThirdNumber );

        }
    }
}
