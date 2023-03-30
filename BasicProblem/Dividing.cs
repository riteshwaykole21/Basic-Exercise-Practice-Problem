using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem
{
    public class Dividing
    {
        public void divide()
        {
            Console.WriteLine("Enter A First Number");
            int FirstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter A Second Number ");
            int SecondNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(FirstNum / SecondNum);
        }
    }
}
