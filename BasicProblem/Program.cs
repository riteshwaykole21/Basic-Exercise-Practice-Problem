using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 : Print Hello");
            Console.WriteLine("2 : Sum Of Two Number");
            Console.WriteLine("3 : Dividing Two Number");
            Console.WriteLine("4 : Print Result Of Specified opration");
            Console.WriteLine("Enter A Option");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    Basics basics = new Basics();
                    basics.Hello();
                    break;
                case 2:
                    Sum sum = new Sum();
                    sum.Add();
                    break;
                case 3:
                    Dividing dividing = new Dividing();
                    dividing.divide();
                   break;
                case 4:
                    SpecificOpration specificOpration = new SpecificOpration();
                    specificOpration.Special();
                    break;
            }
            Console.ReadLine();

        }
    }
}
