using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem
{
    public class Average
    {
        public void AverageNum()
        {
            Console.WriteLine("Enter The First Number");
            int First = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Second Number");
            int Second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Thired Number");
            int Third = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Four Number ");
            int Four = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Average of All Numbers Are Given below");
            Console.WriteLine((First + Second + Third + Four)/4);
        }

    }
}
