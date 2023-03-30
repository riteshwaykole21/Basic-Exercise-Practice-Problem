using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem
{
    public class Oprations
    {
        public void Addition()
        {
            Console.WriteLine("Enter The First Number");
            int FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int SecondNumber =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(FirstNumber + SecondNumber);
            Console.WriteLine(FirstNumber - SecondNumber);
            Console.WriteLine(FirstNumber * SecondNumber);
            Console.WriteLine(FirstNumber / SecondNumber);
        }
    }
}
