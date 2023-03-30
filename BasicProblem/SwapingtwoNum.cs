using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem
{
    public class SwapingtwoNum
    {
        public void Swap()
        {
            Console.WriteLine("Enter The First Number");
            int FirstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Second Number ");
            int SecondNum = Convert.ToInt32(Console.ReadLine());
            int X;
            X = SecondNum ;
            SecondNum = FirstNum;
            Console.WriteLine("Afer Swapping The Number is ");
            Console.WriteLine("The First Number is " + X);
            Console.WriteLine("The Second Number is " + FirstNum);

        }
    }
}
